//// <copyright file="GameFactory.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core
{
    using Contracts.Interfaces;
    using Models;

    /// <summary>Provides game factory functionality for instantiation of all relevant game objects.</summary>
    public class GameFactory : IGameFactory
    {
        /// <summary>Holds factory singleton instance for Minesweeper game objects.</summary>
        private static IGameFactory instanceHolder = new GameFactory();

        /// <summary>Prevents a default instance of the <see cref="GameFactory"/> class from being created.</summary>
        private GameFactory()
        {
        }

        /// <summary>Gets the Minesweeper game object factory singleton instance.</summary>
        public static IGameFactory Instance
        {
            get { return instanceHolder; }
        }

        /// <summary>Creates a new <see cref="IMinefield"/>-like object.</summary><returns>A new blank game board.</returns>
        public IMinefield CreateNewMinefield()
        {
            return new Minefield();
        }
    }
}
