namespace ProjectManager.Tests.CLI.Interceptors.ResultLoggingInterceptor
{
    using Moq;
    using NUnit.Framework;
    using ProjectManager.Framework.Core.Common.Contracts;
    using ProjectManager.ConsoleClient.Interceptors;

    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        [Category("ResultLoggingInterceptor.ClassTests")]
        public void NotThrow_WhenCalledWIthValidArgument()
        {
            // Arrange
            var writer = new Mock<IWriter>();

            // Act
            ResultLoggingInterceptor sut;

            // Assert
            Assert.That(
                () => sut = new ResultLoggingInterceptor(writer.Object),
                Throws.Nothing);
        }

        [Test]
        [Category("ResultLoggingInterceptor.ClassTests")]
        public void Throw_WhenCalledWithInvalidArgument()
        {
            // Arrange
            var writer = new Mock<IWriter>();

            // Act
            ResultLoggingInterceptor sut;

            // Assert
            Assert.That(
                () => sut = new ResultLoggingInterceptor(null),
                Throws.Exception);
        }
    }
}
