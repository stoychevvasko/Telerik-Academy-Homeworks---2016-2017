////-------------------------------------------------------------------------------------------------
//// <copyright file="Course.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace Problem_01
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    /// <summary>
    /// Represents a course.
    /// </summary>
    public class Course : ICourse
    {
        /// <summary>
        /// Holds the course name.
        /// </summary>
        private string name;

        /// <summary>
        /// Holds a set of students currently subscribed to this course.
        /// </summary>
        private HashSet<Student> students;

        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class.
        /// </summary>
        /// <param name="courseName">Name of the course.</param>
        public Course(string courseName)
        {
            this.Name = courseName;
            this.students = new HashSet<Student>();
        }

        /// <summary>
        /// Gets or sets a course name.
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
                    throw new ArgumentNullException("Course name cannot be null!");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Course name cannot be empty string!");
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the students currently subscribed to this course.
        /// </summary>
        public IList<IStudent> Students
        {
            get
            {
                return (IList<IStudent>)this.students;
            }

            set
            {
                this.students = (HashSet<Student>)value;
            }
        }
    }
}
