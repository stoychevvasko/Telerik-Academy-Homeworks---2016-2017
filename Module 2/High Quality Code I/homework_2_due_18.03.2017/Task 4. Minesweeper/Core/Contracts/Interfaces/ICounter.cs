//// <copyright file="ICounter.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    /// <summary>Provides counter-related functionality.</summary>
    public interface ICounter
    {
        /// <summary>Gets the current value of the counter.</summary><returns>Count as integer value.</returns>
        int GetCount { get; }

        /// <summary>Reset the counter back to 0.</summary>
        void Reset();

        /// <summary>Increases counter value by 1.</summary>
        void Increase();
    }
}
