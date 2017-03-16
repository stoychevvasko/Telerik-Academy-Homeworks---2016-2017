//// <copyright file="IWriter.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    /// <summary>Standard writer functionality.</summary>
    public interface IWriter
    {
        /// <summary>Writes a new line of text to the console.</summary><param name="text">Text to write to console.</param>
        void WriteLine(string text);
    }
}
