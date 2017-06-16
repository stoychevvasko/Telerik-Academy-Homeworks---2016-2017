using System;
using NUnit.Framework;
using ProjectManager.Framework.Services;

namespace ProjectManager.Tests.Framework.Services.ChachingService
{
    [TestFixture]    
    public class AddCacheValue_Should
    {
        private static readonly TimeSpan defaultDuration = new TimeSpan(100);
        private static readonly string className = "testClassNameValue";
        private static readonly string methodName = "testMethodNameValue";
        private static readonly object objectValue = new object();

        [Test]
        [Category("ChachingService.ClassTests")]
        public void NotThrow_WhenPassedValidArguments()
        {
            // Arrange
            TimeSpan durationParameterValue = defaultDuration;
            var sut = new CachingService(durationParameterValue);

            // Act,
            // Assert
            Assert.That(
                () => sut.AddCacheValue(className, methodName, objectValue),
                Throws.Nothing);
        }        
    }
}
