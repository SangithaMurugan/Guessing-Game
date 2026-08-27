namespace GuessingGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScoreStatistics = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gamePictureBox = new System.Windows.Forms.PictureBox();
            this.btnMenuFromGame = new System.Windows.Forms.Button();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.btnSubmitGuess = new System.Windows.Forms.Button();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmitNickname = new System.Windows.Forms.Button();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMenuFromSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.timesToPlayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMenuFromScore = new System.Windows.Forms.Button();
            this.scoreListBox = new System.Windows.Forms.ListBox();
            this.menuPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.scorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuPanel.Controls.Add(this.label2);
            this.menuPanel.Controls.Add(this.btnExit);
            this.menuPanel.Controls.Add(this.btnScoreStatistics);
            this.menuPanel.Controls.Add(this.btnSettings);
            this.menuPanel.Controls.Add(this.btnStartGame);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(900, 650);
            this.menuPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(220, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 62);
            this.label2.TabIndex = 4;
            this.label2.Text = "🎮 Guessing Game";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(320, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 60);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "❌ Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScoreStatistics
            // 
            this.btnScoreStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(120)))), ((int)(((byte)(50)))));
            this.btnScoreStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScoreStatistics.FlatAppearance.BorderSize = 0;
            this.btnScoreStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScoreStatistics.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnScoreStatistics.ForeColor = System.Drawing.Color.White;
            this.btnScoreStatistics.Location = new System.Drawing.Point(320, 380);
            this.btnScoreStatistics.Name = "btnScoreStatistics";
            this.btnScoreStatistics.Size = new System.Drawing.Size(260, 60);
            this.btnScoreStatistics.TabIndex = 2;
            this.btnScoreStatistics.Text = "🏆 Score Statistics";
            this.btnScoreStatistics.UseVisualStyleBackColor = false;
            this.btnScoreStatistics.Click += new System.EventHandler(this.btnScoreStatistics_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(85)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(320, 290);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(260, 60);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "⚙️ Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(320, 200);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(260, 60);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "🎮 Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gamePanel.Controls.Add(this.gamePictureBox);
            this.gamePanel.Controls.Add(this.btnMenuFromGame);
            this.gamePanel.Controls.Add(this.attemptsLabel);
            this.gamePanel.Controls.Add(this.feedbackLabel);
            this.gamePanel.Controls.Add(this.btnSubmitGuess);
            this.gamePanel.Controls.Add(this.guessTextBox);
            this.gamePanel.Controls.Add(this.label4);
            this.gamePanel.Controls.Add(this.btnSubmitNickname);
            this.gamePanel.Controls.Add(this.nicknameTextBox);
            this.gamePanel.Controls.Add(this.label3);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(900, 650);
            this.gamePanel.TabIndex = 1;
            this.gamePanel.Visible = false;
            // 
            // gamePictureBox
            // 
            this.gamePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gamePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePictureBox.Location = new System.Drawing.Point(550, 150);
            this.gamePictureBox.Name = "gamePictureBox";
            this.gamePictureBox.Size = new System.Drawing.Size(400, 400);
            this.gamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gamePictureBox.TabIndex = 9;
            this.gamePictureBox.TabStop = false;
            // 
            // btnMenuFromGame
            // 
            this.btnMenuFromGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMenuFromGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuFromGame.FlatAppearance.BorderSize = 0;
            this.btnMenuFromGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFromGame.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMenuFromGame.ForeColor = System.Drawing.Color.White;
            this.btnMenuFromGame.Location = new System.Drawing.Point(50, 560);
            this.btnMenuFromGame.Name = "btnMenuFromGame";
            this.btnMenuFromGame.Size = new System.Drawing.Size(180, 50);
            this.btnMenuFromGame.TabIndex = 8;
            this.btnMenuFromGame.Text = "◀ Back to Menu";
            this.btnMenuFromGame.UseVisualStyleBackColor = false;
            this.btnMenuFromGame.Click += new System.EventHandler(this.btnMenuFromGame_Click);
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.attemptsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.attemptsLabel.Location = new System.Drawing.Point(50, 430);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(170, 30);
            this.attemptsLabel.TabIndex = 7;
            this.attemptsLabel.Text = "Attempts: 0 / 7";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.feedbackLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.feedbackLabel.Location = new System.Drawing.Point(50, 350);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(450, 60);
            this.feedbackLabel.TabIndex = 6;
            this.feedbackLabel.Text = "Enter your nickname to start";
            // 
            // btnSubmitGuess
            // 
            this.btnSubmitGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnSubmitGuess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitGuess.FlatAppearance.BorderSize = 0;
            this.btnSubmitGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitGuess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmitGuess.ForeColor = System.Drawing.Color.White;
            this.btnSubmitGuess.Location = new System.Drawing.Point(350, 250);
            this.btnSubmitGuess.Name = "btnSubmitGuess";
            this.btnSubmitGuess.Size = new System.Drawing.Size(150, 45);
            this.btnSubmitGuess.TabIndex = 5;
            this.btnSubmitGuess.Text = "Submit ✓";
            this.btnSubmitGuess.UseVisualStyleBackColor = false;
            this.btnSubmitGuess.Click += new System.EventHandler(this.btnSubmitGuess_Click);
            // 
            // guessTextBox
            // 
            this.guessTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.guessTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guessTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guessTextBox.ForeColor = System.Drawing.Color.White;
            this.guessTextBox.Location = new System.Drawing.Point(50, 250);
            this.guessTextBox.MaxLength = 3;
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(280, 39);
            this.guessTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter your guess (1-100):";
            // 
            // btnSubmitNickname
            // 
            this.btnSubmitNickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSubmitNickname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitNickname.FlatAppearance.BorderSize = 0;
            this.btnSubmitNickname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitNickname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmitNickname.ForeColor = System.Drawing.Color.White;
            this.btnSubmitNickname.Location = new System.Drawing.Point(350, 130);
            this.btnSubmitNickname.Name = "btnSubmitNickname";
            this.btnSubmitNickname.Size = new System.Drawing.Size(150, 45);
            this.btnSubmitNickname.TabIndex = 2;
            this.btnSubmitNickname.Text = "Start ▶";
            this.btnSubmitNickname.UseVisualStyleBackColor = false;
            this.btnSubmitNickname.Click += new System.EventHandler(this.btnSubmitNickname_Click);
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.nicknameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nicknameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.nicknameTextBox.ForeColor = System.Drawing.Color.White;
            this.nicknameTextBox.Location = new System.Drawing.Point(50, 130);
            this.nicknameTextBox.MaxLength = 20;
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(280, 39);
            this.nicknameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(50, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Your Nickname";
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Controls.Add(this.btnMenuFromSettings);
            this.settingsPanel.Controls.Add(this.btnSaveSettings);
            this.settingsPanel.Controls.Add(this.timesToPlayTextBox);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(900, 650);
            this.settingsPanel.TabIndex = 2;
            this.settingsPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(330, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "⚙️ Settings";
            // 
            // btnMenuFromSettings
            // 
            this.btnMenuFromSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMenuFromSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuFromSettings.FlatAppearance.BorderSize = 0;
            this.btnMenuFromSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFromSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuFromSettings.ForeColor = System.Drawing.Color.White;
            this.btnMenuFromSettings.Location = new System.Drawing.Point(320, 400);
            this.btnMenuFromSettings.Name = "btnMenuFromSettings";
            this.btnMenuFromSettings.Size = new System.Drawing.Size(260, 55);
            this.btnMenuFromSettings.TabIndex = 3;
            this.btnMenuFromSettings.Text = "◀ Back to Menu";
            this.btnMenuFromSettings.UseVisualStyleBackColor = false;
            this.btnMenuFromSettings.Click += new System.EventHandler(this.btnMenuFromSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
            this.btnSaveSettings.Location = new System.Drawing.Point(320, 320);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(260, 55);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "💾 Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // timesToPlayTextBox
            // 
            this.timesToPlayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.timesToPlayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timesToPlayTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.timesToPlayTextBox.ForeColor = System.Drawing.Color.White;
            this.timesToPlayTextBox.Location = new System.Drawing.Point(320, 250);
            this.timesToPlayTextBox.MaxLength = 2;
            this.timesToPlayTextBox.Name = "timesToPlayTextBox";
            this.timesToPlayTextBox.Size = new System.Drawing.Size(260, 39);
            this.timesToPlayTextBox.TabIndex = 1;
            this.timesToPlayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Times to Play (1-25):";
            // 
            // scorePanel
            // 
            this.scorePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.scorePanel.Controls.Add(this.label6);
            this.scorePanel.Controls.Add(this.btnMenuFromScore);
            this.scorePanel.Controls.Add(this.scoreListBox);
            this.scorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scorePanel.Location = new System.Drawing.Point(0, 0);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(900, 650);
            this.scorePanel.TabIndex = 3;
            this.scorePanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(240, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(427, 50);
            this.label6.TabIndex = 2;
            this.label6.Text = "🏆 High Score Board";
            // 
            // btnMenuFromScore
            // 
            this.btnMenuFromScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMenuFromScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuFromScore.FlatAppearance.BorderSize = 0;
            this.btnMenuFromScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFromScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuFromScore.ForeColor = System.Drawing.Color.White;
            this.btnMenuFromScore.Location = new System.Drawing.Point(320, 560);
            this.btnMenuFromScore.Name = "btnMenuFromScore";
            this.btnMenuFromScore.Size = new System.Drawing.Size(260, 55);
            this.btnMenuFromScore.TabIndex = 1;
            this.btnMenuFromScore.Text = "◀ Back to Menu";
            this.btnMenuFromScore.UseVisualStyleBackColor = false;
            this.btnMenuFromScore.Click += new System.EventHandler(this.btnMenuFromScore_Click);
            // 
            // scoreListBox
            // 
            this.scoreListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.scoreListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreListBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.scoreListBox.ForeColor = System.Drawing.Color.White;
            this.scoreListBox.FormattingEnabled = true;
            this.scoreListBox.ItemHeight = 23;
            this.scoreListBox.Location = new System.Drawing.Point(180, 130);
            this.scoreListBox.Name = "scoreListBox";
            this.scoreListBox.Size = new System.Drawing.Size(540, 394);
            this.scoreListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Guessing Game";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnScoreStatistics;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.Button btnSubmitNickname;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button btnSubmitGuess;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.Button btnMenuFromGame;
        private System.Windows.Forms.PictureBox gamePictureBox;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timesToPlayTextBox;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnMenuFromSettings;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.ListBox scoreListBox;
        private System.Windows.Forms.Button btnMenuFromScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}