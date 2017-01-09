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
        private HashSet<Discipline> disciplinesTaught;

        /// <summary>
        /// Initiates a new instance of the <see cref="Teacher"/> class.
        /// </summary>
        /// <param name="name">A <see cref="string"/>.</param>
        /// <param name="discipline">A single <see cref="Discipline"/> object.</param>
        public Teacher(string name, Discipline discipline)
            : this(name)
        {
            this.Disciplines.Add(discipline);
        }
        /// <summary>
        /// Initiates a new instance of the <see cref="Teacher"/> class.
        /// </summary>
        /// <param name="name">A <see cref="string"/>.</param>
        /// <param name="disciplines">An <see cref="IEnumerable{T}"/> set of <see cref="Discipline"/> objects.</param>
        public Teacher(string name, ICollection<Discipline> disciplines)
        {
            this.Name = name;
            this.Disciplines = (HashSet<Discipline>)disciplines;
        }
        /// <summary>
        /// Initiates a new instance of the <see cref="Teacher"/> class.
        /// </summary>
        /// <param name="name">A <see cref="string"/></param>
        public Teacher(string name)
            : this(name, new HashSet<Discipline>())
        {
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
        public ICollection<Discipline> Disciplines
        {
            get
            {
                return this.disciplinesTaught;
            }

            private set
            {
                this.disciplinesTaught = new HashSet<Discipline>();
                foreach (Discipline discipline in value)
                {
                    this.AddDiscipline(discipline);
                    //this.disciplinesTaught.Add(discipline);
                }
            }
        }

        /// <summary>
        /// Adds a new discipline to the set of disciplines taught by a teacher.
        /// </summary>
        /// <param name="discipline">A <see cref="Discipline"/>.</param>
        public void AddDiscipline(Discipline discipline)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new discipline to the set of disciplines taught by a teacher.
        /// </summary>
        /// <param name="discipline">A <see cref="Discipline"/>.</param>
        public void RemoveDiscipline(Discipline discipline)
        {
            throw new NotImplementedException();
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

            if (this.Disciplines != null && this.disciplinesTaught.Count > 0)
            {
                result.Append(", Teaches: ");

                for (int i = 0; i < this.disciplinesTaught.Count; i++)
                {
                    result.Append(this);
                    if (i < this.disciplinesTaught.Count - 1)
                    {
                        result.Append(',');
                    }
                }


            }

            return result.ToString();
        }
    }
}

