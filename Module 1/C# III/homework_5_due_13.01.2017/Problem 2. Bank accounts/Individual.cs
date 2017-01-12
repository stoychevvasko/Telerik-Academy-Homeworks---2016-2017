////-----------------------------------------------------------------------
//// <copyright file="Individual.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_02
{
    /// <summary>
    /// Represents an individual client as a private person.
    /// </summary>
    public class Individual : Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Individual"/> class.
        /// </summary>
        /// <param name="individualName">Individual client's name.</param>
        public Individual(string individualName)
            : base(individualName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Individual"/> class.
        /// </summary>
        public Individual()
            : this("Unknown individual")
        {
        }
    }
}
