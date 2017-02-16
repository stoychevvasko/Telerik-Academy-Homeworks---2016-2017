namespace PackageManager.Tests.Models.PackageTests
{
    using Moq;
    using NUnit.Framework;
    using PackageManager.Models;
    using PackageManager.Models.Contracts;
    using System.Collections.Generic;

    [TestFixture]
    public class PackageSetUrl_Should
    {
        [Test]
        public void SetProperUrl_WhenPublicConstructorIsCalledWithValidParameters()
        {
            // Arrange
            var name = "test package testing 123 sound check";
            var versionStub = new Mock<IVersion>();
            var dependenciesStub = new Mock<ICollection<IPackage>>();

            // Act
            var actual = new Package(name, versionStub.Object, dependenciesStub.Object);

            // Assert
            Assert.That(actual.Url, 
                        Is.EqualTo(string.Format("{0}.{1}.{2}-{3}",
                                                actual.Version.Major,
                                                actual.Version.Minor,
                                                actual.Version.Patch,
                                                actual.Version.VersionType)));
        }
    }
}
