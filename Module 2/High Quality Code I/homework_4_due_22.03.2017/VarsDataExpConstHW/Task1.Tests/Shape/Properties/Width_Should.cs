//// <copyright file="Width_Should.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Tests.Shape.Properties
{
    using NUnit.Framework;
    using Task1;

    [TestFixture]
    public class Width_Should
    {
        [Test]
        [TestCase(1)]
        [TestCase(3.14)]
        [TestCase(1.618d)]
        public void SetCorrectValue_WhenPassedValidParameter(double value)
        {
            var actual = new Shape(1, 1);

            actual.Width = value;

            Assert.That(actual.Width, Is.EqualTo(value));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        [TestCase(-1001)]
        [TestCase(-1001.1001d)]
        public void Throw_WhenPassedInvalidParameter(double value)
        {
            var actual = new Shape(1, 1);

            Assert.That(() => actual.Width = value, Throws.Exception);
        }
    }
}
