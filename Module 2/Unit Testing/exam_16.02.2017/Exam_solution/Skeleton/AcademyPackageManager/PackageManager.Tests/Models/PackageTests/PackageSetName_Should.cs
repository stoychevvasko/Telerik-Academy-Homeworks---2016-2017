namespace PackageManager.Tests.Models.PackageTests
{
    using Moq;
    using NUnit.Framework;
    using PackageManager.Models;
    using PackageManager.Models.Contracts;
    using System.Collections.Generic;

    [TestFixture]
    public class PackageSetName_Should
    {
        [Test]
        public void SetProperName_WhenValidNameIsPassedViaPublicConstructor()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();

            // Act
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);

            // Assert
            Assert.That(actual.Name, Is.EqualTo(name));
        }

        [Test]
        public void Throw_WhenInvalidNameIsPassedViaPublicConstructor()
        {
            // Arrange
            string name = null;
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();

            // Act & Assert
            Assert.That(() => new Package(name, versionStub.Object, dependenciesStub.Object),
                        Throws.ArgumentNullException);
        }
    }
}
