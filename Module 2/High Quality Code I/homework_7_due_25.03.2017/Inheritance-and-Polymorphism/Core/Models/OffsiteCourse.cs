//// <copyright file="OffsiteCourse.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace InheritanceAndPolymorphism.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Contracts.Interfaces;

    /// <summary>Represents a course held offsite (remotely).</summary>
    internal class OffsiteCourse : Course, ICourse, IOffsite
    {
        /// <summary>Holds the town location where the offsite course takes place.</summary>
        private string town;

        /// <summary>Initializes a new instance of the <see cref="OffsiteCourse"/> class.</summary><param name="name">Offsite course name.</param>
        public OffsiteCourse(string name)
            : this(name, "Default Teacher")
        {
        }

        /// <summary>Initializes a new instance of the <see cref="OffsiteCourse"/> class.</summary><param name="courseName">Offsite course name.</param><param name="teacherName">Offsite course teacher name.</param>>
        public OffsiteCourse(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>(), "Default Town")
        {
        }

        /// <summary>Initializes a new instance of the <see cref="OffsiteCourse"/> class.</summary><param name="courseName">Offsite course name.</param><param name="teacherName">Offsite course teacher name.</param><param name="students">Offsite course list of students.</param><param name="town">Offsite course town location.</param>
        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
            this.Town = town;
        }

        /// <summary>Gets or sets the town location of an offsite course.</summary>
        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentException("Cannot set null or empty offsite course town!");
                }

                this.town = value;
            }
        }

        /// <summary>Presents this local course as a standard <see cref="string"/> value.</summary><returns>A <see cref="string"/> representation of the course.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
