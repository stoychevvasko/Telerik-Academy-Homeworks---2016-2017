////-------------------------------------------------------------------------------------------------
//// <copyright file="ICourse.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace Problem_01.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// Provides course-related functionality.
    /// </summary>
    public interface ICourse
    {
        /// <summary>
        /// Gets or sets the name of a course.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets an IList collection of IStudent-compliant objects.
        /// </summary>
        ICollection<IStudent> Students { get; set; }
    }
}
