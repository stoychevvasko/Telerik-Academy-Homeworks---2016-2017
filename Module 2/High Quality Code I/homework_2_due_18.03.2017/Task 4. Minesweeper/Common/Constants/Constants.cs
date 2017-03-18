//// <copyright file="Constants.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Minesweeper.Common.Constants
{
    using System;
    using System.Collections.Generic;
    using Core.Providers;

    /// <summary>Minesweeper constants and default values.</summary>
    internal static class Constants
    {
        /// <summary>Minesweeper player constants and default values.</summary>
        public static class Player
        {
            /// <summary>Minesweeper default player name constant.</summary>
            public const string DefaultName = " unknown player";

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
                public const string PromptNextPlayerTurn = " next turn: ";

                /// <summary>Title line in Minesweeper game.</summary>
                public const string TitleLine = "minesweeper - don't blow up";

                /// <summary>Keyboard instructions.</summary>
                public const string Instructions = " \n keyboard commands:\n\n              [t][o][p] > highscores\n  [r][e][s][t][a][r][t] > new game\n           [e][x][i][t] > quit game\n";

                /// <summary>Invalid command notification in Minesweeper game.</summary>
                public const string InvalidCommand = " error! invalid command!\n";

                /// <summary>High scores line in Minesweeper game.</summary>
                public const string TopPlayers = " \n best scores:\n";

                /// <summary>Congratulatory message celebrating your amazing success.</summary>
                public const string PointsVictory = " victory! you found 35 mine-free cells!\n";

                /// <summary>Sourcing details.</summary>
                public const string ProductOf = "  made by: ninja in training\n";

                /// <summary>Prompts player to type their name.</summary>
                public const string PromptPlayerNameSubmission = " enter your name: ";

                /// <summary>Player left game.</summary>
                public const string PlayerQuit = "\n (player left)";

                /// <summary>No high score available to display.</summary>
                public const string HighscoreEmpty = " (no records)\n";

                /// <summary>Prompts player to press any key.</summary>
                public const string PressAnyKey = "\n press any key...";

                /// <summary>Gets goodbye string to reply with when player quits game.</summary>
                public static string FarewellMessage
                {
                    get { return BidGoodbye(); }
                }

                /// <summary>Game over line with final score in Minesweeper game.</summary><param name="result">Final number of points collected.</param><returns>Game over line for console.</returns>
                public static string GetGameOverLine(int result)
                {
                    return string.Format($" you died with balance of {result} points\n  player name?: ");
                }

                /// <summary>Goodbye wish.</summary><returns>Sample goodbye utterance.</returns>
                private static string BidGoodbye()
                {
                    var now = DateTimeProvider.Now;
                    return string.Format($"  @{now.Day.ToString("00")}/{now.Month.ToString("00")}/{now.Year.ToString("0000")} {now.Hour.ToString("00")}:{now.Minute.ToString("00")}:{now.Second.ToString("00")}\n\n  <Chatbot>: gg wp m8\n\n");
                }
            }

            /// <summary>Minesweeper game command constants and default values.</summary>
            public static class Command
            {
                /// <summary>Initial command value at game-start.</summary>
                public const string DefaultCommand = "";
            }

            /// <summary>Minesweeper game minefield constants and default values.</summary>
            public static class Minefield
            {
                /// <summary>Standard minefield number of rows value.</summary>
                public const int DefaultRows = 5;

                /// <summary>Standard minefield number of columns value.</summary>
                public const int DefaultColumns = 10;

                /// <summary>Standard character for cells not yet revealed on the game board./// </summary>
                public const char UnmarkedSquare = '?';

                /// <summary>Standard character for mines already revealed on the game board.</summary>
                public const char LoadedMineCell = '*';

                /// <summary>Standard character for mine-free clear cells.</summary>
                public const char EmptyMineCell = '-';

                /// <summary>Top-row column numbers.</summary>
                public const string TopRulers = "\n      0 1 2 3 4 5 6 7 8 9";

                /// <summary>A horizontal visual delimiter.</summary>
                public const string LineBreak = "      ---------------------";

                /// <summary>A vertical delimiter.</summary>
                public const string SideEdge = "|";

                /// <summary>Standard blank game board in the Minesweeper game.</summary><returns>A blank game board filled with default unrevealed cell character.</returns>
                public static char[,] GetNewEmptyMinesMatrix()
                {
                    var boardBuilder = new char[DefaultRows, DefaultColumns];
                    for (int row = 0; row < DefaultRows; row++)
                    {
                        for (int column = 0; column < DefaultColumns; column++)
                        {
                            boardBuilder[row, column] = '?';
                        }
                    }

                    return boardBuilder;
                }

                /// <summary>Creates a new matrix with mines (pseudo)-randomly placed.</summary><returns>Randomized matrix of cells</returns>
                public static char[,] GetRandomizedCells()
                {
                    char[,] cells = GetNewEmptyMinesMatrix();
                    for (int row = 0; row < DefaultRows; row++)
                    {
                        for (int column = 0; column < DefaultColumns; column++)
                        {
                            cells[row, column] = EmptyMineCell;
                        }
                    }

                    List<int> randoms = new List<int>();
                    while (randoms.Count < 15)
                    {
                        Random random = new Random();
                        int nextRandomNumber = random.Next(50);
                        if (!randoms.Contains(nextRandomNumber))
                        {
                            randoms.Add(nextRandomNumber);
                        }
                    }

                    foreach (int number in randoms)
                    {
                        int row = number / DefaultColumns;
                        int column = number % DefaultColumns;
                        if (column == 0 && number != 0)
                        {
                            row--;
                            column = DefaultColumns;
                        }
                        else
                        {
                            column++;
                        }

                        cells[row, column - 1] = LoadedMineCell;
                    }

                    return cells;
                }
            }

            /// <summary>Minesweeper game victory conditions constants and default values.</summary>
            public static class VictoryConditions
            {
                /// <summary>Gets number of player points required to meet standard victory condition.</summary>
                public const int NumberOfPoints = 35;
            }
        }
    }
}
