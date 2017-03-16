//// <copyright file="ConsoleWriter.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Providers
{
    using System;
    using Contracts.Interfaces;

    /// <summary>Provides standard console writing functionality.</summary>
    public class ConsoleWriter : IWriter
    {
        /// <summary>Writes a new line of text to the console.</summary><param name="message">Text message to be written to console.</param>
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
