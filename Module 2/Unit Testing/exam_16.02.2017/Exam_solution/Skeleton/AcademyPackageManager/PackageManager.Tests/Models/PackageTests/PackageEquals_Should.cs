namespace PackageManager.Tests.Models.PackageTests
{
    using Moq;
    using NUnit.Framework;
    using PackageManager.Models;
    using PackageManager.Models.Contracts;
    using System.Collections.Generic;

    [TestFixture]
    public class PackageEquals_Should
    {
        [Test]
        public void ReturnTrue_WhenCalledWithSamePackageParameter()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);
            var other = actual;

            // Act
            var equalityResult = actual.Equals(other);

            // Assert
            Assert.That(equalityResult, Is.True);
        }

        [Test]
        public void Throw_WhenCalledWithInvalidPackageParameterNull()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);
            Package other = null;

            // Act & Assert
            Assert.That(() => actual.Equals(other), Throws.ArgumentNullException);
        }

        [Test]
        public void ReturnTrue_WhenCalledWithIPackageParameter()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);
            var other = new Package(name, versionStub.Object, dependenciesStub.Object);
        }

        [Test]
        public void ThrowNothingAndRetrunTrue_WhenCalledWithInvalidPackageParameterGenericObject()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);
            var other = new Package(name, versionStub.Object, dependenciesStub.Object);

            // Act
            var equalityResult = actual.Equals(other);

            // Act & Assert
            Assert.That(() => actual.Equals(other), Throws.Nothing);
            Assert.That(equalityResult, Is.True);
        }

        [Test]
        public void ReturnTrue_WhenCalledWithValidPackageThatIsEqual()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);
            var other = new Package(name, versionStub.Object, dependenciesStub.Object);

            // Act
            var equalityResult = actual.Equals(other);

            // Act & Assert
            Assert.That(equalityResult, Is.True);
        }

        [Test]
        public void ReturnFalse_WhenCalledWithValidPackageThatIsNotEqual()
        {
            // Arrange
            var thisName = "test package testing 123 sound check";
            var otherName = "not all names are created equal";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(thisName, versionStub.Object, dependenciesStub.Object);
            var other = new Package(otherName, versionStub.Object, dependenciesStub.Object);

            // Act
            var equalityResult = actual.Equals(other);

            // Act & Assert
            Assert.That(equalityResult, Is.False);
        }
    }
}
