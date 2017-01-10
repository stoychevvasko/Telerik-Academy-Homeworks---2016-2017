////-----------------------------------------------------------------------
//// <copyright file="ISchoolClass.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    using System.Collections.Generic;

    /// <summary>
    /// Provides school-class-specific collections - teachers and students, and a class-specific identifier.
    /// </summary>
    public interface ISchoolClass
    {
        /// <summary>
        /// Gets or sets the set of teachers assigned to a class.
        /// </summary>
        ICollection<Teacher> Teachers
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the set of students assigned to a class.
        /// </summary>
        ICollection<Student> Students
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the unique text identifier of a school class.
        /// </summary>
        string UniqueID
        {
            get;
        }
    }
}
