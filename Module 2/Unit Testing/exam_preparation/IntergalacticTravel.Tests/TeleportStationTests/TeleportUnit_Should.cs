namespace IntergalacticTravel.Tests.TeleportStationTests
{
    using Contracts;
    using Moq;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class TeleportUnit_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenCalledWithUnitToTeleportParameterNull()
        {
            // Arrange
            var businessOwnerStub = new Mock<IBusinessOwner>().Object;
            var galacticMapStub = new Mock<IEnumerable<IPath>>().Object;
            var locationStub = new Mock<ILocation>().Object;
            var actual = new TeleportStation(businessOwnerStub, galacticMapStub, locationStub);

            // Act
            var exception = Assert.Throws<ArgumentNullException>(() => actual.TeleportUnit(null, locationStub));

            // Assert
            Assert.That(() => actual.TeleportUnit(null, locationStub), Throws.ArgumentNullException);
            StringAssert.Contains("unitToTeleport", exception.Message);
        }
    }
}
