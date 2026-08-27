using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        // Game variables
        private int timesToPlay = 5;
        private int maxPlayLimit = 25;
        private int remainingPlays;
        private List<ScoreEntry> scores = new List<ScoreEntry>();

        // User input game variables
        private int secretNumber;
        private int attempts;
        private string currentNickname;
        private Random random = new Random();

        // Sound
        private SoundPlayer soundPlayer = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.Text = "Number Guessing Game";
            this.ClientSize = new Size(900, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.MinimumSize = new Size(900, 650);
            this.MaximizeBox = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            StylePanel(menuPanel, Color.FromArgb(30, 30, 30));
            StylePanel(gamePanel, Color.FromArgb(30, 30, 30));
            StylePanel(settingsPanel, Color.FromArgb(30, 30, 30));
            StylePanel(scorePanel, Color.FromArgb(30, 30, 30));

            StyleButton(btnStartGame, Color.FromArgb(0, 122, 204), "🎮 Start Game");
            StyleButton(btnSettings, Color.FromArgb(106, 153, 85), "⚙️ Settings");
            StyleButton(btnScoreStatistics, Color.FromArgb(204, 120, 50), "🏆 Score Statistics");
            StyleButton(btnExit, Color.FromArgb(204, 51, 51), "❌ Exit");

            StyleButton(btnSubmitNickname, Color.FromArgb(0, 122, 204), "Start ▶");
            StyleButton(btnSubmitGuess, Color.FromArgb(0, 153, 76), "Submit ✓");
            StyleButton(btnMenuFromGame, Color.FromArgb(204, 51, 51), "◀ Back to Menu");

            StyleButton(btnSaveSettings, Color.FromArgb(0, 153, 76), "💾 Save Settings");
            StyleButton(btnMenuFromSettings, Color.FromArgb(204, 51, 51), "◀ Back to Menu");

            StyleButton(btnMenuFromScore, Color.FromArgb(204, 51, 51), "◀ Back to Menu");

            StyleLabel(feedbackLabel);
            StyleLabel(attemptsLabel);

            StyleTextBox(nicknameTextBox);
            StyleTextBox(guessTextBox);
            StyleTextBox(timesToPlayTextBox);

            scoreListBox.BackColor = Color.FromArgb(40, 40, 40);
            scoreListBox.ForeColor = Color.White;
            scoreListBox.Font = new Font("Consolas", 12);

            nicknameTextBox.KeyPress += NicknameTextBox_KeyPress;
            guessTextBox.KeyPress += GuessTextBox_KeyPress;

            ShowPanel(menuPanel);
        }

        private void StylePanel(Panel panel, Color backColor)
        {
            panel.BackColor = backColor;
        }

        private void StyleButton(Button btn, Color backColor, string text = null)
        {
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            if (text != null) btn.Text = text;
        }

        private void StyleLabel(Label label)
        {
            label.ForeColor = Color.White;
            label.Font = new Font("Segoe UI", 11);
            label.BackColor = Color.Transparent;
        }

        private void StyleTextBox(TextBox textBox)
        {
            textBox.BackColor = Color.FromArgb(60, 60, 60);
            textBox.ForeColor = Color.White;
            textBox.Font = new Font("Segoe UI", 11);
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ShowPanel(Panel panelToShow)
        {
            menuPanel.Visible = false;
            gamePanel.Visible = false;
            settingsPanel.Visible = false;
            scorePanel.Visible = false;

            panelToShow.Visible = true;
            panelToShow.Dock = DockStyle.Fill;
        }

        // ===== MENU BUTTON HANDLERS =====
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            remainingPlays = timesToPlay;
            ShowPanel(gamePanel);
            StartNewGame();
            PlaySound("start");
            ShowGif("start");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowPanel(settingsPanel);
            timesToPlayTextBox.Text = timesToPlay.ToString();
        }

        private void btnScoreStatistics_Click(object sender, EventArgs e)
        {
            ShowPanel(scorePanel);
            DisplayScoreStatistics();
            PlaySound("applause3");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?\n\nAmazing game! We appreciate you playing!",
                "Exit Game",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // ===== GAME LOGIC =====
        private void StartNewGame()
        {
            // Clear everything
            nicknameTextBox.Clear();
            guessTextBox.Clear();
            currentNickname = "";

            // Show only nickname input
            nicknameTextBox.Visible = true;
            btnSubmitNickname.Visible = true;
            nicknameTextBox.Enabled = true;
            btnSubmitNickname.Enabled = true;

            // Hide guess input
            guessTextBox.Visible = false;
            btnSubmitGuess.Visible = false;

            // Show labels with initial messages
            feedbackLabel.Visible = true;
            attemptsLabel.Visible = true;
            feedbackLabel.Text = "Enter your nickname to start";
            feedbackLabel.ForeColor = Color.LightBlue;
            attemptsLabel.Text = $"Remaining games: {remainingPlays}";
            attemptsLabel.ForeColor = Color.FromArgb(255, 204, 0);

            nicknameTextBox.Focus();
        }

        private void btnSubmitNickname_Click(object sender, EventArgs e)
        {
            string nickname = nicknameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nickname))
            {
                MessageBox.Show("Nickname cannot be empty. Please enter a valid nickname.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PlaySound("invalidSound");
                ShowGif("invalid");
                return;
            }

            if (!nickname.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Nickname can only contain letters and spaces.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PlaySound("invalidSound");
                ShowGif("invalid");
                return;
            }

            // Store nickname and generate secret number
            currentNickname = nickname;
            secretNumber = random.Next(1, 101);
            attempts = 0;

            // Hide nickname input
            nicknameTextBox.Visible = false;
            btnSubmitNickname.Visible = false;

            // Show guess input
            guessTextBox.Visible = true;
            btnSubmitGuess.Visible = true;
            guessTextBox.Enabled = true;
            btnSubmitGuess.Enabled = true;
            guessTextBox.Clear();

            // Update labels
            feedbackLabel.Text = $"Welcome {currentNickname}! Guess a number between 1-100";
            feedbackLabel.ForeColor = Color.LightBlue;
            attemptsLabel.Text = "Attempts: 0 / 7";
            attemptsLabel.ForeColor = Color.FromArgb(255, 204, 0);

            guessTextBox.Focus();
        }

        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guessTextBox.Text))
            {
                MessageBox.Show("Please enter a number.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PlaySound("invalidSound");
                ShowGif("invalid");
                guessTextBox.Focus();
                return;
            }

            if (!int.TryParse(guessTextBox.Text, out int guess))
            {
                MessageBox.Show("Please enter a valid number between 1 and 100.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PlaySound("invalidSound");
                ShowGif("invalid");
                guessTextBox.Clear();
                guessTextBox.Focus();
                return;
            }

            if (guess < 1 || guess > 100)
            {
                MessageBox.Show("Please enter a number between 1 and 100.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PlaySound("invalidSound");
                ShowGif("invalid");
                guessTextBox.Clear();
                guessTextBox.Focus();
                return;
            }

            attempts++;
            attemptsLabel.Text = $"Attempts: {attempts} / 7";

            if (guess < secretNumber)
            {
                feedbackLabel.Text = "Guess higher! 📈";
                feedbackLabel.ForeColor = Color.Orange;
                PlaySound("tooLowSound");
                ShowGif($"tooLow{attempts}");
                guessTextBox.Clear();
                guessTextBox.Focus();
            }
            else if (guess > secretNumber)
            {
                feedbackLabel.Text = "Guess lower! 📉";
                feedbackLabel.ForeColor = Color.LightCoral;
                PlaySound("tooHighSound");
                ShowGif($"tooHigh{attempts}");
                guessTextBox.Clear();
                guessTextBox.Focus();
            }
            else
            {
                // Correct guess!
                feedbackLabel.Text = $"🎉 Congratulations! You guessed it in {attempts} attempts!";
                feedbackLabel.ForeColor = Color.LightGreen;
                PlaySound("StarSound");
                ShowGif("start");

                scores.Add(new ScoreEntry(currentNickname, attempts));
                EndGame();
                return;
            }

            if (attempts >= 7)
            {
                feedbackLabel.Text = $"💔 Game Over! The number was {secretNumber}";
                feedbackLabel.ForeColor = Color.Red;
                PlaySound("gameOverSound");
                ShowGif("gameOver");

                scores.Add(new ScoreEntry("Computer", 7));
                EndGame();
                return;
            }
        }

        private void EndGame()
        {
            // Disable inputs
            guessTextBox.Enabled = false;
            btnSubmitGuess.Enabled = false;

            // Decrease remaining plays
            remainingPlays--;

            // Check if more games available
            if (remainingPlays > 0)
            {
                DialogResult result = MessageBox.Show(
                    $"You have {remainingPlays} more game(s) remaining.\n\nPlay again?",
                    "Play Again?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PlaySound("start");
                    ShowGif("start");
                    StartNewGame(); // Start new game
                }
                else
                {
                    ShowPanel(menuPanel);
                }
            }
            else
            {
                MessageBox.Show("All games completed! Returning to menu.",
                    "Session Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowPanel(menuPanel);
            }
        }

        private void btnMenuFromGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to return to menu?\nYour current game will be lost.",
                "Return to Menu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ShowPanel(menuPanel);
            }
        }

        // ===== SETTINGS =====
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (int.TryParse(timesToPlayTextBox.Text, out int newTimes))
            {
                if (newTimes >= 1 && newTimes <= maxPlayLimit)
                {
                    timesToPlay = newTimes;
                    MessageBox.Show($"Settings saved!\n\nTimes to play: {timesToPlay}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Please enter a value between 1 and {maxPlayLimit}.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMenuFromSettings_Click(object sender, EventArgs e)
        {
            ShowPanel(menuPanel);
        }

        // ===== SCORE STATISTICS =====
        private void DisplayScoreStatistics()
        {
            scoreListBox.Items.Clear();
            scoreListBox.Items.Add("══════════════════════════════════════════");
            scoreListBox.Items.Add("          🏆 HIGH SCORE BOARD 🏆         ");
            scoreListBox.Items.Add("══════════════════════════════════════════");
            scoreListBox.Items.Add("");

            if (scores.Count == 0)
            {
                scoreListBox.Items.Add("   No scores yet. Play some games first!");
                return;
            }

            // Sort by attempts (lower )
            var sortedScores = scores.OrderBy(s => s.Attempts).ToList();

            scoreListBox.Items.Add("  Rank | Player Name          | Attempts");
            scoreListBox.Items.Add("──────────────────────────────────────────");

            int displayCount = Math.Min(10, sortedScores.Count);
            for (int i = 0; i < displayCount; i++)
            {
                string rank = (i + 1).ToString().PadLeft(4);
                string name = sortedScores[i].Name.PadRight(20);
                string attempts = sortedScores[i].Attempts.ToString().PadLeft(4);
                string medal = i == 0 ? "🥇" : i == 1 ? "🥈" : i == 2 ? "🥉" : "  ";

                scoreListBox.Items.Add($"  {rank} | {name} | {attempts}   {medal}");
            }

            scoreListBox.Items.Add("");
            scoreListBox.Items.Add($"  Total games played: {scores.Count}");
        }

        private void btnMenuFromScore_Click(object sender, EventArgs e)
        {
            ShowPanel(menuPanel);
        }

        // ===== MULTIMEDIA METHODS =====
        private void PlaySound(string soundName)
        {
            try
            {
                string[] extensions = { ".wav" };
                string soundPath = "";

                foreach (string ext in extensions)
                {
                    soundPath = System.IO.Path.Combine(Application.StartupPath, soundName + ext);
                    if (System.IO.File.Exists(soundPath))
                    {
                        break;
                    }
                }

                if (System.IO.File.Exists(soundPath) && soundPath.EndsWith(".wav"))
                {
                    soundPlayer.Stop();
                    soundPlayer.SoundLocation = soundPath;
                    soundPlayer.LoadAsync();
                    soundPlayer.Play();
                }
            }
            catch (Exception)
            {

            }
        }


        private void ShowGif(string gifName)
        {
            try
            {
                var pictureBox = gamePanel.Controls.Find("gamePictureBox", true).FirstOrDefault() as PictureBox;

                if (pictureBox != null)
                {
                    string gifPath = System.IO.Path.Combine(Application.StartupPath, gifName + ".gif");

                    if (System.IO.File.Exists(gifPath))
                    {
                        if (pictureBox.Image != null)
                        {
                            pictureBox.Image.Dispose();
                        }
                        pictureBox.Image = Image.FromFile(gifPath);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        // ===== KEYBOARD SUPPORT =====
        private void NicknameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSubmitNickname_Click(sender, e);
            }
        }

        private void GuessTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSubmitGuess_Click(sender, e);
            }
        }
    }

    public class ScoreEntry
    {
        public string Name { get; set; }
        public int Attempts { get; set; }

        public ScoreEntry(string name, int attempts)
        {
            Name = name;
            Attempts = attempts;
        }
    }
}