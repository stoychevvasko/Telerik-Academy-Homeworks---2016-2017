namespace PackageManager.Tests.Models.PackageTests
{
    using Moq;
    using NUnit.Framework;
    using PackageManager.Models;
    using PackageManager.Models.Contracts;
    using System.Collections.Generic;

    [TestFixture]
    public class PackageConstructor_Should
    {
        [Test]
        public void SetAppropriatePassedValues_WhenConstructorCalledWithValidValues()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();

            // Act
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);

            // Assert
            Assert.That(actual.Name, Is.EqualTo(name));
            Assert.That(actual.Version, Is.EqualTo(versionStub.Object));
            Assert.That(actual.Dependencies, Is.EqualTo(dependenciesStub.Object));
        }

        [Test]
        public void SetAppropriatePassedValues_WhenConstructorCalledWithOptionalParameterDependenciesPassedAsNull()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            ICollection<IPackage> dependenciesStub = null;

            // Act
            var actual = new Package(name, versionStub.Object, dependenciesStub);

            // Act & Assert
            Assert.That(actual.Dependencies, Is.Not.EqualTo(null));
        }

        [Test]
        public void SetAppropriatePassedValues_WhenConstructorCalledWithNoOptionalParameterDependencies()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();            

            // Act
            var actual = new Package(name, versionStub.Object);

            // Act & Assert
            Assert.That(actual.Dependencies, Is.Not.EqualTo(null));
        }
    }
}
