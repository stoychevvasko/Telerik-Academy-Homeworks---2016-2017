namespace PackageManager.Tests.Commands
{
    using Moq;
    using NUnit.Framework;
    using PackageManager.Commands;
    using PackageManager.Core.Contracts;
    using PackageManager.Models.Contracts;

    [TestFixture]
    public class InstallCommandFields_Should
    {
        [Test]
        public void SetProperInstaller_WhenConstructorIsCalledWithValidInstallerParameter()
        {
            // Arrange
            var installerStub = new Mock<Installer<IPackage>>();
            var packageStub = new Mock<IPackage>();

            // Act
            var actual = new InstallCommandMock(installerStub.Object, packageStub.Object);

            // Assert            
            Assert.That(actual.Installer, Is.EqualTo(installerStub.Object));
        }

        [Test]
        public void Throw_WhenConstructorIsCalledWithInvalidInstallerNull()
        {
            // Arrange
            Installer<IPackage> installerStub = null;
            var packageStub = new Mock<IPackage>();

            // Act & Assert
            Assert.That(() => new InstallCommand(installerStub, packageStub.Object),
                       Throws.ArgumentNullException);

        }

        [Test]
        public void SetProperPackage_WhenConstructorIsCalledWithValidPackageParameter()
        {
            // Arrange
            var installerStub = new Mock<Installer<IPackage>>();
            var packageStub = new Mock<IPackage>();

            // Act
            var actual = new InstallCommandMock(installerStub.Object, packageStub.Object);

            // Assert            
            Assert.That(actual.Package, Is.EqualTo(packageStub.Object));
        }

        [Test]
        public void Throw_WhenConstructorIsCalledWithInvalidPackageNull()
        {
            // Arrange
            var installerStub = new Mock<Installer<IPackage>>();
            IPackage packageStub = null;

            // Act & Assert
            Assert.That(() => new InstallCommand(installerStub.Object, packageStub),
                       Throws.ArgumentNullException);
        }
    }
}
