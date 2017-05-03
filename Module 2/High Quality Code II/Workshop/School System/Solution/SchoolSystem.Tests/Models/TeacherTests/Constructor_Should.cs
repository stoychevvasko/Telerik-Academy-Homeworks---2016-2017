namespace SchoolSystem.Tests.Models.TeacherTests
{
    using NUnit.Framework;
    using SchoolSystem.Models.Enumerations;

    [TestFixture]
    [Category("Teacher constructor")]
    public class Constructor_Should
    {
        [Test]
        [TestCase()]
        public void CreateValidTeacherInstance_WhenCalledWithValidParameters()
        {
            var validFirstName = "John";
            var validLastName = "Doe";
            var validSubject = Subject.Programming;
            Teacher sut;

            Assert.That(
                () => sut = new Teacher(validFirstName, validLastName, validSubject),
                Throws.Nothing);


        }
    }
}
