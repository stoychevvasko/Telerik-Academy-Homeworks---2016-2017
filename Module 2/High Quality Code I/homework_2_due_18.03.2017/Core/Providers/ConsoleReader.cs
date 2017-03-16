//// <copyright file="ConsoleReader.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Providers
{
    using System;
    using Contracts.Interfaces;

    /// <summary>Provides standard console input reading functionality.</summary>
    public class ConsoleReader : IReader
    {
        /// <summary>Reads a new line of text from the console.<returns>Text literal.</returns>        
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
