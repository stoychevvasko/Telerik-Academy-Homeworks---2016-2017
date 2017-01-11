////-----------------------------------------------------------------------
//// <copyright file="Student.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_02
{
    /// <summary>
    /// Represents a student at school or university.
    /// </summary>
    public class Student : Human
    {
        /// <summary>
        /// Holds the default first name value for students.
        /// </summary>
        private const string DefaultFirstName = "Default_Student_Name";

        /// <summary>
        /// Holds the default surname value for students.
        /// </summary>
        private const string DefaultLastName = "Default_Student_Surname";

        /// <summary>
        /// Holds a student's grade.
        /// </summary>
        private double? grade;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">A <see cref="string"/> value for the first name.</param>
        /// <param name="lastName">A <see cref="string"/> value for the last name.</param>
        /// <param name="grade">A <see cref="double?"/> value for the grade parameter.</param>
        public Student(string firstName, string lastName, double? grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        public Student()
            : this(Student.DefaultFirstName, Student.DefaultLastName, null)
        {
        }

        /// <summary>
        /// Gets or sets the grade of a student.
        /// </summary>
        public double? Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value == null)
                {
                    this.grade = null;
                }

                this.grade = value;
            }
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A <see cref="string"/> value.</returns>
        public override string ToString()
        {
            return string.Format(
                "{0}\n   Grade: {1:F2}\n",
                base.ToString(),
                (this.Grade == null) ? "(no grade)" : this.Grade.ToString());
        }
    }
}
