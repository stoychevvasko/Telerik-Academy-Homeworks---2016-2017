namespace SchoolSystem.Tests.Models.StudentTests
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using SchoolSystem.Models;
    using SchoolSystem.Models.Enumerations;

    [TestFixture]
    [Category("Student ListMarks method")]
    public class ListMarksMethod_Should
    {
        [Test]
        public void NotThrow_WhenCalled()
        {
            var validFirstName = "John";
            var validLastName = "Snow";
            var validGrade = Grade.First;
            IList<Mark> validTestMarks = new List<Mark>();
            validTestMarks.Add(new Mark(Subject.English, 6f));
            var sut = new Student(validFirstName, validLastName, validGrade);

            Assert.That(
                () => sut.ListMarks(),
                Throws.Nothing);
        }

        [Test]
        public void ReturnString_WhenCalledWithMarksPresent()
        {
            var validFirstName = "John";
            var validLastName = "Snow";
            var validGrade = Grade.First;
            IList<Mark> validTestMarks = new List<Mark>();
            validTestMarks.Add(new Mark(Subject.English, 6f));
            var sut = new Student(validFirstName, validLastName, validGrade);

            Assert.That(
                () => sut.ListMarks(),
                Is.InstanceOf<string>());
        }
    }
}
