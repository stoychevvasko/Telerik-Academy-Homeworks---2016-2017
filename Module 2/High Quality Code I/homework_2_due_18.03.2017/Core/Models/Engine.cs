//// <copyright file="Engine.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Models
{
    using System;
    using System.Collections.Generic;
    using Common.Constants;
    using Common.Enumerations;
    using Contracts.Interfaces;
    using Providers;
    using MinefieldConstants = Common.Constants.Constants.Game.Minefield;

    /// <summary>Main engine in the Minesweeper game.</summary>
    public class Engine : IEngine
    {
        /// <summary>Holds engine singleton instance.</summary>
        private static IEngine instanceHolder = new Engine();

        /// <summary>Holds last user command literal.</summary>
        private static string lastCommand = Constants.Game.Command.DefaultCommand;

        /// <summary>Prevents a default instance of the <see cref="Engine"/> class from being created.</summary>
        private Engine()
        {
            Engine.lastCommand = Constants.Game.Command.DefaultCommand;
            this.Command = CommandParser.Parse(Engine.lastCommand);
            this.MineCounter = GameFactory.Instance.CreateNewMineCounter();
            this.Minefield = GameFactory.Instance.CreateNewMinefield();            
            this.Reader = GameFactory.Instance.CreateNewConsoleReader();
            this.Writer = GameFactory.Instance.CreateNewConsoleWriter();            
        }

        /// <summary>Gets the engine singleton instance.</summary>
        public static IEngine Instance
        {
            get { return Engine.instanceHolder; }
        }

        /// <summary>Gets or sets active engine command.</summary>
        public CommandTypes Command
        {
            get { return CommandParser.Parse(Engine.lastCommand); }
            set { Engine.lastCommand = value.ToString(); }
        }

        /// <summary>Gets or sets the game board minefield.</summary>
        public IMinefield Minefield { get; set; }

        /// <summary>Gets or sets the engine reader.</summary>
        public IReader Reader { get; set; }

        /// <summary>Gets or sets the engine writer.</summary>
        public IWriter Writer { get; set; }

        /// <summary>Gets or sets mine counter.</summary>
        public ICounter MineCounter { get; set; }

        /// <summary>Sets the engine in motion.</summary>        
        public void Start()
        {
            //// TO-DO: complete the cycle

            Engine.Instance.Minefield.Marks = MinefieldConstants.GetNewEmptyMinesMatrix();
            Engine.Instance.Minefield.Mines = MinefieldConstants.GetRandomizedCells();
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
                    ReDrawMarks(Engine.Instance.Minefield.Marks);
                    activeSession = false;
                }

                Engine.Instance.Writer.Write(Constants.Game.Notifications.PromptNextPlayerTurn);
                Engine.lastCommand = Engine.Instance.Reader.ReadLine().Trim();
                if (Engine.lastCommand.Length >= 3)
                {
                    if (int.TryParse(Engine.lastCommand[0].ToString(), out row) &&
                        int.TryParse(Engine.lastCommand[2].ToString(), out column) &&
                        row <= MinefieldConstants.DefaultRows &&
                        column <= MinefieldConstants.DefaultColumns)
                    {
                        Engine.Instance.Command = CommandTypes.Turn;
                    }
                }

                switch (Engine.Instance.Command)
                {
                    case CommandTypes.Top:
                        Engine.Instance.Writer.ClearConsole();
                        RankTopPlayers(topPlayers);
                        break;
                    case CommandTypes.Restart:
                        Engine.Instance.Writer.ClearConsole();
                        Engine.Instance.Minefield.Marks = MinefieldConstants.GetNewEmptyMinesMatrix();
                        Engine.Instance.Minefield.Mines = MinefieldConstants.GetRandomizedCells();
                        ReDrawMarks(Engine.Instance.Minefield.Marks);
                        isGameplayActive = false;
                        activeSession = false;
                        break;
                    case CommandTypes.Exit:
                        Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.PlayerQuit);
                        Engine.Instance.Reader.ReadKey();
                        break;
                    case CommandTypes.Turn:
                        if (Engine.Instance.Minefield.Mines[row, column] != MinefieldConstants.LoadedMineCell)
                        {
                            if (Engine.Instance.Minefield.Mines[row, column] == MinefieldConstants.EmptyMineCell)
                            {
                                UpdateSquareMark(Engine.Instance.Minefield.Marks, Engine.Instance.Minefield.Mines, row, column);
                                counter++;
                            }

                            if (counter == Constants.Game.VictoryConditions.NumberOfPoints)
                            {
                                pointVictoryConditionMet = true;
                            }
                            else
                            {
                                Engine.Instance.Writer.ClearConsole();
                                ReDrawMarks(Engine.Instance.Minefield.Marks);
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
                    Engine.Instance.Writer.ClearConsole();
                    ReDrawMarks(Engine.Instance.Minefield.Mines);
                    Engine.Instance.Writer.Write(Constants.Game.Notifications.GetGameOverLine(counter));
                    string playerNickname = Engine.Instance.Reader.ReadLine();
                    Score newScoreEntry = new Score(playerNickname, counter);
                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(newScoreEntry);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].Points < newScoreEntry.Points)
                            {
                                topPlayers.Insert(i, newScoreEntry);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    topPlayers.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    RankTopPlayers(topPlayers);

                    Engine.Instance.Minefield.Marks = MinefieldConstants.GetNewEmptyMinesMatrix();
                    Engine.Instance.Minefield.Mines = MinefieldConstants.GetRandomizedCells();
                    counter = 0;
                    isGameplayActive = false;
                    activeSession = true;
                }

                if (pointVictoryConditionMet)
                {
                    Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.PointsVictory);
                    ReDrawMarks(Engine.Instance.Minefield.Mines);
                    Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.PromptPlayerNameSubmission);
                    string playerName = Engine.Instance.Reader.ReadLine();
                    Score playerScore = new Score(playerName, counter);
                    topPlayers.Add(playerScore);
                    RankTopPlayers(topPlayers);
                    Engine.Instance.Minefield.Marks = Constants.Game.Minefield.GetNewEmptyMinesMatrix();
                    Engine.Instance.Minefield.Mines = MinefieldConstants.GetRandomizedCells();
                    counter = 0;
                    pointVictoryConditionMet = false;
                    activeSession = true;
                }
            }
            while (Engine.Instance.Command != CommandTypes.Exit);

            Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.FarewellMessage);
            Engine.Instance.Writer.WriteLine(Constants.Game.Notifications.ProductOf);
            Engine.Instance.Reader.ReadKey();
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

            Engine.Instance.Reader.ReadKey();
        }

        /// <summary>Mark cell with result from counting mines in adjacent cell contents.</summary><param name="marks">Matrix of all cells containing outer display values - {?} for unopened cells, {digits} for marked cells, {blank} for open empty cells.</param><param name="mines">Matrix of all cells containing inner cell contents - {*} in cells holding active mines, {-} for mine-free cells, {blank} for open empty cells.</param><param name="row">Cell row index value.</param><param name="column">Cell column index value.</param>
        private static void UpdateSquareMark(char[,] marks, char[,] mines, int row, int column)
        {
            char newCountToCharacter = GetNeighbourMineCount(mines, row, column);
            mines[row, column] = newCountToCharacter;
            marks[row, column] = newCountToCharacter;
        }

        /// <summary>Display the minefield anew.</summary><param name="marks">Player game area.</param>
        private static void ReDrawMarks(char[,] marks)
        {
            Engine.Instance.Writer.WriteLine(MinefieldConstants.TopRulers);
            Engine.Instance.Writer.WriteLine(MinefieldConstants.LineBreak);
            for (int row = 0; row < MinefieldConstants.DefaultRows; row++)
            {
                Engine.Instance.Writer.Write(string.Format($"{row} {MinefieldConstants.SideEdge} "));
                for (int column = 0; column < MinefieldConstants.DefaultColumns; column++)
                {
                    Engine.Instance.Writer.Write(string.Format($"{marks[row, column]} "));
                }

                Engine.Instance.Writer.Write(MinefieldConstants.SideEdge);
                Engine.Instance.Writer.WriteLine();
            }

            Engine.Instance.Writer.WriteLine(MinefieldConstants.LineBreak);
        }

        /// <summary>Refresh all mine cell values.</summary><param name="mines">Matrix of mine cells.</param>
        private static void UpdateMineCounts(char[,] mines)
        {
            for (int row = 0; row < MinefieldConstants.DefaultRows; row++)
            {
                for (int column = 0; column < MinefieldConstants.DefaultColumns; column++)
                {
                    if (mines[row, column] != MinefieldConstants.LoadedMineCell)
                    {
                        char mineCountUpdate = GetNeighbourMineCount(mines, row, column);
                        mines[row, column] = mineCountUpdate;
                    }
                }
            }
        }

        /// <summary>Char the number of mines in adjacent cell contents by row and column index.</summary><param name="mines">Matrix of all cell contents - {*} for cells holding active mines, {-} for mine-free cells, {blank} for open empty cells.</param><param name="row">Cell row index.</param><param name="column">Cell column index.</param><returns>Adjacent mine count as char value.</returns>
        private static char GetNeighbourMineCount(char[,] mines, int row, int column)
        {
            int count = 0;
            if (row - 1 >= 0)
            {
                if (mines[row - 1, column] == MinefieldConstants.LoadedMineCell)
                {
                    count++;
                }
            }

            if (row + 1 < MinefieldConstants.DefaultRows)
            {
                if (mines[row + 1, column] == MinefieldConstants.LoadedMineCell)
                {
                    count++;
                }
            }

            if (column - 1 >= 0)
            {
                if (mines[row, column - 1] == MinefieldConstants.LoadedMineCell)
                {
                    count++;
                }
            }

            if (column + 1 < MinefieldConstants.DefaultColumns)
            {
                if (mines[row, column + 1] == MinefieldConstants.LoadedMineCell)
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (mines[row - 1, column - 1] == MinefieldConstants.LoadedMineCell)
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < MinefieldConstants.DefaultColumns))
            {
                if (mines[row - 1, column + 1] == MinefieldConstants.LoadedMineCell)
                {
                    count++;
                }
            }

            if ((row + 1 < MinefieldConstants.DefaultRows) && (column - 1 >= 0))
            {
                if (mines[row + 1, column - 1] == MinefieldConstants.LoadedMineCell)
                {
                    count++;
                }
            }

            if ((row + 1 < MinefieldConstants.DefaultRows) && (column + 1 < MinefieldConstants.DefaultColumns))
            {
                if (mines[row + 1, column + 1] == MinefieldConstants.LoadedMineCell)
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
