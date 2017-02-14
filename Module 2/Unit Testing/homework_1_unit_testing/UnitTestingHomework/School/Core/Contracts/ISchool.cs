////-------------------------------------------------------------------------------------------------
//// <copyright file="ISchool.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace SchoolSystem.Core.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// Offers school-related functionality.
    /// </summary>
    public interface ISchool
    {
        /// <summary>
        /// Add a new student to the school.
        /// </summary>
        /// <param name="student">Student to add.</param>
        void AddStudent(IStudent student);

        /// <summary>
        /// Remove a student from school by their id number.
        /// </summary>
        /// <param name="studentId">Unique student identifier.</param>
        void RemoveStudent(int studentId);

        /// <summary>
        /// Return all existing students from the school.
        /// </summary>
        /// <returns>A generic collection of all students.</returns>
        ICollection<IStudent> GetAllStudents();
    }
}
