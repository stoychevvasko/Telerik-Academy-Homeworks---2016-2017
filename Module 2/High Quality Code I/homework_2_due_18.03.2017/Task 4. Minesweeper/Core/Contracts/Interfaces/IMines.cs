//// <copyright file="IMines.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    /// <summary>Mines functionality - cells with inner contents - {*} in cells holding active mines, {-} for mine-free cells, {blank} for open empty cells.</summary>
    public interface IMines
    {
        /// <summary>Gets or sets matrix of all cells containing inner cell contents - {*} in cells holding active mines, {-} for mine-free cells, {blank} for open empty cells.</summary>
        char[,] Mines { get; set; }
    }
}
