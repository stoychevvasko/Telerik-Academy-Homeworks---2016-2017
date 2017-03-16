//// <copyright file="Constants.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Common.Constants
{
    using System;
    using MinefieldConstants = Minesweeper.Common.Constants.Constants.Game.Minefield;

    /// <summary>Minesweeper constants and default values.</summary>
    public static class Constants
    {
        /// <summary>Minesweeper player constants and default values.</summary>
        public static class Player
        {
            /// <summary>Minesweeper default player name constant.</summary>
            public const string DefaultName = "Default_Name";

            /// <summary>Minesweeper default player points constant.</summary>
            public const int DefaultPoints = -1;
        }

        /// <summary>Minesweeper game constants and default values.</summary>       
        public static class Game
        {
            /// <summary>Minesweeper game message constants and default values.</summary>
            public static class Notifications
            {
                /// <summary>Prompts player turn.</summary>
                public const string PromptNextPlayerTurn = "[row:0-4]>[space]>[col:0-9]>[enter]: ";

                /// <summary>Title line in Minesweeper game.</summary>
                public const string TitleLine = "Play Minesweeper - step on all the mine-free cells >:(\n\nKeyboard commands:\n\n              [t][o][p] > highscores\n  [r][e][s][t][a][r][t] > new game\n           [e][x][i][t] > quit game\n";

                /// <summary>Invalid command notification in Minesweeper game.</summary>
                public const string InvalidCommand = "\nError! Invalid command!\n";

                /// <summary>High scores line in Minesweeper game.</summary>
                public const string TopPlayers = "\nBest Scores: ";

                /// <summary>Congratulatory message celebrating your amazing success.</summary>
                public const string PointsVictory = "\n Victory! You found 35 mine-free cells!\n\n";

                /// <summary>Sourcing details.</summary>
                public const string ProductOf = "  \nmade by ninja-wannabe";

                /// <summary>Prompts player to type their name.</summary>
                public const string PromptPlayerNameSubmission = "Enter your name: ";

                /// <summary>Bids player goodbye.</summary>
                public const string FarewellMessage = "<Chatbot>: gg wp m8\n";

                /// <summary>Player left game.</summary>
                public const string PlayerQuit = " (player left)\n";

                /// <summary>No high score available to display.</summary>
                public const string HighscoreEmpty = " (none)";

                /// <summary>Game over line with final score in Minesweeper game.</summary><param name="result">Final number of points collected.</param><returns>Game over line for console.</returns>
                public static string GameOverLine(int result)
                {
                    return string.Format($"\n*kaBooM!* You died with {result} points.\n\nPlayer name?: ");
                }
            }

            /// <summary>Minesweeper game command constants and default values.</summary>
            public static class Command
            {
                /// <summary>Initial command value at game-start.</summary>
                public static readonly string DefaultCommand = string.Empty;
            }

            /// <summary>Minesweeper game minefield constants and default values.</summary>
            public static class Minefield
            {
                /// <summary>Standard minefield number of rows value.</summary>
                public const int DefaultNumberOfRows = 5;

                /// <summary>Standard minefield number of columns value.</summary>
                public const int DefaultNumberOfColumns = 10;

                /// <summary>Standard character for cells not yet revealed on the game board./// </summary>
                public const char DefaultHiddenCellDisplayCharacter = '?';

                /// <summary>Standard character for mines already revealed on the game board.</summary>
                public const char DefaultMineDisplayCharacter = '*';

                /// <summary>Column labels on first line.</summary>
                public const string TopRowLabels = "\n    0 1 2 3 4 5 6 7 8 9";

                /// <summary>A horizontal visual delimiter.</summary>
                public const string LineBreak = "   ---------------------\n";

                /// <summary>Standard blank game board in the Minesweeper game.</summary><returns>A blank game board filled with default unrevealed cell character.</returns>
                public static char[,] GetNewBlankGameBoard()
                {
                    var boardBuilder = new char[DefaultNumberOfRows, DefaultNumberOfColumns];
                    for (int row = 0; row < DefaultNumberOfRows; row++)
                    {
                        for (int column = 0; column < DefaultNumberOfColumns; column++)
                        {
                            boardBuilder[row, column] = '?';
                        }
                    }

                    return boardBuilder;
                }
            }

            /// <summary>Minesweeper game victory conditions constants and default values.</summary>
            public static class VictoryConditions
            {
                /// <summary>Gets number of player points required to meet standard victory condition.</summary>
                public static int NumberOfPoints
                {
                    get { return 35; }
                }
            }
        }
    }
}
