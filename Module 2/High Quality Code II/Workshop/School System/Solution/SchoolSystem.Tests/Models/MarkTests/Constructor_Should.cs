namespace SchoolSystem.Tests.Models.MarkTests
{
    using NUnit.Framework;
    using SchoolSystem.Models;
    using SchoolSystem.Models.Enumerations;

    [TestFixture]
    [Category("Mark constructor")]
    public class Constructor_Should
    {
        [Test]
        [TestCase(2f)]
        [TestCase(4.25f)]
        [TestCase(6f)]
        public void CreateValidMarkInstance_WhenCalledWithValidParameters(float caseValue)
        {
            var validValue = caseValue;
            var validSubject = Subject.Bulgarian;

            Mark sut;

            Assert.That(
                () => sut = new Mark(validSubject, validValue),
                Throws.Nothing);
        }

        [Test]
        [TestCase(1f)]
        [TestCase(-2.35f)]
        [TestCase(8f)]
        public void Throw_WhenCalledWithInvalidMarkValue(float caseValue)
        {
            var invalidMarkValue = caseValue;
            var validSubject = Subject.Bulgarian;

            Mark sut;

            Assert.That(
                () => sut = new Mark(validSubject, invalidMarkValue),
                Throws.Exception);
        }

        [Test]
        [TestCase((Subject)int.MaxValue)]
        [TestCase((Subject)int.MinValue)]
        [TestCase((Subject)(-1))]
        public void Throw_WhenCalledWithInvalidSubject(Subject caseValue)
        {
            var invalidSubject = caseValue;
            var validMarkValue = 5f;

            Mark sut;

            Assert.That(
                () => sut = new Mark(invalidSubject, validMarkValue),
                Throws.Exception);
        }
    }
}
