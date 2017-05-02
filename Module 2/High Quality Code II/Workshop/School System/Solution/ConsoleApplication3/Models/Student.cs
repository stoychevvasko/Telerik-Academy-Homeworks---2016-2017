namespace SchoolSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Abstract;
    using Contracts;
    using Enumerations;

    /// <summary>Represents a student.</summary>
    public class Student : Person, IPerson, IStudent
    {
        private Grade grade;

        private List<Mark> marks;

        /// <summary>Initializes a new instance of the <see cref="Student"/> class.</summary>
        /// <param name="firstName">Student's first name.</param>
        /// <param name="lastName">Student's last name.</param>
        /// <param name="grade">Student's grade.</param>
        public Student(string firstName, string lastName, Grade grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
            this.Marks = new List<Mark>();
        }

        /// <summary>Gets or sets student grade.</summary>
        public Grade Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (Enum.IsDefined(typeof(Grade), value))
                {
                    this.grade = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"cannot set student grade (Grade){value}");
                }
            }
        }

        /// <summary>Gets or sets student marks.</summary>
        public IList<Mark> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                if (value != null)
                {
                    this.marks = (List<Mark>)value;
                }
                else
                {
                    throw new ArgumentNullException($"cannot set student marks! {value}");
                }
            }
        }

        /// <summary>Lists all student marks as a string value.</summary>
        /// <returns>Student marks as string.</returns>
        public string ListMarks()
        {
            var listOfMarks = this.Marks.Select(m => $"{m.Subject} => {m.Value}").ToList();
            return string.Join("\n", listOfMarks);
        }
    }
}
