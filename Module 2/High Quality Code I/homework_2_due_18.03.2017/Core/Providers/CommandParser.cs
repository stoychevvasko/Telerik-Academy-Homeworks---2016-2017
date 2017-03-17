//// <copyright file="CommandParser.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Providers
{
    using Common.Enumerations;

    /// <summary>Converts string user input to <see cref="CommandTypes"/> enum value.</summary>
    internal abstract class CommandParser
    {
        /// <summary>Parses command string to <see cref="CommandTypes"/> value.</summary>
        /// <param name="userCommand">Command line string.</param>
        /// <returns>Enum value of the <see cref="CommandTypes"/>.</returns>
        public static CommandTypes Parse(string userCommand)
        {
            switch (string.Join(string.Empty, userCommand.ToLower().Trim().Split(' ')))
            {
                case "top":
                    return CommandTypes.Top;
                case "restart":
                    return CommandTypes.Restart;
                case "exit":
                    return CommandTypes.Exit;
                default:
                    return CommandTypes.Turn;
            }
        }
    }
}
