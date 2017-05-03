namespace SchoolSystem.Models.Abstract
{
    using System;
    using System.Text.RegularExpressions;
    using Contracts;

    /// <summary>Represents a person.</summary>
    public abstract class Person : IPerson
    {
        private string firstName;

        private string lastName;

        /// <summary>Initializes a new instance of the <see cref="Person"/> class.</summary>
        /// <param name="firstName">Person's first name.</param>
        /// <param name="lastName">Person's last name.</param>
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>Gets or sets person's first name.</summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                string pattern = @"^[a-zA-Z]{2,31}$";
                Match match = Regex.Match(value, pattern);
                if (match.Success == false)
                {
                    throw new ArgumentOutOfRangeException($"cannot set first name {value}");
                }

                this.firstName = value;
            }
        }

        /// <summary>Gets or sets person's last name.</summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                string pattern = @"^[a-zA-Z]{2,31}$";
                Match match = Regex.Match(value, pattern);
                if (match.Success == false)
                {
                    throw new ArgumentOutOfRangeException($"cannot set last name {value}");
                }

                this.lastName = value;
            }
        }
    }
}
