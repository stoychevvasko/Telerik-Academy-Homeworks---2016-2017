namespace PackageManager.Tests.Models.PackageVersionTests
{
    using Enums;
    using NUnit.Framework;
    using PackageManager.Models;

    [TestFixture]
    public class PackageVersionSetPatch_Should
    {
        [Test]
        public void SetProperPatch_WhenValidPatchIsPassedViaPublicConstructor()
        {
            // Arrange 
            int minor = 1,
                major = 1,
                patch = 1;

            var versionType = VersionType.alpha;

            // Act
            var actual = new PackageVersion(minor, major, patch, versionType);

            // Assert
            Assert.That(actual.Patch, Is.EqualTo(patch));
        }

        [Test]
        public void Throw_WhenInvalidPatchIsPassedViaPublicConstructor()
        {
            // Arrange 
            int minor = 1,
                major = 1,
                patch = -1;

            var versionType = VersionType.alpha;

            // Act & Assert

            Assert.That(() => new PackageVersion(minor, major, patch, versionType),
                Throws.ArgumentException);
        }
    }
}
