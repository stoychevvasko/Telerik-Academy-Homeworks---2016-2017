//// <copyright file="Minefield.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
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
            this.Marks = MinefieldConstants.GetNewEmptyMinesMatrix();
            this.Mines = MinefieldConstants.GetRandomizedCells();
        }

        /// <summary>Gets or sets matrix of all cells containing outer display values - {?} for unopened cells, {digits} for marked cells, {blank} for open empty cells.</summary>
        public char[,] Marks { get; set; }

        /// <summary>Gets or sets matrix of all cells containing inner cell contents - {*} in cells holding active mines, {-} for mine-free cells, {blank} for open empty cells.</summary>
        public char[,] Mines { get; set; }
    }
}
