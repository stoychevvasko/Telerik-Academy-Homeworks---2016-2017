//// <copyright file="IMinefield.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    /// <summary>Provides minefield-related functionality for the Minesweeper game.</summary>
    public interface IMinefield
    {
        /// <summary>Represents matrix of all cells of the minefield in the Minesweeper game.</summary>
        char[,] Board { get; set; }
    }
}
