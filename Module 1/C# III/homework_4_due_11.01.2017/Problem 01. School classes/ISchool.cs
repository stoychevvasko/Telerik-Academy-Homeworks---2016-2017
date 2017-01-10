////-----------------------------------------------------------------------
//// <copyright file="ISchool.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    using System.Collections.Generic;

    /// <summary>
    /// Exposes the set of classes within a school through the Classes property.
    /// </summary>
    public interface ISchool
    {
        /// <summary>
        /// Gets or sets a set of school classes.
        /// </summary>
        ICollection<SchoolClass> Classes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of a school.
        /// </summary>
        string Name
        {
            get;
            set;
        }
    }
}
