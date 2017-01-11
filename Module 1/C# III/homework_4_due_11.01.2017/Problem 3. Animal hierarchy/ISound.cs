////-----------------------------------------------------------------------
//// <copyright file="ISound.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_03
{
    /// <summary>
    /// Exposes the MakeSound() method for public use.
    /// </summary>
    public interface ISound
    {
        /// <summary>
        /// Produce a vocal sound.
        /// </summary>
        void MakeSound();
    }
}
