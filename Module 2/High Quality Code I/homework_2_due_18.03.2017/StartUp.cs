//// <copyright file="StartUp.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Mocksweeper
{
    using System;
    using System.Collections.Generic;
    using MinefieldConstants = Minesweeper.Common.Constants.Constants.Game.Minefield;
    using Minesweeper.Common.Constants;    
    using Minesweeper.Core.Models;
    using Minesweeper.Core.Contracts.Interfaces;

    /// <summary>Main executable.</summary>
    public class StartUp
    {
        /// <summary>Starts here.</summary>
        public static void Main()
        {
            var engine = Engine.Instance;
            


            string command = Constants.Game.Command.DefaultCommand;
            char[,] minefield = create_igralno_pole();
            char[,] mines = getNewRandomGameBoard();
            int counter = 0;
            bool grum = false;
            List<Score> topPlayers = new List<Score>(6);
            int row = 0;
            int column = 0;
            bool flag = true;
            const int maks = 35;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine(Constants.Game.Message.TitleLine);
                    dumpp(minefield);
                    flag = false;
                }
                Console.Write(Constants.Game.Message.PromptNextPlayerTurn);
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= minefield.GetLength(0) && column <= minefield.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        klasacia(topPlayers);
                        break;
                    case "restart":
                        minefield = create_igralno_pole();
                        mines = getNewRandomGameBoard();
                        dumpp(minefield);
                        grum = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                tisinahod(minefield, mines, row, column);
                                counter++;
                            }
                            if (maks == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                dumpp(minefield);
                            }
                        }
                        else
                        {
                            grum = true;
                        }
                        break;
                    default:
                        Console.WriteLine(Constants.Game.Message.InvalidCommand);
                        break;
                }

                if (grum)
                {
                    dumpp(mines);
                    Console.Write(Constants.Game.Message.GameOverLine(counter));
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
                    klasacia(topPlayers);

                    minefield = create_igralno_pole();
                    mines = getNewRandomGameBoard();
                    counter = 0;
                    grum = false;
                    flag = true;
                }

                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    dumpp(mines);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    Score to4kii = new Score(imeee, counter);
                    topPlayers.Add(to4kii);
                    klasacia(topPlayers);
                    minefield = create_igralno_pole();
                    mines = getNewRandomGameBoard();
                    counter = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void klasacia(List<Score> to4kii)
        {
            Console.WriteLine(Constants.Game.Message.FinalScore);
            if (to4kii.Count > 0)
            {
                for (int i = 0; i < to4kii.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, to4kii[i].Name, to4kii[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void tisinahod(char[,] POLE,
            char[,] BOMBI, int RED, int KOLONA)
        {
            char kolkoBombi = kolko(BOMBI, RED, KOLONA);
            BOMBI[RED, KOLONA] = kolkoBombi;
            POLE[RED, KOLONA] = kolkoBombi;
        }

        private static void dumpp(char[,] board)
        {
            int RRR = board.GetLength(0);
            int KKK = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < RRR; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < KKK; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        

        private static char[,] getNewRandomGameBoard()
        {
            int rows = 5;
            int columns = 10;
            char[,] gameBoard = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    gameBoard[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int col = (i2 / columns);
                int row = (i2 % columns);
                if (row == 0 && i2 != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }
                gameBoard[col, row - 1] = '*';
            }

            return gameBoard;
        }

        private static void smetki(char[,] cell)
        {
            int kol = cell.GetLength(0);
            int red = cell.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (cell[i, j] != '*')
                    {
                        char kolkoo = kolko(cell, i, j);
                        cell[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char kolko(char[,] r, int rr, int rrr)
        {
            int brojkata = 0;
            int reds = r.GetLength(0);
            int kols = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    brojkata++;
                }
            }

            if (rr + 1 < reds)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    brojkata++;
                }
            }

            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if (rrr + 1 < kols)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr - 1 >= 0) && (rrr + 1 < kols))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr + 1 < reds) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }

            if ((rr + 1 < reds) && (rrr + 1 < kols))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }

            return char.Parse(brojkata.ToString());
        }
    }
}
