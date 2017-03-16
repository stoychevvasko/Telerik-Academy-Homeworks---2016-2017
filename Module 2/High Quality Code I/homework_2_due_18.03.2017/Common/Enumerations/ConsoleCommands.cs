//// <copyright file="ConsoleCommands.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Common.Enumerations
{
    /// <summary>Valid user commands.</summary>
    public enum ConsoleCommands
    {
        /// <summary>Player quit command.</summary>
        Exit = 0,

        /// <summary>Player view high score command.</summary>
        Top,

        /// <summary>Player start new game command.</summary>
        Restart,

        /// <summary>Automated complete turn command.</summary>
        Turn
    }
}
