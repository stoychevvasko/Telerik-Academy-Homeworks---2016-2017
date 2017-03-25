//// <copyright file="LocalCourse.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace InheritanceAndPolymorphism.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Contracts.Interfaces;

    /// <summary>Represents a course held locally.</summary>
    internal class LocalCourse : Course, ICourse, ILocal
    {
        /// <summary>Holds the local course lab.</summary>
        private string lab;

        /// <summary>Initializes a new instance of the <see cref="LocalCourse"/> class.</summary><param name="name">Local course name.</param>
        public LocalCourse(string name)
            : this(name, "Default Teacher Name", new List<string>(), "Default Lab")
        {
        }

        /// <summary>Initializes a new instance of the <see cref="LocalCourse"/> class.</summary><param name="courseName">Local course name.</param><param name="teacherName">Local course teacher name.</param>
        public LocalCourse(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>(), "Default Lab")
        {
        }

        /// <summary>Initializes a new instance of the <see cref="LocalCourse"/> class.</summary><param name="courseName">Local course name.</param><param name="teacherName">Local course teacher name.</param><param name="students">List of students for local course.</param><param name="lab">Lab for local course.</param>
        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
            this.Lab = lab;
        }

        /// <summary>Gets or sets the local course lab.</summary>
        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentException("Cannot set null or empty local course lab!");
                }

                this.lab = value;
            }
        }

        /// <summary>Presents this local course as a standard <see cref="string"/> value.</summary><returns>A <see cref="string"/> representation of the course.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
