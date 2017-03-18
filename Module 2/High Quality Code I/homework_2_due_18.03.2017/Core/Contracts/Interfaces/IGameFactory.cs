//// <copyright file="IGameFactory.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    /// <summary>Provides game factory functionality for instantiation of all relevant game objects.</summary>
    public interface IGameFactory
    {
        /// <summary>Create a new instance of the <see cref="Minefield"/> game class.</summary><returns>A new <seealso cref="Minefield"/> instance.</returns>
        IMinefield CreateNewMinefield();

        /// <summary>Create a new instance of a <see cref="ICounter"/>-like object.</summary><returns>A new object.</returns>
        ICounter CreateNewMineCounter();

        /// <summary>Create a new instance of a <see cref="IReader"/>-like object.</summary><returns>A new object.</returns>
        IReader CreateNewConsoleReader();

        /// <summary>Create a new instance of a <see cref="IWriter"/>-like object.</summary><returns>A new object.</returns>
        IWriter CreateNewConsoleWriter();
    }
}
