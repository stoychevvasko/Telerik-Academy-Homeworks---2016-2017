//// <copyright file="Minefield.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Models
{
    using Contracts.Interfaces;
    using MinefieldConstants = Common.Constants.Constants.Game.Minefield;

    /// <summary>Represents the standard game board in the Minesweeper game.</summary>
    public class Minefield : IMinefield
    {
        /// <summary>Initializes a new instance of the <see cref="Minefield"/> class.</summary>
        public Minefield()
        {
            this.Cells = MinefieldConstants.GetNewBlankGameBoard();
        }

        /// <summary>Gets or sets Minesweeper game board matrix.</summary>
        public char[,] Cells
        {
            get;
            set;
        }
    }
}
