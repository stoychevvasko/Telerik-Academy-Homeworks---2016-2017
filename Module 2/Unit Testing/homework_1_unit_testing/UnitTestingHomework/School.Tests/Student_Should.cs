////-------------------------------------------------------------------------------------------------
//// <copyright file="Student_Should.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace School.Tests
{
    using System;    
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    /// <summary>
    /// Contains testing functionality for the <see cref="Student"/> class.
    /// </summary>
    [TestClass]
    public class Student_Should
    {
        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowArgumentNullException_WhenSetNullStudentName()
        {
            // Arrange
            var stu = new Student("John Doe", 10000);

            // Act & Assert
            stu.Name = null;
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowArgumentException_WhenSetStringEmptyStudentName()
        {
            // Arrange
            var stu = new Student("John Doe", 10000);

            // Act & Assert
            stu.Name = string.Empty;
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        public void SetCorrectName_WhenSetValidStudentName()
        {
            // Arrange
            var stu = new Student("John Doe", 10000);

            // Act
            stu.Name = "Valid";

            // Assert
            Assert.AreEqual(stu.Name, "Valid");
        }
    }
}
