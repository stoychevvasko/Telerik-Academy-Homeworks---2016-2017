//// <copyright file="Minefield.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Models
{
    using Contracts.Interfaces;
    using MinefieldConstants = Common.Constants.Constants.Game.Minefield;

    /// <summary>Represents the standard game board in the Minesweeper game.</summary>
    public class Minefield : IMinefield
    {
        /// <summary>Holds Minesweeper game board matrix.</summary>
        private char[,] board;

        /// <summary>Initializes a new instance of the <see cref="Minefield"/> class.</summary>
        public Minefield()
        {
            this.Board = MinefieldConstants.BlankGameBoardCellMatrix();
        }

        /// <summary>Gets or sets Minesweeper game board matrix.</summary>
        public char[,] Board
        {
            get
            {
                return this.board;
            }

            set
            {
                this.board = value;
            }
        }
    }
}
