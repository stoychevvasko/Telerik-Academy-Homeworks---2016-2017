////-------------------------------------------------------------------------------------------------
//// <copyright file="FakeStudent.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace School.Tests.Core.Fakes
{
    using SchoolSystem.Core.Models;

    /// <summary>
    /// Fake of the <see cref="Student"/> class for testing purposes.
    /// </summary>
    public class FakeStudent : Student
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FakeStudent"/> class.
        /// </summary>
        /// <param name="name">Fake student's name.</param>
        /// <param name="id">Fake student's id.</param>
        public FakeStudent(string name, int id) : base(name, id)
        {
        }
    }
}
