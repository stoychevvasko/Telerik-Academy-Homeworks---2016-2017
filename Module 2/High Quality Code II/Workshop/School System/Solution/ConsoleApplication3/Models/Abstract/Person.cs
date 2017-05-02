namespace SchoolSystem.Models.Abstract
{
    using System;
    using System.Text.RegularExpressions;
    using SchoolSystem.Models.Contracts;

    public abstract class Person : IPerson
    {
        private string firstName;

        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

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
