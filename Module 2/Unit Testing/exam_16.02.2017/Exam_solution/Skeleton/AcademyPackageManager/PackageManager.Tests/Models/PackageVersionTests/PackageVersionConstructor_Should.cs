namespace PackageManager.Tests.Models.PackageVersionTests
{
    using Enums;
    using NUnit.Framework;
    using PackageManager.Models;

    [TestFixture]
    public class PackageVersionConstructor_Should
    {
        [Test]
        public void SetAppropriatePassedValues_WhenConstructorCalledWithValidValues()
        {
            // Arrange
            int minor = 1,
                major = 1,
                patch = 1;

            VersionType versionType = VersionType.alpha;
            
            // Act
            var actual = new PackageVersion(minor, major, patch, versionType);
            
            // Assert
            Assert.That(actual.Minor, Is.EqualTo(minor));
            Assert.That(actual.Major, Is.EqualTo(major));
            Assert.That(actual.Patch, Is.EqualTo(patch));
            Assert.That(actual.VersionType, Is.EqualTo(versionType));
        }
    }
}
