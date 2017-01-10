using System;
using System.Text;

namespace Problem_01
{
    /// <summary>
    /// Represents a student within a school model.
    /// </summary>
    public class Student : IPerson, IClassNumber
    {
        /// <summary>
        /// Holds the default value for a <see cref="Student"/>'s first name.
        /// </summary>
        private const string DEFAULT_FIRST_NAME = "Default_Student_Name";

        /// <summary>
        /// Holds the default value for a <see cref="Student"/>'s surname.
        /// </summary>
        private const string DEFAULT_SURNAME = "Default_Student_Surname";

        /// <summary>
        /// Holds the default value for a <see cref="Student"/>'s unique class number.
        /// </summary>
        private const int DEFAULT_CLASS_NUMBER = -1;

        /// <summary>
        /// Holds the first name of a <see cref="Student"/>.
        /// </summary>
        private string givenName;

        /// <summary>
        /// Holds the surname of a <see cref="Student"/>.
        /// </summary>
        private string surname;

        /// <summary>
        /// Holds the unique class numb4er of a <see cref="Student"/>.
        /// </summary>
        private int classNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="fullName">Represents a student's full name.</param>
        /// <param name="classNumber">Represents a student's unique class number.</param>
        public Student(string fullName, int classNumber)
        {
            this.Name = fullName;
            this.ClassNumber = classNumber;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class .
        /// </summary>
        public Student()
            : this(Student.DEFAULT_FIRST_NAME + ' ' + Student.DEFAULT_SURNAME, Student.DEFAULT_CLASS_NUMBER)
        {
        }

        /// <summary>
        /// Represents the individual name of a <see cref="Student"/>.
        /// </summary>
        public string Name
        {
            get
            {
                return new StringBuilder()
                           .Append(this.givenName)
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
                this.givenName = twoNames[0];
                this.surname = twoNames[1];
            }
        }

        /// <summary>
        /// Represents the unique class number of a <see cref="Student"/>.
        /// </summary>
        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                this.classNumber = value;
            }
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A <see cref="string"/> value.</returns>
        public override string ToString()
        {
            return new StringBuilder()
                       .Append(string.Format("Type: {0},  Name: {1},  Class number: {2}",
                                            base.ToString().Split('.')[1],
                                            this.Name,
                                            this.ClassNumber))
                       .ToString();
        }
    }
}
