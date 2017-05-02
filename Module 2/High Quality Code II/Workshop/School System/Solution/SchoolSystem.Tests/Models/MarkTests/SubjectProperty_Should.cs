namespace SchoolSystem.Tests.Models.MarkTests
{
    using NUnit.Framework;
    using SchoolSystem.Models;
    using SchoolSystem.Models.Enumerations;

    [TestFixture]
    [Category("Mark Subject property")]
    public class SubjectProperty_Should
    {
        [Test]
        [TestCase(Subject.Bulgarian)]
        [TestCase(Subject.Programming)]
        [TestCase(Subject.Math)]
        [TestCase(Subject.English)]
        public void NotThrow_WhenSetValidParameter(Subject caseValue)
        {
            var sut = new Mark(Subject.Bulgarian, 6f);

            Assert.That(
                () => sut.Subject = caseValue,
                Throws.Nothing);
        }

        [Test]
        [TestCase((Subject)int.MaxValue)]
        [TestCase((Subject)int.MinValue)]
        [TestCase((Subject)(-1))]
        public void Throws_WhenSetInvalidParameter(Subject caseValue)
        {
            var sut = new Mark(Subject.Bulgarian, 6f);

            Assert.That(
                () => sut.Subject = caseValue,
                Throws.Exception);
        }
    }
}
