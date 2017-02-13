////-------------------------------------------------------------------------------------------------
//// <copyright file="Student_Should.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace Problem_01.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_WhenSetInvalidStudentIDTooLow()
        {
            // Arrange
            var stu = new Student("John Doe", 10000);

            // Act & Assert
            stu.UniqueNumber = 1;
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_WhenSetInvalidStudentIDTooHigh()
        {
            // Arrange
            var stu = new Student("John Doe", 10000);

            // Act & Assert
            stu.UniqueNumber = 100000;
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        public void SetCorrectID_WhenSetValidStudentIDWithinAllowedRange()
        {
            // Arrange
            var stu = new Student("John Doe", 10000);

            // Act
            stu.UniqueNumber = 10500;

            // Assert
            Assert.AreEqual(stu.UniqueNumber, 10500);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        public void GetCorrectName_WhenGetterUsed()
        {
            // Arrange
            var expectedName = "John Doe";
            var stu = new Student(expectedName, 10000);

            // Act
            var actualName = stu.Name;

            // Assert
            Assert.AreEqual(expectedName, actualName);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        public void GetCorrectID_WhenGetterUsed()
        {
            // Arrange
            var expectedID = 10000;
            var stu = new Student("John Doe", expectedID);

            // Act
            var actualID = stu.UniqueNumber;

            // Assert
            Assert.AreEqual(expectedID, actualID);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_WhenSetInvalidStudentIDNegative()
        {
            // Arrange            
            var stu = new Student("John Doe", 10000);

            // Act & Assert
            stu.UniqueNumber = -200;
        }
    }
}
