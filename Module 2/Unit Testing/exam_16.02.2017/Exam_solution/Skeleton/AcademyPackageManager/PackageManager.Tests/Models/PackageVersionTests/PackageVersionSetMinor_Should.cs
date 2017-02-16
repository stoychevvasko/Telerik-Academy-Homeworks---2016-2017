namespace PackageManager.Tests.Models.PackageVersionTests
{
    using Enums;
    using NUnit.Framework;
    using PackageManager.Models;

    [TestFixture]
    public class PackageVersionSetMinor_Should
    {
        [Test]
        public void SetProperMinor_WhenValidMinorIsPassedViaPublicConstructor()
        {
            // Arrange 
            int minor = 1,
                major = 1,
                patch = 1;

            var versionType = VersionType.alpha;

            // Act
            var actual = new PackageVersion(minor, major, patch, versionType);

            // Assert
            Assert.That(actual.Minor, Is.EqualTo(minor));
        }

        [Test]
        public void Throw_WhenInvalidMinorIsPassedViaPublicConstructor()
        {
            // Arrange 
            int minor = -1,
                major = -1,
                patch = 1;

            var versionType = VersionType.alpha;

            // Act & Assert

            Assert.That(() => new PackageVersion(minor, major, patch, versionType),
                Throws.ArgumentException);
        }
    }
}
