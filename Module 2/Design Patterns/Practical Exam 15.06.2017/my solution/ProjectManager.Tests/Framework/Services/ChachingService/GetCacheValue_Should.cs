using System;
using NUnit.Framework;
using ProjectManager.Framework.Services;

namespace ProjectManager.Tests.Framework.Services.ChachingService
{
    [TestFixture]    
    public class GetCacheValue_Should
    {
        private static readonly TimeSpan defaultDuration = new TimeSpan(100);
        private static readonly string className = "testClassNameValue";
        private static readonly string methodName = "testMethodNameValue";
        private static readonly object objectValue = new object();

        [Test]
        [Category("ChachingService.ClassTests")]
        public void NotThrow_WhenCalledWithValidParameters()
        {
            // Arrange
            TimeSpan durationParameterValue = defaultDuration;
            var sut = new CachingService(durationParameterValue);
            sut.AddCacheValue(className, methodName, objectValue);

            // Act,
            // Assert
            Assert.That(
                () => sut.GetCacheValue(className, methodName),
                Throws.Nothing);
        }

        [Test]
        [Category("ChachingService.ClassTests")]
        public void Throw_WhenCalledWithInvalidParameterClassName()
        {
            // Arrange
            TimeSpan durationParameterValue = defaultDuration;
            var sut = new CachingService(durationParameterValue);
            sut.AddCacheValue(className, methodName, objectValue);

            // Act,
            // Assert
            Assert.That(
                () => sut.GetCacheValue(className + "wrong", methodName),
                Throws.Exception);
        }

        [Test]
        [Category("ChachingService.ClassTests")]
        public void Throw_WhenCalledWithInvalidParameterMethodName()
        {
            // Arrange
            TimeSpan durationParameterValue = defaultDuration;
            var sut = new CachingService(durationParameterValue);
            sut.AddCacheValue(className, methodName, objectValue);

            // Act,
            // Assert
            Assert.That(
                () => sut.GetCacheValue(className, methodName + "wrong"),
                Throws.Exception);
        }
    }
}
