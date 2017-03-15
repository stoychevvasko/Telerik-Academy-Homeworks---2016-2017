//// <copyright file="IScore.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    /// <summary> Minesweeper game score functionality.</summary>
    public interface IScore
    {
        /// <summary>Gets or sets player name.</summary>
        string Name { get; set; }

        /// <summary>Gets or sets player points points.</summary>
        int Points { get; set; }
    }
}
