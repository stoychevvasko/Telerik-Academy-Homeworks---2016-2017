////-----------------------------------------------------------------------
//// <copyright file="SchoolClass.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents a class of students within a school model.
    /// </summary>
    public class SchoolClass : ISchoolClass
    {
        /// <summary>
        /// Holds the default value for the unique class identifier field.
        /// </summary>
        private const int DefaultClassID = -1;

        /// <summary>
        /// Holds a set of students assigned to a class.
        /// </summary>
        private HashSet<Student> students;

        /// <summary>
        /// Holds a set of teachers assigned to a class.
        /// </summary>
        private HashSet<Teacher> teachers;

        /// <summary>
        /// Holds the unique class identifier number.
        /// </summary>
        private int classID;

        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolClass"/> class.
        /// </summary>
        /// <param name="classID">A unique school class identifier.</param>
        public SchoolClass(int classID)
        {
            this.classID = classID;
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolClass"/> class.
        /// </summary>
        /// <param name="classIDString">A unique school class identifier.</param>
        public SchoolClass(string classIDString)
            : this(int.Parse(classIDString.Split(' ')[1]))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolClass"/> class.
        /// </summary>
        public SchoolClass()
            : this(SchoolClass.DefaultClassID)
        {
        }

        /// <summary>
        /// Gets or sets the set of students assigned to a class.
        /// </summary>
        public ICollection<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = new HashSet<Student>(value);
            }
        }

        /// <summary>
        /// Gets or sets the set of teachers assigned to a class.
        /// </summary>
        public ICollection<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                this.teachers = new HashSet<Teacher>(value);
            }
        }

        /// <summary>
        /// Gets the unique text identifier of a school class.
        /// </summary>
        public string UniqueID
        {
            get
            {
                return string.Format("SchoolClassID {0}", this.classID);
            }
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A <see cref="string"/> value.</returns>
        public override string ToString()
        {
            var result = new StringBuilder().Append(string.Format(
                                                        "Type: {0},  UniqueID: {1}",
                                                        base.ToString().Split('.')[1],
                                                        this.UniqueID));

            if (this.Teachers.Count > 0)
            {
                result = result.Append(", Teachers: ");

                foreach (var item in this.Teachers)
                {
                    result = result.Append(item.Name)
                             .Append(", ");
                }

                result.Length -= 2;
            }

            if (this.Students.Count > 0)
            {
                result = result.Append(", Students: ");

                foreach (var item in this.Students)
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
