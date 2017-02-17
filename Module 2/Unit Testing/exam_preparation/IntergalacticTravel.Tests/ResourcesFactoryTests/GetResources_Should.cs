namespace IntergalacticTravel.Tests.ResourcesFactoryTests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class GetResources_Should
    {
        [Test]
        [TestCase("create resources gold(20) silver(30) bronze(40)")]
        [TestCase("create resources gold(20) bronze(40) silver(30)")]
        [TestCase("create resources silver(30) bronze(40) gold(20)")]
        [TestCase("create resources silver(30) gold(20) bronze(40)")]
        [TestCase("create resources bronze(40) gold(20) silver(30)")]
        [TestCase("create resources bronze(40) silver(30) gold(20)")]
        public void ReturnProperNewResourcesObject_WhenCorrectPropertiesPassed(string command)
        {
            // Arrange
            var factory = new ResourcesFactory();

            // Act
            var actual = factory.GetResources(command);

            // Assert
            Assert.That(actual, Is.InstanceOf<Resources>());
            Assert.That(actual.GoldCoins, Is.EqualTo(20));
            Assert.That(actual.SilverCoins, Is.EqualTo(30));
            Assert.That(actual.BronzeCoins, Is.EqualTo(40));
        }

        [Test]
        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        [TestCase("absolutelyRandomStringThatMustNotBeAValidCommand")]
        public void ThrowInvalidOperationException_WhenInvalidCommandPassedAsParameter(string command)
        {
            // Arrange
            var factory = new ResourcesFactory();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => factory.GetResources(command));
        }

        [Test]
        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void ThrowOverflowException_WhenCalledWithCorrectFormatButTooLong(string command)
        {
            // Arrange
            var factory = new ResourcesFactory();

            // Act & Assert
            Assert.Throws<OverflowException>(() => factory.GetResources(command));
        }
    }
}
