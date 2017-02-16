namespace PackageManager.Tests.Models.PackageVersionTests
{
    using Enums;
    using NUnit.Framework;
    using PackageManager.Models;

    [TestFixture]
    public class PackageVersionSetVersionType_Should
    {
        [Test]
        public void SetProperVersionType_WhenValidVersionTypeIsPassedViaPublicConstructor()
        {
            // Arrange 
            int minor = 1,
                major = 1,
                patch = 1;

            var versionType = VersionType.alpha;

            // Act
            var actual = new PackageVersion(minor, major, patch, versionType);

            // Assert
            Assert.That(actual.VersionType, Is.EqualTo(versionType));
        }

        [Test]
        public void Throw_WhenInvalidVersionTypeIsPassedViaPublicConstructor()
        {
            // Arrange 
            int minor = 1,
                major = 1,
                patch = -1;

            VersionType invalidVersionType = (VersionType)10000;

            // Act & Assert

            Assert.That(() => new PackageVersion(minor, major, patch, invalidVersionType),
                Throws.ArgumentException);
        }
    }
}
