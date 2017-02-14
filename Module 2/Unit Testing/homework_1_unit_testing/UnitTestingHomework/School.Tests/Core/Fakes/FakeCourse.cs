////-------------------------------------------------------------------------------------------------
//// <copyright file="FakeCourse.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace School.Tests.Core.Fakes
{
    using SchoolSystem.Core.Models;

    /// <summary>
    /// Fake of the <see cref="Course"/> class for testing purposes.
    /// </summary>
    public class FakeCourse : Course
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FakeCourse"/> class.
        /// </summary>
        /// <param name="courseName">Fake course's name.</param>
        public FakeCourse(string courseName) : base(courseName)
        {
        }
    }
}
