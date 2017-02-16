namespace PackageManager.Tests.Models.ProjectTests
{
    using Moq;
    using NUnit.Framework;
    using PackageManager.Models;
    using PackageManager.Models.Contracts;
    using Repositories.Contracts;

    [TestFixture]
    public class ProjectSetName_Should
    {
        [Test]
        public void SetProperName_WhenValidNameIsPassedViaPublicConstructor()
        {
            // Arrange
            var name = "test project name 123";
            var location = "test location locate place";

            var repositoryStub = new Mock<IRepository<IPackage>>();

            // Act
            var actual = new Project(name, location, repositoryStub.Object);

            // Assert
            Assert.That(actual.Name, Is.EqualTo(name));
        }

        [Test]
        public void Throw_WhenInvalidNameIsPassedViaPublicConstructor()
        {
            // Arrange
            string name = null;
            var location = "test location locate place";

            var repositoryStub = new Mock<IRepository<IPackage>>();

            // Act & Assert
            Assert.That(() => new Project(name, location, repositoryStub.Object),
                        Throws.ArgumentNullException);
        }
    }
}
