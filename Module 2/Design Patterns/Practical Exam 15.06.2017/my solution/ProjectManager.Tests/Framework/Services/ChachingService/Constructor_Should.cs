using System;
using NUnit.Framework;
using global::ProjectManager.Framework.Services;

namespace ProjectManager.Tests.Framework.Services.ChachingService
{
    [TestFixture]    
    public class Constructor_Should
    {
        [Test]
        [Category("ChachingService.ClassTests")]
        public void NotThrow_WhenCalledWithValidParameter()
        {
            // Arrange
            TimeSpan durationParameterValue = new TimeSpan(1000);

            // Act
            CachingService sut;

            // Assert
            Assert.That(
                () => sut = new CachingService(durationParameterValue),
                Throws.Nothing);
        }

        [Test]
        [Category("ChachingService.ClassTests")]
        public void Throw_WhenCalledWithInvalidParameter()
        {
            // Arrange
            TimeSpan durationParameterValue = TimeSpan.Zero.Subtract(new TimeSpan(1000));

            // Act
            CachingService sut;

            // Assert
            Assert.That(
                () => sut = new CachingService(durationParameterValue),
                Throws.InstanceOf<Exception>());
        }
    }
}
