namespace SchoolSystem.Tests.Models.StudentTests
{
    using NUnit.Framework;
    using SchoolSystem.Models;
    using SchoolSystem.Models.Enumerations;

    [TestFixture]
    [Category("Student LastName property")]
    public class LastNameProperty_Should
    {
        [Test]
        [TestCase("Ab")]
        [TestCase("Snow")]
        [TestCase("abcdefghijklmnopqrstuvwxyzABCDE")]
        public void NotThrow_WhenSetValidParameter(string validTestLastName)
        {
            var validFirstName = "John";
            var validLastName = "Snow";
            var validGrade = Grade.First;
            var sut = new Student(validFirstName, validLastName, validGrade);

            Assert.That(
                () => sut.FirstName = validTestLastName,
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
