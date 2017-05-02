namespace SchoolSystem.Tests.Models.MarkTests
{
    using NUnit.Framework;
    using SchoolSystem.Models;
    using SchoolSystem.Models.Enumerations;

    [TestFixture]
    [Category("Mark Value property")]
    public class ValueProperty_Should
    {
        [Test]
        [TestCase(2f)]
        [TestCase(4.25f)]
        [TestCase(6f)]
        public void NotThrow_WhenSetValidParameter(float validTestMarkValue)
        {
            var validSubject = Subject.Bulgarian;
            var validMark = 6f;
            var sut = new Mark(validSubject, validMark);

            Assert.That(
                () => sut.Value = validTestMarkValue,
                Throws.Nothing);
        }

        [Test]
        [TestCase(float.MinValue)]
        [TestCase(float.MaxValue)]
        [TestCase(-1f)]
        [TestCase(6.50f)]
        public void Throw_WhenSetInvalidParameter(float invalidTestMarkValue)
        {
            var validSubject = Subject.Bulgarian;
            var validMark = 6f;
            var sut = new Mark(validSubject, validMark);

            Assert.That(
                () => sut.Value = invalidTestMarkValue,
                Throws.Exception);
        }
    }
}
