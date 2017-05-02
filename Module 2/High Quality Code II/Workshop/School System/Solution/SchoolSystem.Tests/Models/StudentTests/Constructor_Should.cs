namespace SchoolSystem.Tests.Models.StudentTests
{
    using NUnit.Framework;
    using SchoolSystem.Models;
    using SchoolSystem.Models.Enumerations;

    [TestFixture]
    [Category("Student constructor")]
    public class Constructor_Should
    {
        [Test]
        [TestCase("John")]
        [TestCase("Jane")]
        public void CreateValidStudentInstance_WhenCalledWithValidParameters(string validTestFirstName)
        {
            var validFirstName = validTestFirstName;
            var validLastName = "Doe";
            var validGrade = Grade.Eighth;

            Student sut;

            Assert.That(
                () => sut = new Student(validFirstName, validLastName, validGrade),
                Throws.Nothing);
        }

        [Test]
        [TestCase("")]
        [TestCase("a")]
        [TestCase("abcdefghijklmnopqrstuvwxyzABCDEF")]
        [TestCase("12345")]
        public void Throw_WhenCalledWithInvalidFirstName(string testFirstName)
        {
            var invalidFirstName = testFirstName;
            var validLastName = "Doe";
            var validGrade = Grade.Eighth;

            Student sut;

            Assert.That(
                () => sut = new Student(invalidFirstName, validLastName, validGrade),
                Throws.Exception);
        }

        [Test]
        [TestCase("")]
        [TestCase("a")]
        [TestCase("abcdefghijklmnopqrstuvwxyzABCDEF")]
        [TestCase("12345")]
        public void Throw_WhenCalledWithInvalidLastName(string testLastName)
        {
            var validFirstName = "John";
            var invalidLastName = testLastName;
            var validGrade = Grade.Eighth;

            Student sut;

            Assert.That(
                () => sut = new Student(validFirstName, invalidLastName, validGrade),
                Throws.Exception);
        }

        [Test]
        [TestCase((Grade)int.MaxValue)]
        [TestCase((Grade)int.MinValue)]
        [TestCase((Grade)(-1))]
        public void Throw_WhenCalledWithInvalidGrade(Grade testGrade)
        {
            var validFirstName = "John";
            var validLastName = "Snow";
            var invalidGrade = testGrade;

            Student sut;

            Assert.That(
                () => sut = new Student(validFirstName, validLastName, invalidGrade),
                Throws.Exception);
        }
    }
}
