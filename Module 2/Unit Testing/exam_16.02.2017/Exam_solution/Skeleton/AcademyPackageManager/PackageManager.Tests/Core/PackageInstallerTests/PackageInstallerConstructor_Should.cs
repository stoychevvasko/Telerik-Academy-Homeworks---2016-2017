namespace PackageManager.Tests.Core.PackageInstallerTests
{
    using Moq;
    using NUnit.Framework;
    using PackageManager.Core;
    using PackageManager.Core.Contracts;
    using PackageManager.Models.Contracts;

    [TestFixture]
    public class PackageInstallerConstructor_Should
    {
        [Test]
        public void SetAppropriatePassedValues_WhenConstructorCalledWithValidValues()
        {
            // Arrange
            var downloaderStub = new Mock<IDownloader>();
            downloaderStub.SetupSet(d => d.Location = It.IsAny<string>());
            var projectStub = new Mock<IProject>();
            projectStub.SetupGet(p => p.Location).Returns("test location");

            // // Act
            // var actual = new PackageInstaller_Mock(downloaderStub.Object, projectStub.Object);
            // 
            // // Assert            
            // Assert.That(actual.Downloader, Is.EqualTo(downloaderStub.Object));
            // Assert.That(actual.Project, Is.EqualTo(projectStub));
        }

    }
}
