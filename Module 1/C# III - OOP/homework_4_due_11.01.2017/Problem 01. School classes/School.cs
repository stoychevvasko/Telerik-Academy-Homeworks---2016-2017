////-----------------------------------------------------------------------
//// <copyright file="School.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents a school organization model.
    /// </summary>
    public class School : ISchool
    {
        /// <summary>
        /// Holds the default value for the first name of a <see cref="School"/>.
        /// </summary>
        private const string DefaultSchoolName = "Default_School_Name";

        /// <summary>
        /// Holds a set of classes within a school.
        /// </summary>
        private HashSet<SchoolClass> classes;

        /// <summary>
        /// Initializes a new instance of the <see cref="School"/> class.
        /// </summary>
        /// <param name="name">The school's name as a <see cref="String"/> value.</param>
        public School(string name)
        {
            this.Name = name;
            this.Classes = new HashSet<SchoolClass>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="School"/> class.
        /// </summary>
        public School()
            : this(School.DefaultSchoolName)
        {
        }

        /// <summary>
        /// Gets or sets the list of classes within a school.
        /// </summary>
        public ICollection<SchoolClass> Classes
        {
            get
            {
                return this.classes;
            }

            set
            {
                this.classes = new HashSet<SchoolClass>(value);
            }
        }

        /// <summary>
        /// Gets or sets the name of a school.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A <see cref="string"/> value.</returns>
        public override string ToString()
        {
            var result = new StringBuilder().Append(string.Format(
                                                        "Type: {0}, Full name: {1}",
                                                        base.ToString().Split('.')[1],
                                                        this.Name));

            if (this.Classes.Count > 0)
            {
                result = result.Append(", Teachers: ");

                foreach (var item in this.Classes)
                {
                    result = result.Append(item.ToString())
                             .Append(", ");
                }

                result.Length -= 2;
            }            

            return result.ToString();
        }
    }
}
