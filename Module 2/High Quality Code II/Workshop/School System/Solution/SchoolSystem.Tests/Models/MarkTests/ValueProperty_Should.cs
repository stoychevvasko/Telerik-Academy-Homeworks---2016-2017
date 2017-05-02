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
        public void NotThrow_WhenSetValidParameter(float caseValue)
        {
            var sut = new Mark(Subject.Bulgarian, 6f);

            Assert.That(
                () => sut.Value = caseValue,
                Throws.Nothing);
        }

        [Test]
        [TestCase(float.MinValue)]
        [TestCase(float.MaxValue)]
        [TestCase(-1f)]
        [TestCase(6.50f)]
        public void Throws_WhenSetInvalidParameter(float caseValue)
        {
            var sut = new Mark(Subject.Bulgarian, 6f);

            Assert.That(
                () => sut.Value = caseValue,
                Throws.Exception);
        }
    }
}
