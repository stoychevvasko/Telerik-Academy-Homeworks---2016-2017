namespace PackageManager.Tests.Models.PackageTests
{
    using Enums;
    using Moq;
    using NUnit.Framework;
    using PackageManager.Models;
    using PackageManager.Models.Contracts;
    using System.Collections.Generic;

    [TestFixture]
    public class PackageCompareTo_Should
    {
        [Test]
        public void ReturnTrue_WhenComparingOnePackageToValidSamePackage()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);
            var other = actual;

            // Act
            var comparisonResult = actual.CompareTo(other);

            // Assert (zero for equality)
            Assert.That(comparisonResult == 0, Is.True);
        }

        [Test]
        public void Throw_WhenComparingToInvalidValueNull()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);
            Package other = null;

            // Act & Assert
            Assert.That(() => actual.CompareTo(other), Throws.ArgumentNullException);
        }

        [Test]
        public void Throw_WhenComparingAgainstPackageWithDifferentName()
        {
            // Arrange
            var thisName = "test package testing 123 sound check";
            var otherName = "this name has been altered";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(thisName, versionStub.Object, dependenciesStub.Object);
            var other = new Package(otherName, versionStub.Object, dependenciesStub.Object);

            // Act & Assert
            Assert.That(() => actual.CompareTo(other), Throws.ArgumentException);
        }

        [Test]
        public void ReturnMinusOne_WhenComparingAgainstPackageWithHigherVersion()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var thisVersionStub = new Mock<IVersion>();
            thisVersionStub.Setup(v => v.Major).Returns(1);
            thisVersionStub.Setup(v => v.Minor).Returns(1);
            thisVersionStub.Setup(v => v.Patch).Returns(1);
            thisVersionStub.Setup(v => v.VersionType).Returns((VersionType)0);

            var otherVersionStub = new Mock<IVersion>();
            otherVersionStub.Setup(v => v.Major).Returns(2);
            otherVersionStub.Setup(v => v.Minor).Returns(2);
            otherVersionStub.Setup(v => v.Patch).Returns(2);
            otherVersionStub.Setup(v => v.VersionType).Returns((VersionType)1);

            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, thisVersionStub.Object, dependenciesStub.Object);
            var other = new Package(name, otherVersionStub.Object, dependenciesStub.Object);

            // Act
            var comparisonResult = actual.CompareTo(other);

            // Assert
            Assert.That(comparisonResult == -1, Is.True);
        }

        [Test]
        public void ReturnMinusOne_WhenComparingAgainstPackageWithLowerVersion()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var thisVersionStub = new Mock<IVersion>();
            thisVersionStub.Setup(v => v.Major).Returns(2);
            thisVersionStub.Setup(v => v.Minor).Returns(2);
            thisVersionStub.Setup(v => v.Patch).Returns(2);
            thisVersionStub.Setup(v => v.VersionType).Returns((VersionType)1);

            var otherVersionStub = new Mock<IVersion>();
            otherVersionStub.Setup(v => v.Major).Returns(1);
            otherVersionStub.Setup(v => v.Minor).Returns(1);
            otherVersionStub.Setup(v => v.Patch).Returns(1);
            otherVersionStub.Setup(v => v.VersionType).Returns((VersionType)0);

            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, thisVersionStub.Object, dependenciesStub.Object);
            var other = new Package(name, otherVersionStub.Object, dependenciesStub.Object);

            // Act
            var comparisonResult = actual.CompareTo(other);

            // Assert
            Assert.That(comparisonResult == 1, Is.True);
        }

        [Test]
        public void ReturnMinusOne_WhenComparingAgainstPackageWithSameVersion()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var thisVersionStub = new Mock<IVersion>();
            thisVersionStub.Setup(v => v.Major).Returns(1);
            thisVersionStub.Setup(v => v.Minor).Returns(1);
            thisVersionStub.Setup(v => v.Patch).Returns(1);
            thisVersionStub.Setup(v => v.VersionType).Returns((VersionType)0);

            var otherVersionStub = new Mock<IVersion>();
            otherVersionStub.Setup(v => v.Major).Returns(1);
            otherVersionStub.Setup(v => v.Minor).Returns(1);
            otherVersionStub.Setup(v => v.Patch).Returns(1);
            otherVersionStub.Setup(v => v.VersionType).Returns((VersionType)0);

            var dependenciesStub = new Mock<ICollection<IPackage>>();
            var actual = new Package(name, thisVersionStub.Object, dependenciesStub.Object);
            var other = new Package(name, otherVersionStub.Object, dependenciesStub.Object);

            // Act
            var comparisonResult = actual.CompareTo(other);

            // Assert
            Assert.That(comparisonResult == 0, Is.True);
        }
    }
}
