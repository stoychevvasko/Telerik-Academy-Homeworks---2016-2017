////-----------------------------------------------------------------------
//// <copyright file="ITeacher.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    using System.Collections.Generic;

    /// <summary>
    /// Reveals, expands or limits a teacher's set of disciplines taught.
    /// </summary>
    public interface ITeacher
    {
        /// <summary>
        /// Gets or sets the set of disciplines taught by a teacher.
        /// </summary>
        ICollection<Discipline> Disciplines
        {
            get;
            set;
        }  
    }
}
