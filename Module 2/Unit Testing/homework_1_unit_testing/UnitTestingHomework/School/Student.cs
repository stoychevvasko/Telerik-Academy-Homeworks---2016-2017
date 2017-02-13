////-------------------------------------------------------------------------------------------------
//// <copyright file="Student.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace Problem_01
{
    using System;

    /// <summary>
    /// Represents a student.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Holds a student's name.
        /// </summary>
        private string name;

        /// <summary>
        /// Holds a student's unique number.
        /// </summary>
        private int uniqueNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="name">The student's name.</param>
        /// <param name="id">The student's id</param>
        public Student(string name, int id)
        {
            this.Name = name;
            this.UniqueNumber = id;
        }

        /// <summary>
        /// Gets or sets the name of a student.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Student name cannot be null!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Student name cannot be empty string!");
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets a student's unique number.
        /// </summary>
        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Student ID cannot be outside the range [10000, 99999]! Actual - {0}", value));
                }

                this.uniqueNumber = value;
            }
        }
    }
}
