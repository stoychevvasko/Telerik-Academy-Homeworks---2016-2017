//// <copyright file="IMarks.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    /// <summary>Marks functionality - outer layer with {?} for unopened cells, {digits} for marked cells, {blank} for open empty cells.</summary>
    public interface IMarks
    {
        /// <summary>Gets or sets matrix of all cells containing outer display values - {?} for unopened cells, {digits} for marked cells, {blank} for open empty cells.</summary>
        char[,] Marks { get; set; }
    }
}
