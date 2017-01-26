////-----------------------------------------------------------------------
//// <copyright file="Animal.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_03
{
    using System;

    /// <summary>
    /// Represents an animal.
    /// </summary>
    public class Animal : ISound
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="age">An animal's age.</param>
        /// <param name="name">An animal's name.</param>
        /// <param name="sex">An animal's sex.</param>
        public Animal(uint age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = Sex;
        }

        /// <summary>
        /// Gets or sets the age of an animal.
        /// </summary>
        public uint Age
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of an animal.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sex of an animal.
        /// </summary>
        public Sex Sex
        {
            get;
            set;
        }

        /// <summary>
        /// Produces a generic animal sound.
        /// </summary>
        public virtual void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
