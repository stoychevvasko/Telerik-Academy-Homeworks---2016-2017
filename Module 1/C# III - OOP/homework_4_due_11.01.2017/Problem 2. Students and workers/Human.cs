////-----------------------------------------------------------------------
//// <copyright file="Human.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_02
{
    /// <summary>
    /// Represents a human being.
    /// </summary>
    public abstract class Human
    {
        /// <summary>
        /// Holds the default value for the first name of a human.
        /// </summary>
        private const string DefaultFirstName = "Default_Human_Name";

        /// <summary>
        /// Holds the default value for the last name of a human.
        /// </summary>
        private const string DefaultLastName = "Default_Human_Surname";

        /// <summary>
        /// Initializes a new instance of the <see cref="Human"/> class.
        /// </summary>
        /// <param name="firstName">A <see cref="string"/> value for the first name.</param>
        /// <param name="lastName">A <see cref="string"/> value for the last name.</param>
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Human"/> class.
        /// </summary>
        public Human()
            : this(Human.DefaultFirstName, Human.DefaultLastName)
        {
        }

        /// <summary>
        /// Gets or sets a human's first name.
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a human's last name.
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A <see cref="string"/> value.</returns>
        public override string ToString()
        {
            return string.Format(
                "Type: {0}  Name: {1}  Surname: {2}",
                this.GetType().ToString().Split('.')[1],
                this.FirstName,
                this.LastName);
        }
    }
}
