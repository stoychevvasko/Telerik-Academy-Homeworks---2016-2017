namespace PackageManager.Tests.Commands
{    
    using Enums;
    using Moq;
    using NUnit.Framework;
    using PackageManager.Commands;
    using PackageManager.Core;
    using PackageManager.Core.Contracts;
    using PackageManager.Models.Contracts;

    [TestFixture]
    public class InstallCommandProperties_Should
    {
        public void SetProperOperationOfInstaller_WhenValidParameterIsPassedToSetterProperty()
        {
            // Arrange
            var downloaderStub = new Mock<IDownloader>();
            var projectStub = new Mock<IProject>();
            var installerActual = new PackageInstaller(downloaderStub.Object, projectStub.Object);
            var packageStub = new Mock<IPackage>();
            var actual = new InstallCommandMock(installerActual, packageStub.Object);

            // Act
            actual.Installer.Operation = (InstallerOperation)2;

            // Assert
            Assert.That(actual.Installer.Operation, Is.EqualTo((InstallerOperation)2));
        }
    }
}
