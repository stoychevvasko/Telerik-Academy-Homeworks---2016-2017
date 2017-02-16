namespace PackageManager.Tests.Models.ProjectTests
{
    using Moq;
    using NUnit.Framework;
    using PackageManager.Models;
    using PackageManager.Models.Contracts;
    using PackageManager.Repositories.Contracts;

    [TestFixture]
    public class ProjectSetLocation_Should
    {
        [Test]
        public void SetProperLocation_WhenLocationNameIsPassedViaPublicConstructor()
        {
            // Arrange
            var name = "test project name 123";
            var location = "test location locate place";

            var repositoryStub = new Mock<IRepository<IPackage>>();

            // Act
            var actual = new Project(name, location, repositoryStub.Object);

            // Assert
            Assert.That(actual.Location, Is.EqualTo(location));
        }

        [Test]
        public void Throw_WhenInvalidLocationIsPassedViaPublicConstructor()
        {
            // Arrange
            var name = "test project name 123";
            string location = null;

            var repositoryStub = new Mock<IRepository<IPackage>>();

            // Act & Assert
            Assert.That(() => new Project(name, location, repositoryStub.Object),
                        Throws.ArgumentNullException);
        }
    }
}
