using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_01
{
    /// <summary>
    /// Represents a teacher within a school model.
    /// </summary>
    public class Teacher : IPerson, ITeacher
    {
        /// <summary>
        /// Holds the default value for the first name of a <see cref="Teacher"/>.
        /// </summary>
        private const string DEFAULT_GIVEN_NAME = "Default_Teacher_Name";

        /// <summary>
        /// Holds the default value for the surname of a <see cref="Teacher"/>.
        /// </summary>
        private const string DEFAULT_SURNAME = "Default_Teacher_Surname";

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
        /// Initiates a new instance of the <see cref="Teacher"/> class.
        /// </summary>
        /// <param name="name">A <see cref="string"/></param>
        public Teacher(string name)
        {
            this.Name = name;
            this.Disciplines = new HashSet<Discipline>();
        }
        /// <summary>
        /// Initiates a new instance of the <see cref="Teacher"/> class with default values.
        /// </summary>
        public Teacher()
            : this(Teacher.DEFAULT_GIVEN_NAME + ' ' + Teacher.DEFAULT_SURNAME)
        {
        }

        /// <summary>
        /// Represents the individual name of a <see cref="Teacher"/>.
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
        /// Represents the set of disciplines taught by a <see cref="Teacher"/>.
        /// </summary>
        public HashSet<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            set
            {
                this.disciplines = value;
            }
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A <see cref="string"/> value.</returns>
        public override string ToString()
        {
            var result = new StringBuilder()
                       .Append(string.Format("Type: {0},  Name: {1}",
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
    }
}

