//// <copyright file="IReader.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    /// <summary>Standard reader functionality.</summary>
    public interface IReader
    {
        /// <summary>Reads a new line of text from the console.<returns>Text literal.</returns>
        string ReadLine();
    }
}
