////-----------------------------------------------------------------------
//// <copyright file="Teacher.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents a teacher within a school model.
    /// </summary>
    public class Teacher : IPerson, ITeacher, IComment
    {
        /// <summary>
        /// Holds the default value for the first name of a <see cref="Teacher"/>.
        /// </summary>
        private const string DefaultFirstName = "Default_Teacher_Name";

        /// <summary>
        /// Holds the default value for the surname of a <see cref="Teacher"/>.
        /// </summary>
        private const string DefaultSurname = "Default_Teacher_Surname";

        /// <summary>
        /// Holds the first name of a <see cref="Teacher"/>.
        /// </summary>
        private string givenName;

        /// <summary>
        /// Holds the surname of a <see cref="Teacher"/>.
        /// </summary>
        private string surname;

        /// <summary>
        /// Holds the set of disciplines taught by a <see cref="Teacher"/>.
        /// </summary>
        private HashSet<Discipline> disciplines;

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class.
        /// </summary>
        /// <param name="name">A <see cref="string"/></param>
        public Teacher(string name)
        {
            this.Name = name;
            this.Disciplines = new HashSet<Discipline>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class with default values.
        /// </summary>
        public Teacher()
            : this(Teacher.DefaultFirstName + ' ' + Teacher.DefaultSurname)
        {
        }

        /// <summary>
        /// Gets or sets the individual name of a <see cref="Teacher"/>.
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
                    throw new ArgumentException(string.Format("Cannot set {0} as teacher name - unexpected value!", value));
                }

                string[] twoNames = value.Split(' ');
                this.givenName = twoNames[0];
                this.surname = twoNames[1];
            }
        }

        /// <summary>
        /// Gets or sets the set of disciplines taught by a <see cref="Teacher"/>.
        /// </summary>
        public ICollection<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            set
            {
                this.disciplines = new HashSet<Discipline>(value);
            }
        }

        /// <summary>
        /// Gets all comments as a single <see cref="string"/>.
        /// </summary>
        public string Comments
        {
            get;
            private set;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A <see cref="string"/> value.</returns>
        public override string ToString()
        {
            var result = new StringBuilder().Append(string.Format(
                                                        "Type: {0},  Name: {1}",
                                                        base.ToString().Split('.')[1],
                                                        this.Name));

            if (this.Disciplines.Count > 0)
            {
                result = result.Append(", Teaches: ");

                foreach (var item in this.Disciplines)
                {
                    result = result.Append(item.Name)
                             .Append(", ");
                }

                result.Length -= 2;
            }

            return result.ToString();
        }
        
        /// <summary>
        /// Clears all comments.
        /// </summary>
        public void ClearComments()
        {
            this.Comments = null;
        }
        
        /// <summary>
        /// Adds a new comment.
        /// </summary>
        /// <param name="comment">A <see cref="string"/>.</param>
        public void AddComment(string comment)
        {
            if (this.Comments == null)
            {
                this.Comments = string.Empty;
            }

            this.Comments += string.Format("\n\n-[new {0} comment @{1}]---\n{2}\n-----", this.GetType().ToString().Split('.')[1], DateTime.Now, comment);
        }
    }
}