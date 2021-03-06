﻿//// <copyright file="ConsoleWriter.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Providers
{
    using System;
    using Contracts.Interfaces;

    /// <summary>Provides standard console writing functionality.</summary>
    internal class ConsoleWriter : IWriter
    {
        /// <summary>Writes a new line of text to the console.</summary><param name="message">Text message to be written to console.</param>
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>Writes a new blank line of text to the console.</summary>
        public void WriteLine()
        {
            this.WriteLine(string.Empty);
        }

        /// <summary>Writes to the same line of text on the console.</summary><param name="message">A literal string.</param>
        public void Write(string message)
        {
            Console.Write(message);
        }

        /// <summary>Clears console screen.</summary>
        public void ClearConsole()
        {
            Console.SetCursorPosition(0, 0);
            Console.Clear();
            Console.SetCursorPosition(0, 0);
        }
    }
}
