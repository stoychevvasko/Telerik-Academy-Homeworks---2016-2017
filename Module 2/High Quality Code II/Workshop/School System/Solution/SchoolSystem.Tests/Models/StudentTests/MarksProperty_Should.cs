namespace SchoolSystem.Tests.Models.StudentTests
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using SchoolSystem.Models;
    using SchoolSystem.Models.Enumerations;

    [TestFixture]
    [Category("Student Marks property")]
    public class MarksProperty_Should
    {
        [Test]
        public void NotThrow_WhenSetValidParameter()
        {
            var validFirstName = "John";
            var validLastName = "Snow";
            var validGrade = Grade.First;
            IList<Mark> validTestMarks = new List<Mark>();
            var sut = new Student(validFirstName, validLastName, validGrade);

            Assert.That(
                () => sut.Marks = validTestMarks,
                Throws.Nothing);
        }

        [Test]        
        public void Throw_WhenSetInvalidParameter()
        {
            var validFirstName = "John";
            var validLastName = "Snow";
            var validGrade = Grade.First;
            IList<Mark> validTestMarks = new List<Mark>();
            var sut = new Student(validFirstName, validLastName, validGrade);

            Assert.That(
                () => sut.Marks = null,
                Throws.Exception);
        }
    }
}
