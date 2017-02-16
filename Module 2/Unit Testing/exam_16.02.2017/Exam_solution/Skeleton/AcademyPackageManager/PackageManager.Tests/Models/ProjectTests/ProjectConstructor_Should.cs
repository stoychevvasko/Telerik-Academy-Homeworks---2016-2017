namespace PackageManager.Tests.Models.ProjectTests
{
    using Castle.Core.Logging;
    using Moq;
    using NUnit.Framework;
    using PackageManager.Models;
    using PackageManager.Models.Contracts;
    using Repositories;
    using Repositories.Contracts;

    [TestFixture]
    public class ProjectConstructor_Should
    {
        [Test]
        public void SetAppropriatePassedValues_WhenConstructorCalledWithValidValuesOptionalParameterPackageRepositoryPassedAsNull()
        {
            // Arrange
            var name = "test project name 123";
            var location = "test location locate place";

            IRepository<IPackage> repositoryStub = null;

            // Act
            var actual = new Project(name, location, repositoryStub);

            // Assert
            Assert.That(actual.Name, Is.EqualTo(name));
            Assert.That(actual.Location, Is.EqualTo(location));
            Assert.That(actual.PackageRepository, Is.Not.EqualTo(null));
        }

        [Test]
        public void SetAppropriatePassedValues_WhenConstructorCalledWithValidValuesNoOptionalParameterPackageRepository()
        {
            // Arrange
            var name = "test project name 123";
            var location = "test location locate place";            

            // Act
            var actual = new Project(name, location);

            // Assert
            Assert.That(actual.Name, Is.EqualTo(name));
            Assert.That(actual.Location, Is.EqualTo(location));
            Assert.That(actual.PackageRepository, Is.Not.EqualTo(null));
        }

        [Test]
        public void SetAppropriatePassedValues_WhenConstructorCalledWithValidValuesOptionalParameterPackageRepositoryPassedAsValid()
        {
            // Arrange
            var name = "test project name 123";
            var location = "test location locate place";
            
            var repositoryStub = new Mock<IRepository<IPackage>>();

            // Act
            var actual = new Project(name, location, repositoryStub.Object);

            // Assert
            Assert.That(actual.Name, Is.EqualTo(name));
            Assert.That(actual.Location, Is.EqualTo(location));
            Assert.That(actual.PackageRepository, Is.EqualTo(repositoryStub.Object));
        }
    }
}
