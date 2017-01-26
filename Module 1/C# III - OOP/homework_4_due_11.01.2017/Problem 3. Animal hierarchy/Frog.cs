////-----------------------------------------------------------------------
//// <copyright file="Frog.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_03
{
    using System;

    /// <summary>
    /// Represents a cat.
    /// </summary>
    public class Frog : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Frog"/> class.
        /// </summary>
        /// <param name="age">A frog's age.</param>
        /// <param name="name">A frog's name.</param>
        /// <param name="sex">A frog's sex.</param>
        public Frog(uint age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        /// <summary>
        /// Produce a frog-specific sound.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Ribbit!");
        }
    }
}
