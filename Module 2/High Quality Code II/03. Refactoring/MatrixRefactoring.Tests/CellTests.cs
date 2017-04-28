// <copyright file="CellTests.cs" company="telerikacademy.com">for educational purposes only</copyright>
namespace MatrixRefactoring.Tests
{
    using System;
    using NUnit.Framework;

    /// <summary>Custom tests.</summary>
    [TestFixture]
    public class CellTests
    {
        /// <summary>Test logic.</summary>
        [Test]
        public void Cell_WhenCreatedWithValidParameters_ShouldCreateNewCell()
        {
            Cell cell = new Cell(1, 1);
        
            var expectedX = 1;
            var expectedY = 1;
        
            Assert.AreEqual(expectedX, cell.X);
            Assert.AreEqual(expectedY, cell.Y);
        }

        /// <summary>Test logic.</summary>
        [Test]
        public void Cell_WhenSumTwoCellsWithInvaleidFirstCell_ShouldThrowArgumentNullException()
        {
            Cell secondCell = new Cell(1, 1);

            Assert.Throws<ArgumentNullException>(() => new Cell((null + secondCell).X, (null + secondCell).Y));
        }

        /// <summary>Test logic.</summary>
        [Test]
        public void Cell_WhenSumTwoCellsWithInvaleidSecondCell_ShouldThrowArgumentNullException()
        {
            Cell firstCell = new Cell(1, 1);

            Assert.Throws<ArgumentNullException>(() => new Cell((firstCell + null).X, (firstCell + null).Y));
        }

        /// <summary>Test logic.</summary>
        public void Cell_WhenSumTwoCellsWithValeidCells_ShouldSumTheirXAndYCoordinates()
        {
            Cell firstCell = new Cell(1, 1);
            Cell secondCell = new Cell(2, 2);
            Cell result = firstCell + secondCell;

            int expectedX = 3;
            int expectedY = 3;

            Assert.AreEqual(expectedX, result.X);
            Assert.AreEqual(expectedY, result.Y);
        }
    }
}
