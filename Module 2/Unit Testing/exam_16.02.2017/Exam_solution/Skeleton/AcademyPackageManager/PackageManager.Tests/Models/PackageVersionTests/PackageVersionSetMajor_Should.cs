namespace PackageManager.Tests.Models.PackageVersionTests
{
    using Enums;
    using NUnit.Framework;
    using PackageManager.Models;

    [TestFixture]
    public class PackageVersionSetMajor_Should
    {
        [Test]
        public void SetProperMajor_WhenValidMajorIsPassedViaPublicConstructor()
        {
            // Arrange 
            int minor = 1,
                major = 1,
                patch = 1;

            var versionType = VersionType.alpha;
            
            // Act
            var actual = new PackageVersion(minor, major, patch, versionType);

            // Assert
            Assert.That(actual.Major, Is.EqualTo(major));
        }

        [Test]
        public void Throw_WhenInvalidMajorIsPassedViaPublicConstructor()
        {
            // Arrange 
            int minor = 1,
                major = -1,
                patch = 1;

            var versionType = VersionType.alpha;

            // Act & Assert
                        
            Assert.That(() => new PackageVersion(minor, major, patch, versionType), 
                Throws.ArgumentException);
        }
    }
}
