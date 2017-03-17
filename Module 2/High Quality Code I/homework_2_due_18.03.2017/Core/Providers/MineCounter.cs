//// <copyright file="MineCounter.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Providers
{
    using System;
    using Contracts.Interfaces;

    /// <summary>Counts the number of mines found.</summary>
    internal class MineCounter : ICounter
    {
        /// <summary>Keeps count.</summary>
        private static int count = 0;

        /// <summary>Gets current count.</summary><returns>Integer count value.</returns>
        public int GetCount
        {
            get { return MineCounter.count; }
        }

        /// <summary>Increases count by one.</summary>
        public void Increase()
        {
            MineCounter.count++;
        }

        /// <summary>Rests count back to zero.</summary>
        public void Reset()
        {
            MineCounter.count = 0;
        }
    }
}
