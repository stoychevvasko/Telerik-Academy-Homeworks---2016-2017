//// <copyright file="IWriter.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    /// <summary>Standard writer functionality.</summary>
    public interface IWriter
    {
        /// <summary>Writes a new line of text to the console.</summary><param name="message">A literal string.</param>
        void WriteLine(string message);

        /// <summary>Writes a new blank line of text to the console.</summary>
        void WriteLine();

        /// <summary>Writes to the same line of text on the console.</summary><param name="message">A literal string.</param>
        void Write(string message);

        /// <summary>Clears console screen.</summary>
        void ClearConsole();
    }
}
