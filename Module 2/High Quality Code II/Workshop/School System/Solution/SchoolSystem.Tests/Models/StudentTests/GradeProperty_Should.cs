namespace SchoolSystem.Tests.Models.StudentTests
{
    using NUnit.Framework;
    using SchoolSystem.Models;
    using SchoolSystem.Models.Enumerations;

    [TestFixture]
    [Category("Student Grade property")]
    public class GradeProperty_Should
    {
        [Test]
        [TestCase(Grade.Fifth)]
        [TestCase(Grade.Eighth)]
        [TestCase(Grade.Eleventh)]
        public void NotThrow_WhenSetValidParameter(Grade validTestGrade)
        {
            var validFirstName = "John";
            var validLastName = "Snow";
            var validGrade = Grade.First;
            var sut = new Student(validFirstName, validLastName, validGrade);

            Assert.That(
                () => sut.Grade = validTestGrade,
                Throws.Nothing);
        }

        [Test]
        [TestCase((Grade)int.MaxValue)]
        [TestCase((Grade)int.MinValue)]
        [TestCase((Grade)(-1))]
        public void Throw_WhenSetInvalidParameter(Grade invalidTestGrade)
        {
            var validFirstName = "John";
            var validLastName = "Doe";
            var validGrade = Grade.First;
            var sut = new Student(validFirstName, validLastName, validGrade);

            Assert.That(
                () => sut.Grade = invalidTestGrade,
                Throws.Exception);
        }
    }
}
