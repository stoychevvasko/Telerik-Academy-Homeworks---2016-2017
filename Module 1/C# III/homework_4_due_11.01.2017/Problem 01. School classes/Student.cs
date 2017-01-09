using System;
using System.Text;

namespace Problem_01
{
    /// <summary>
    /// Represents a student within a school model.
    /// </summary>
    public class Student : IPerson
    {
        /// <summary>
        /// Holds the default value for a student's first name.
        /// </summary>
        private const string DEFAULT_FIRST_NAME = "unspecified_fname";

        /// <summary>
        /// Holds the default value for a student's surname.
        /// </summary>
        private const string DEFAULT_SURNAME = "unspecified_surname";

        /// <summary>
        /// Holds the first name of a <see cref="Student"/> as a <see cref="string"/> value.
        /// </summary>
        private string firstName;

        /// <summary>
        /// Holds the surname of a <see cref="Student"/> as a <see cref="string"/> value.
        /// </summary>
        private string surname;

        public Student(string fName, string lName, )

        /// <summary>
        /// Represents the individual name of a <see cref="Student"/>.
        /// </summary>
        public string Name
        {
            get
            {
                return new StringBuilder()
                           .Append(this.firstName)
                           .Append(' ')
                           .Append(this.surname)
                           .ToString();
            }

            set
            {
                if (string.IsNullOrEmpty(value) || (value.Split(' ').Length != 2))
                {
                    throw new ArgumentException(string.Format("Cannot set {0} as student name - unexpected value!", value));
                }

                string[] twoNames = value.Split(' ');
                this.firstName = twoNames[0];
                this.surname = twoNames[1];
            }
        }
    }
}
