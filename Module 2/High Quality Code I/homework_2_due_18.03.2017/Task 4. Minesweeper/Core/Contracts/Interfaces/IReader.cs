//// <copyright file="IReader.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    using System;

    /// <summary>Standard reader functionality.</summary>
    public interface IReader
    {
        /// <summary>Reads a new line of text from the console.</summary><returns>Text literal.</returns>
        string ReadLine();

        /// <summary>Reads a single keystroke from the console.</summary><returns>Char code.</returns>
        ConsoleKeyInfo ReadKey();
    }
}
