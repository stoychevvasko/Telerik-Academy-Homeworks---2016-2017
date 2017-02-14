////-------------------------------------------------------------------------------------------------
//// <copyright file="IStudent.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace Problem_01.Contracts
{
    /// <summary>
    /// Provides student-related functionality.
    /// </summary>
    public interface IStudent
    {
        /// <summary>
        /// Gets or sets a student's name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets a student's unique number.
        /// </summary>
        int UniqueNumber { get; set; }
    }
}
