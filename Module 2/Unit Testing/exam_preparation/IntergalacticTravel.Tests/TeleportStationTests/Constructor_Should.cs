namespace IntergalacticTravel.Tests.TeleportStationTests
{
    using IntergalacticTravel.Contracts;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void SetAppropriateValues_WhenNewTeleportStationIsCreatedWithValidParametersPassed()
        {
            // Arrange
            var businessOwnerStub = new Mock<IBusinessOwner>().Object;
            var galacticMapStub = new Mock<IEnumerable<IPath>>().Object;
            var locationStub = new Mock<ILocation>().Object;

            // Act
            var actual = new TeleportStation_Fake(businessOwnerStub, galacticMapStub, locationStub);

            // Assert
            Assert.That(actual.Owner, Is.EqualTo(businessOwnerStub));
            Assert.That(actual.GalacticMap, Is.EqualTo(galacticMapStub));
            Assert.That(actual.Location, Is.EqualTo(locationStub));
        }
    }
}
