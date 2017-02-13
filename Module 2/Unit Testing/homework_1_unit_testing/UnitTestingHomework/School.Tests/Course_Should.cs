////-------------------------------------------------------------------------------------------------
//// <copyright file="Course_Should.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace Problem_01.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    /// <summary>
    /// Contains testing functionality for the <see cref="Course"/> class.
    /// </summary>
    [TestClass]
    public class Course_Should
    {
        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowArgumentNullException_WhenSetInvalidCourseNameNull()
        {
            // Arrange
            var testCourse = new Course("Knitting");

            // Act & Assert
            testCourse.Name = null;
        }
    }
}
