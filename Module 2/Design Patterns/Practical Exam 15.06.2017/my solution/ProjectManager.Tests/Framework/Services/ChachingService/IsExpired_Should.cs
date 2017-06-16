using System;
using System.Threading;
using Moq;
using NUnit.Framework;
using ProjectManager.Framework.Services;

namespace ProjectManager.Tests.Framework.Services.ChachingService
{
    [TestFixture]    
    public class IsExpired_Should
    {
        private static readonly TimeSpan defaultDuration = new TimeSpan(100);
        private static readonly TimeSpan shortDuration = new TimeSpan(50);
        private static readonly TimeSpan longDuration = new TimeSpan(1500);

        [Test]
        [Category("ChachingService.ClassTests")]
        public void ReturnTrue_WhenCalledTooLate()
        {
            // Arrange
            TimeSpan durationParameterValue = defaultDuration;
            var sut = new CachingService(durationParameterValue);

            // Act
            Thread.Sleep(longDuration);

            // Assert
            Assert.That(
                () => sut.IsExpired,
                Is.True);
        }

        [Test]
        [Category("ChachingService.ClassTests")]
        public void ReturnFalse_WhenCalledTooEarly()
        {
            // Arrange
            TimeSpan durationParameterValue = longDuration;
            var sut = new CachingService(durationParameterValue);

            // Act,
            // Assert
            Assert.That(
                () => sut.IsExpired,
                Is.False);
        }
    }
}
