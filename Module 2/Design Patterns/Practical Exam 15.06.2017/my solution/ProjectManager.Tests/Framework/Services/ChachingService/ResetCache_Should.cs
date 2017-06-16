using System;
using System.Threading;
using NUnit.Framework;
using ProjectManager.Framework.Services;

namespace ProjectManager.Tests.Framework.Services.ChachingService
{
    [TestFixture]    
    public class ResetCache_Should
    {
        private static readonly TimeSpan defaultDuration = new TimeSpan(100);
        private static readonly TimeSpan shortDuration = new TimeSpan(50);
        private static readonly TimeSpan longDuration = new TimeSpan(150);

        [Test]
        [Category("ChachingService.ClassTests")]
        public void ThrowsNothing_WhenCalled()
        {
            // Arrange
            TimeSpan durationParameterValue = defaultDuration;
            var sut = new CachingService(durationParameterValue);

            // Act
            Thread.Sleep(longDuration);            

            // Assert
            Assert.That(
                () => sut.ResetCache(),
                Throws.Nothing);
        }
    }
}
