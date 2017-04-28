// <copyright file="MatrixTests.cs" company="telerikacademy.com">for educational purposes only</copyright>
namespace MatrixRefactoring.Tests
{
    using System;
    using NUnit.Framework;

    /// <summary>Test logic.</summary>
    [TestFixture]
    public class MatrixTests
    {
        /// <summary>Test logic.</summary>
        [Test]
        public void Martix_WhenInvalidRows_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Matrix(-5, 2, 0));
        }

        /// <summary>Test logic.</summary>
        [Test]
        public void Martix_WhenInvalidCols_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Matrix(5, -2, 0));
        }

        /// <summary>Test logic.</summary>
        [Test]
        public void Martix_WhenInvalidStartIndexIsLess_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Matrix(5, 2, -2));
        }

        /// <summary>Test logic.</summary>
        [Test]
        public void Martix_WhenCallToStringMethod_ShouldReturnStringInExcactFormat()
        {
            Matrix matrix = new Matrix(2, 2, 0);
            string matrixToString = matrix.ToString();

            string expectedResult = "  0  0\r\n  0  0\r\n";

            Assert.AreEqual(expectedResult, matrixToString);
        }

        /// <summary>Test logic.</summary>
        [Test]
        public void Martix_WhenFillMatrix_ShouldCalculateMatrixWithExcactValues()
        {
            Matrix matrix = new Matrix(2, 2, 0);
            matrix.FillMatrix();
            string matrixToString = matrix.ToString();

            string expectedResult = "  1  4\r\n  3  2\r\n";

            Assert.AreEqual(expectedResult, matrixToString);
        }
    }
}
