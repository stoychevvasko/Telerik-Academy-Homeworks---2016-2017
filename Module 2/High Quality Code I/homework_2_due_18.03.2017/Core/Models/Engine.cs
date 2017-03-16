//// <copyright file="Engine.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Models
{
    using System;
    using System.Collections.Generic;
    using Common.Constants;
    using Contracts.Interfaces;
    using Providers;
    using MinefieldConstants = Common.Constants.Constants.Game.Minefield;

    /// <summary>Main engine in the Minesweeper game.</summary>
    public class Engine : IEngine
    {
        /// <summary>Holds engine singleton instance.</summary>
        private static IEngine instanceHolder = new Engine();

        /// <summary>Prevents a default instance of the <see cref="Engine"/> class from being created.</summary>
        private Engine()
        {
            this.Command = Constants.Game.Command.DefaultCommand;
            this.Minefield = GameFactory.Instance.CreateNewMinefield();
            this.Reader = new ConsoleReader();
            this.Writer = new ConsoleWriter();
        }

        /// <summary>Gets the engine singleton instance.</summary>
        public static IEngine Instance
        {
            get { return Engine.instanceHolder; }
        }

        /// <summary>Gets or sets active engine command.</summary>
        public string Command { get; set; }

        /// <summary>Gets or sets the game board minefield.</summary>
        public IMinefield Minefield { get; set; }

        /// <summary>Gets or sets the engine reader.</summary>
        public IReader Reader { get; set; }

        /// <summary>Gets or sets the engine writer.</summary>
        public IWriter Writer { get; set; }

        /// <summary>Sets the engine in motion.</summary>        
        public void Start()
        {
            //// TO-DO: complete the cycle

            Engine.Instance.Minefield.Cells = MinefieldConstants.GetNewBlankGameBoard();
            char[,] mines = getNewRandomGameBoard();
            int counter = 0;
            bool isGameplayActive = false;
            List<Score> topPlayers = new List<Score>(6);
            int row = 0;
            int column = 0;
            bool activeSession = true;
            bool pointVictoryConditionMet = false;

            do
            {
                if (activeSession)
                {
                    Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.TitleLine);
                    RedrawBoard(Engine.Instance.Minefield.Cells);
                    activeSession = false;
                }

                Engine.Instance.Writer.Write(Constants.Game.Notifications.PromptNextPlayerTurn);
                Engine.Instance.Command = Engine.Instance.Reader.ReadLine().Trim();
                if (Engine.Instance.Command.Length >= 3)
                {
                    if (int.TryParse(Engine.Instance.Command[0].ToString(), out row) &&
                        int.TryParse(Engine.Instance.Command[2].ToString(), out column) &&
                        row <= Engine.Instance.Minefield.Cells.GetLength(0) &&
                        column <= Engine.Instance.Minefield.Cells.GetLength(1))
                    {
                        Engine.Instance.Command = "turn";
                    }
                }

                switch (Engine.Instance.Command)
                {
                    case "top":
                        RankTopPlayers(topPlayers);
                        break;
                    case "restart":
                        Engine.Instance.Minefield.Cells = Constants.Game.Minefield.GetNewBlankGameBoard();
                        mines = getNewRandomGameBoard();
                        RedrawBoard(Engine.Instance.Minefield.Cells);
                        isGameplayActive = false;
                        activeSession = false;
                        break;
                    case "exit":
                        Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.PlayerQuit);
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                tisinahod(Engine.Instance.Minefield.Cells, mines, row, column);
                                counter++;
                            }

                            if (counter == Constants.Game.VictoryConditions.NumberOfPoints)
                            {
                                pointVictoryConditionMet = true;
                            }
                            else
                            {
                                RedrawBoard(Engine.Instance.Minefield.Cells);
                            }
                        }
                        else
                        {
                            isGameplayActive = true;
                        }

                        break;
                    default:
                        Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.InvalidCommand);
                        break;
                }

                if (isGameplayActive)
                {
                    RedrawBoard(mines);
                    Engine.Instance.Writer.Write(Constants.Game.Notifications.GameOverLine(counter));
                    string playerNickname = Console.ReadLine();
                    Score t = new Score(playerNickname, counter);
                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].Points < t.Points)
                            {
                                topPlayers.Insert(i, t);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    topPlayers.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    RankTopPlayers(topPlayers);

                    Engine.Instance.Minefield.Cells = Constants.Game.Minefield.GetNewBlankGameBoard();
                    mines = getNewRandomGameBoard();
                    counter = 0;
                    isGameplayActive = false;
                    activeSession = true;
                }

                if (pointVictoryConditionMet)
                {
                    Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.PointsVictory);
                    RedrawBoard(mines);
                    Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.PromptPlayerNameSubmission);
                    string playerName = Engine.Instance.Reader.ReadLine();
                    Score playerScore = new Score(playerName, counter);
                    topPlayers.Add(playerScore);
                    RankTopPlayers(topPlayers);
                    Engine.Instance.Minefield.Cells = Constants.Game.Minefield.GetNewBlankGameBoard();
                    mines = getNewRandomGameBoard();
                    counter = 0;
                    pointVictoryConditionMet = false;
                    activeSession = true;
                }
            }
            while (Engine.Instance.Command != "exit");

            Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.FarewellMessage);
            Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.ProductOf);
            //// Engine.Instance.Reader.ReadKey();
        }

        /// <summary>Ranks the top players by score achieved.</summary><param name="individualPlayerScores">A collection of player scores.</param>
        private static void RankTopPlayers(List<Score> individualPlayerScores)
        {
            Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.TopPlayers);
            if (individualPlayerScores.Count > 0)
            {
                for (int index = 0; index < individualPlayerScores.Count; index++)
                {
                    Engine.Instance.Writer.WriteLine(string.Format($"{index + 1}. {individualPlayerScores[index].Name} --> {individualPlayerScores[index].Points} points"));
                }

                Engine.Instance.Writer.WriteLine();
            }
            else
            {
                Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.HighscoreEmpty);
            }
        }

        private static void tisinahod(char[,] gameBoard, char[,] mines, int row, int column)
        {
            char kolkoBombi = CountAdjacentMines(mines, row, column);
            mines[row, column] = kolkoBombi;
            gameBoard[row, column] = kolkoBombi;
        }

        private static void RedrawBoard(char[,] board)
        {
            Console.WriteLine(MinefieldConstants.TopRowLabels);
            Console.WriteLine(MinefieldConstants.LineBreak);
            for (int i = 0; i < MinefieldConstants.DefaultNumberOfRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < MinefieldConstants.DefaultNumberOfColumns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine(MinefieldConstants.LineBreak);
        }



        private static char[,] getNewRandomGameBoard()
        {
            char[,] gameBoard = MinefieldConstants.GetNewBlankGameBoard();
            for (int row = 0; row < MinefieldConstants.DefaultNumberOfRows; row++)
            {
                for (int column = 0; column < MinefieldConstants.DefaultNumberOfColumns; column++)
                {
                    gameBoard[row, column] = '-';
                }
            }

            List<int> uniqueRandomNumbers = new List<int>();
            while (uniqueRandomNumbers.Count < 15)
            {
                Random random = new Random();
                int nextRandomNumber = random.Next(50);
                if (!uniqueRandomNumbers.Contains(nextRandomNumber))
                {
                    uniqueRandomNumbers.Add(nextRandomNumber);
                }
            }

            foreach (int number in uniqueRandomNumbers)
            {
                int columnPlacement = (number / MinefieldConstants.DefaultNumberOfColumns);
                int rowPlacement = (number % MinefieldConstants.DefaultNumberOfColumns);
                if (rowPlacement == 0 && number != 0)
                {
                    columnPlacement--;
                    rowPlacement = MinefieldConstants.DefaultNumberOfColumns;
                }
                else
                {
                    rowPlacement++;
                }

                gameBoard[columnPlacement, rowPlacement - 1] = '*';
            }

            return gameBoard;
        }

        private static void revealCellDigit(char[,] cells)
        {
            for (int i = 0; i < MinefieldConstants.DefaultNumberOfRows; i++)
            {
                for (int j = 0; j < MinefieldConstants.DefaultNumberOfColumns; j++)
                {
                    if (cells[i, j] != '*')
                    {
                        char adjacentMineCount = CountAdjacentMines(cells, i, j);
                        cells[i, j] = adjacentMineCount;
                    }
                }
            }
        }

        private static char CountAdjacentMines(char[,] gameBoard, int row, int column)
        {
            int count = 0;
            if (row - 1 >= 0)
            {
                if (gameBoard[row - 1, column] == MinefieldConstants.DefaultMineDisplayCharacter)
                {
                    count++;
                }
            }

            if (row + 1 < MinefieldConstants.DefaultNumberOfRows)
            {
                if (gameBoard[row + 1, column] == MinefieldConstants.DefaultMineDisplayCharacter)
                {
                    count++;
                }
            }

            if (column - 1 >= 0)
            {
                if (gameBoard[row, column - 1] == MinefieldConstants.DefaultMineDisplayCharacter)
                {
                    count++;
                }
            }

            if (column + 1 < MinefieldConstants.DefaultNumberOfColumns)
            {
                if (gameBoard[row, column + 1] == MinefieldConstants.DefaultMineDisplayCharacter)
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (gameBoard[row - 1, column - 1] == MinefieldConstants.DefaultMineDisplayCharacter)
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < MinefieldConstants.DefaultNumberOfColumns))
            {
                if (gameBoard[row - 1, column + 1] == MinefieldConstants.DefaultMineDisplayCharacter)
                {
                    count++;
                }
            }

            if ((row + 1 < MinefieldConstants.DefaultNumberOfRows) && (column - 1 >= 0))
            {
                if (gameBoard[row + 1, column - 1] == MinefieldConstants.DefaultMineDisplayCharacter)
                {
                    count++;
                }
            }

            if ((row + 1 < MinefieldConstants.DefaultNumberOfRows) && (column + 1 < MinefieldConstants.DefaultNumberOfColumns))
            {
                if (gameBoard[row + 1, column + 1] == MinefieldConstants.DefaultMineDisplayCharacter)
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
