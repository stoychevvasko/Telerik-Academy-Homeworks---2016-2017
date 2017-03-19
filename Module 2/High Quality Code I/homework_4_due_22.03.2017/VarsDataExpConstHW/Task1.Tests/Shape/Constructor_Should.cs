//// <copyright file="Constructor_Should.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Tests.Shape
{
    using NUnit.Framework;
    using Task1;

    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        [TestCase(1, 1)]
        [TestCase(3.14, 1337)]
        public void ReturnValidShape_WhenCalledWithValidParameters(double height, double width)
        {
            var actual = new Shape(height, width);

            Assert.That(actual, Is.InstanceOf<Shape>());
            Assert.That(actual.Height, Is.EqualTo(height));
            Assert.That(actual.Width, Is.EqualTo(width));
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(1, -1)]
        [TestCase(0, 1)]
        [TestCase(-1, 1)]
        [TestCase(0, 0)]
        [TestCase(-1, -1)]
        public void Throw_WhenCalledWithInvalidParameters(double height, double width)
        {
            Assert.That(() => new Shape(height, width), Throws.Exception);
        }
    }
}
