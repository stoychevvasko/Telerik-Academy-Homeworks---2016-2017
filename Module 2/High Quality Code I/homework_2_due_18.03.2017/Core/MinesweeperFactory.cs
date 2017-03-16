//// <copyright file="MinesweeperFactory.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core
{
    using Contracts.Interfaces;
    using Models;

    /// <summary>Provides game factory functionality for instantiation of all relevant game objects.</summary>
    public class MinesweeperFactory : IGameFactory
    {
        /// <summary>Holds factory singleton instance for Minesweeper game objects.</summary>
        private static IGameFactory instanceHolder = new MinesweeperFactory();

        /// <summary>Prevents a default instance of the <see cref="MinesweeperFactory"/> class from being created.</summary>
        private MinesweeperFactory()
        {
        }

        /// <summary>Gets the Minesweeper game object factory singleton instance.</summary>
        public static IGameFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        /// <summary>Creates a new <see cref="IMinefield"/>-like object.</summary><returns>A new blank game board.</returns>
        public IMinefield CreateNewBlankGameBoard()
        {
            return new Minefield();
        }
    }
}
