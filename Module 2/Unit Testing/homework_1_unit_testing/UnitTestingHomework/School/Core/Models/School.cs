////-------------------------------------------------------------------------------------------------
//// <copyright file="School.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
////  Task 1. Students and courses
////-------------------------------------------------------------------------------------------------
////  * Write three classes: `Student`, `Course` and `School`.
////      * Students should have name and unique number(inside the entire `School`).
////          * Name can not be empty and the unique number is between 10000 and 99999.
////      * Each course contains a set of students.
////      *   Students in a course should be less than 30 and can join and leave courses.
////  *   Write VSTT tests
////    * Use 2 class library projects in Visual Studio: `School.csproj` and `School.Tests.csproj`
////  * Execute the tests using Visual Studio and check the code coverage.Ensure it is at least 90%.
namespace SchoolSystem.Core.Models
{
    using System;
    using System.Collections.Generic;
    using Contracts;

    /// <summary>
    /// Represents a school.
    /// </summary>
    public class School : ISchool
    {
        /// <summary>
        /// Holds a unique student id provider for the school.
        /// </summary>
        private readonly IIdProvider idProvider;

        /// <summary>
        /// Holds a list of all students within the school.
        /// </summary>
        private List<Student> students;

        /// <summary>
        /// Initializes a new instance of the <see cref="School"/> class.
        /// </summary>
        /// <param name="idProvider">Unique student id provider.</param>
        public School(IIdProvider idProvider)
        {
            this.idProvider = idProvider;
            this.students = new List<Student>();
        }

        /// <summary>
        /// Adds a student to the school.
        /// </summary>
        /// <param name="student">Student parameter.</param>
        public void AddStudent(IStudent student)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a student from the school by their unique id.
        /// </summary>
        /// <param name="studentId">Unique id of student for removal.</param>
        public void RemoveStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a collection of all students within the school.
        /// </summary>
        /// <returns>A collection of students.</returns>
        public ICollection<IStudent> GetAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}