# Number Guessing Game

## Introduction

The Number Guessing Game is a C# Windows Forms application in which the user has to predict a number that is chosen at random between 1 and 100. The game provides comments for each attempt and keeps track of the total amount of guesses. The user wins when they correctly predict the number within seven attempts. If not, the computer wins.

## Features

- Random number generation between 1 and 100
- Player nickname input
- Hints indicating whether the guess is too high or too low
- Maximum of seven attempts
- Menu-driven navigation
- Customizable number of game plays from 1-100
- High-score scoreboard displaying the top three players
- Sound effects for correct, incorrect, and game-start actions
- GIF animations
- Input validation and error handling
- Dark-themed graphical user interface (GUI)
- Single-player mode

## Requirements

- C# programming language
- C# Windows Forms
- Graphical User Interface (GUI)
- Random number generation
- Input validation
- Menu-driven navigation

## How to Play

1. Start the Number Guessing Game.
2. Enter your nickname.
3. The computer randomly selects a number between 1 and 100.
4. Enter your guess.
5. Follow the hints to determine whether your guess is too high or too low.
6. Guess the correct number within seven attempts to win.
7. If the number is not guessed within seven attempts, the computer wins.
8. Check the scoreboard to view the top three high scores.

## Menu Options

- **Start Game** – Start the guessing game.
- **Settings** – Change the number of times the game will be played.
- **High Scores** – View the top three high scores.
- **Exit** – Exit the gaming system.

## Settings

The player can change the number of times they want to play the game. The number of repetitions must be within the acceptable range of 1-100.

## Game Rules

- The random number is between **1 and 100**.
- The player has a maximum of **seven attempts**.
- The game provides feedback when the guess is too high or too low.
- The player wins by correctly guessing the number within seven attempts.
- If the player fails to guess the number within seven attempts, the computer wins.
- Scores are recorded and displayed on the high-score scoreboard.

## System Design

The program is organized into several panels:

- **Menu**
- **Game**
- **Settings**
- **Scoreboard**

All functionality is managed within the main form **Form1**, which handles the game logic, user interface, sound, scoring elements, and GIF animations.

## Testing

The application was tested through:

- **Basic Assessment** – Every method in the Form1 class was tested manually.
- **Integration Testing** – The menu, settings, scoreboard, and gameplay were tested together.
- **User Evaluation** – Several players tested the controls, navigation, and input handling.

### Testing Results

- The software effectively navigates the menu and conducts the specified tasks.
- User input is checked correctly.
- Invalid entries display appropriate error messages.
- The game accurately records guesses and attempts.
- Scores are saved and displayed correctly.
- Settings are customizable and accurately implemented.
- The player can return to the menu whenever they want.
- The player can exit the game.

## Problems and Solutions

### Incorrect Input Handling

Users sometimes input non-numerical or out-of-range integers.

**Solution:** Extensive input validation was implemented to handle non-numeric and out-of-range values.

### Unfilled Nickname

Users occasionally submitted a blank nickname, which caused score collecting difficulties.

**Solution:** Nickname validation was added to ensure that the nickname is not empty.

## Accomplishments

- The game includes sound effects, GIF animations, nickname input, and a high-score list.
- The game has a sophisticated dark look and a welcoming User Interface (UI).
- The program runs efficiently, checks user input, and provides clear feedback.
- The program successfully accomplishes the objective of an immersive guessing game.

## Future Developments

- Add advanced options such as customizable number ranges and complexity levels.
- Create a multiplayer mode in which numerous people battle against one another.

## Conclusion

The Number Guessing Game application successfully meets all of the requirements. It has an easy-to-use UI (User Interface), reliable error management, and precise score tracking.

The Graphical User Interface (GUI) provides a more enjoyable user experience. The application is efficient and simple to maintain, with comprehensive documentation and well-organized code.

## Appendix

1.Appendix A: Code Structure and Program

Code Structure:

The code is organized into distinct sections that handle various aspects of the game, including setup, interaction options, the scoreboard, and the multimedia layout. Every feature serves a unique purpose, keeping the software simple to manage and understand.

1.Class: Form 1
2.Attributes:
A.Game Configuration
- timesToPlay: Determines the number of times the player can play (default: 5).
- maxPlayLimit: the highest number of rounds permitted (default: 25).
- remainingPlays: Indicates the number of rounds that are left.
- scores: Keep track of individual results and attempts.

B.Game Variables
- Evaluate user input and handle failures graciously.
- secretNumber: A computer-generated random number.
- attempts: Determines how many guesses the player has made.
- currentNickname: keeps the player's nickname.
- random: provides random numbers.
- soundPlayer: Performs sound effects throughout the game.
3.Methods:
A.Game Setup and Flow
- Form1(): A constructor that creates the form and begins the game.
- InitializeGame() creates the User Interface (UI) and starts the initial game.
- StartNewGame() begins a fresh game session.
- EndGame(): Controls game completion and restart options.
B.User Interface (UI) Styling
- StylePanel(): Determines the background color of panels.
- StyleButton(): Customizes buttons with colors and text.
- StyleLabel(): Prepares labels to appear.
- StyleTextBox() styles text boxes for input from users.
C.Panel Control
- ShowPanel(): Reveals a single panel while obscuring others.
D.Button Event Handlers (User Interaction)
- btnStartGame_Click() starts the game.
- btnSettings_Click() displays the settings menu.
- btnScoreStatistics_Click(): Displays the high-scores list.
- btnExit_Click() closes the program.
- btnSubmitNickname_Click(): Validates the name and starts guessing.
- btnSubmitGuess_Click(): Verifies the player's guess.
- btnMenuFromGame_Click() restores to the main menu.
- btnSaveSettings_Click(): Saves the player settings.
- btnMenuFromSettings_Click(): Returns to the menu.
- btnMenuFromScore_Click(): Returns to the menu on the score page.
E.Scoreboard (Nested Class)
DisplayScoreStatistics() sorts and presents the scoreboard in sequence.
F.Multimedia 
- PlaySound(string soundName) plays a sound effect (.wav files). 
- ShowGif(string gifName): Shows GIF animations triggered by game events. 
G.Keyboard Support 
- NicknameTextBox_KeyPress(): Accepts only letters and the Enter key for submission.
- GuessTextBox_KeyPress(): Accepts just numbers and the Enter key for submission. 
H.Score Entry (Nested Class) 
- It saves each player's name and number of attempts. 
- Used to create and display the scoreboard.
Programming Structures Used (Variables, Loops, Conditionals, Functions)
- Variables are employed to store secret numbers, nicknames, attempts, and score lists. 
- Loops are implemented on the scoreboard to show player scores. 
- Conditionals are employed to determine if a guess is accurate, too high, or low.
- Functions or methods are implemented for launching a new game, playing sounds, displaying GIFs, and modifying the  User Interface (UI).
Code Descriptions
- The code begins by introducing game settings and panels. 
- As a player types a nickname, an unknown number is chosen. 
- Every assumption is validated by if-else declarations.
- Sounds and Graphics Interchange Format (GIFs) are played depending on the guess choice.
- Scores are kept and shown in a sorted scoreboard.
