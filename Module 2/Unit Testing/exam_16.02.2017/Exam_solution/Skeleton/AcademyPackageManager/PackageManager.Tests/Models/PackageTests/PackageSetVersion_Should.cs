namespace PackageManager.Tests.Models.PackageTests
{
    using Moq;
    using NUnit.Framework;
    using PackageManager.Models;
    using PackageManager.Models.Contracts;
    using System.Collections.Generic;

    [TestFixture]
    public class PackageSetVersion_Should
    {
        [Test]
        public void SetProperVersion_WhenValidVersionIsPassedViaPublicSetterProperty()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);

            // Act
            actual.Version = versionStub.Object;

            // Assert
            Assert.That(actual.Version, Is.EqualTo(versionStub.Object));
        }

        [Test]
        public void ThrowNothing_WhenNullVersionIsPassedViaPublicSetterProperty()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);

            // Act & Assert
            Assert.That(() => actual.Version = null, Throws.Nothing);
        }
    }
}
