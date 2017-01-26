////-----------------------------------------------------------------------
//// <copyright file="Dog.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_03
{
    using System;

    /// <summary>
    /// Represents a dog.
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dog"/> class.
        /// </summary>
        /// <param name="age">A dog's age.</param>
        /// <param name="name">A dog's name.</param>
        /// <param name="sex">A dog's sex.</param>
        public Dog(uint age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        /// <summary>
        /// Produce a dog-specific sound.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Woof-woof!");
        }
    }
}
