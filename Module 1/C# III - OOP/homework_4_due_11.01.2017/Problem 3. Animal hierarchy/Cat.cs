////-----------------------------------------------------------------------
//// <copyright file="Cat.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_03
{
    using System;

    /// <summary>
    /// Represents a cat.
    /// </summary>
    public class Cat : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cat"/> class.
        /// </summary>
        /// <param name="age">A cat's age.</param>
        /// <param name="name">A cat's name.</param>
        /// <param name="sex">A cat's sex.</param>
        public Cat(uint age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        /// <summary>
        /// Produce a cat-specific sound.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
