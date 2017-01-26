////-----------------------------------------------------------------------
//// <copyright file="Kitten.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_03
{
    /// <summary>
    /// Represents a cat.
    /// </summary>
    public class Kitten : Cat
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Kitten"/> class.
        /// </summary>
        /// <param name="age">A kitten's age.</param>
        /// <param name="name">A kitten's name.</param>        
        public Kitten(uint age, string name)
            : base(age, name, Sex.Female)
        {
        }
    }
}
