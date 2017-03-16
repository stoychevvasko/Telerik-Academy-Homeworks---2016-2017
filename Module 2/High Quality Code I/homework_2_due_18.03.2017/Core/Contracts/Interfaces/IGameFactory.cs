//// <copyright file="IGameFactory.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    /// <summary>Provides game factory functionality for instantiation of all relevant game objects.</summary>
    public interface IGameFactory
    {
        /// <summary>Create a new instance of the <see cref="Minefield"/> game class.</summary><returns>A new <seealso cref="Minefield"/> instance.</returns>
        IMinefield CreateNewMinefield();
    }
}
