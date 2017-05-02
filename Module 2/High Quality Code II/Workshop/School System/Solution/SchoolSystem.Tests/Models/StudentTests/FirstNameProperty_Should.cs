namespace SchoolSystem.Tests.Models.StudentTests
{
    using NUnit.Framework;
    using SchoolSystem.Models;
    using SchoolSystem.Models.Enumerations;

    [TestFixture]
    [Category("Student FirstName property")]
    public class FirstNameProperty_Should
    {
        [Test]
        [TestCase("Ab")]
        [TestCase("John")]
        [TestCase("abcdefghijklmnopqrstuvwxyzABCDE")]
        public void NotThrow_WhenSetValidParameter(string validTestFirstName)
        {
            var validLastName = "Snow";
            var sut = new Student(validTestFirstName, validLastName, Grade.First);

            Assert.That(
                () => sut.FirstName = validTestFirstName,
                Throws.Nothing);
        }

        [Test]
        [TestCase("")]
        [TestCase("a")]
        [TestCase("abcdefghijklmnopqrstuvwxyzABCDEF")]
        [TestCase("12345")]
        public void Throw_WhenSetInvalidParameter(string invalidTestFirstName)
        {
            var validFirstName = "John";
            var validLastName = "Doe";
            var validGrade = Grade.First;
            var sut = new Student(validFirstName, validLastName, validGrade);

            Assert.That(
                () => sut.FirstName = invalidTestFirstName,
                Throws.Exception);
        }
    }
}
