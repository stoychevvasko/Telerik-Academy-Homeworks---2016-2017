//// <copyright file="Course.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace InheritanceAndPolymorphism.Core.Models
{
    using System;
    using System.Collections.Generic;
    using Contracts.Interfaces;

    /// <summary>Represents a generalized course model.</summary>
    internal abstract class Course : ICourse
    {
        /// <summary>Holds the course name.</summary>
        private string name;

        /// <summary>Holds the list of students subscribed to the course.</summary>
        private IList<string> students;

        /// <summary>Holds the course teacher name.</summary>
        private string teacherName;

        /// <summary>Initializes a new instance of the <see cref="Course"/> class using default values.</summary>
        public Course()
            : this("Default Course", new List<string>(), "Default Teacher")
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Course"/> class.</summary><param name="name">Course name as a <see cref="string"/> value.</param><param name="students">A list of course students.</param><param name="teacherName">Course teacher as a <see cref="string"/> value.</param>
        public Course(string name, IList<string> students, string teacherName)
        {
            this.Name = name;
            this.Students = students;
            this.TeacherName = teacherName;
        }

        /// <summary>Gets or sets the course name.</summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentException("Cannot set null or empty string as course name!");
                }

                this.name = value;
            }
        }

        /// <summary>Gets or sets a list of students subscribed to the course.</summary>
        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Cannot set null or empty list of students!");
                }

                this.students = value;
            }
        }

        /// <summary>Gets or sets the course teacher name.</summary>
        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentException("Cannot set null or empty course teacher name!");
                }

                this.teacherName = value;
            }
        }

        /// <summary>Transforms the list of students subscribed to the course into <see cref="string"/> form.</summary><returns>A <see cref="string"/> containing all students subscribed to the course in standard format.</returns>
        internal string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
