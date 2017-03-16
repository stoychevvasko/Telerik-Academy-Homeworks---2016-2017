//// <copyright file="Constants.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Common.Constants
{
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
            public static class Message
            {
                /// <summary>Prompts player turn.</summary>
                public const string PromptNextPlayerTurn = "Next move? [0-4] [space] [0-9] [enter]: ";

                /// <summary>Title line in Minesweeper game.</summary>
                public const string TitleLine = "play Mineweeper - find all the mine-free cells :(\n\nCommands:\n  [t][o][p] > highscores\n  [r][e][s][t][a][r][t] > new game\n  [e][x][i][t] > quit game\n";
            }
        }
    }
}
