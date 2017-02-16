using Moq;
using NUnit.Framework;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Commands
{
    

    [TestFixture]
    public class InstallCommandConstructor_Should
    {
        [Test]
        public void SetAppropriatePassedValues_WhenConstructorCalledWithValidValues()
        {
            // Arrange
            var installerStub = new Mock<Installer<IPackage>>();
            var packageStub = new Mock<IPackage>();

            // Act
            var actual = new InstallCommandMock(installerStub.Object, packageStub.Object);

            // Assert            
            Assert.That(actual.Installer, Is.EqualTo(installerStub.Object));
            Assert.That(actual.Package, Is.EqualTo(packageStub.Object));
        }
    }
}
