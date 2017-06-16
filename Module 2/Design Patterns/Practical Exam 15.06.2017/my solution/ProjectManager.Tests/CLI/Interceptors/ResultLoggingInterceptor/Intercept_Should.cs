namespace ProjectManager.Tests.CLI.Interceptors.ResultLoggingInterceptor
{
    using Moq;
    using NUnit.Framework;
    using ProjectManager.Framework.Core.Common.Contracts;
    using ProjectManager.ConsoleClient.Interceptors;
    using Ninject.Extensions.Interception;

    [TestFixture]
    public class Intercept_Should
    {
        [Test]
        [Category("ResultLoggingInterceptor.ClassTests")]
        public void CallInvocationProceedOnce_WhenCalled()
        {
            // Arrange
            var writer = new Mock<IWriter>();
            var invocation = new Mock<IInvocation>();
            var sut = new ResultLoggingInterceptor(writer.Object);

            // Act
            sut.Intercept(invocation.Object);

            // Assert
            invocation.Verify(
                i => i.Proceed(),
                Times.AtLeastOnce);
        }

        [Test]
        [Category("ResultLoggingInterceptor.ClassTests")]
        public void CallWriterWriteLineOnce_WhenCalled()
        {
            // Arrange
            var writer = new Mock<IWriter>();
            var invocation = new Mock<IInvocation>();
            var sut = new ResultLoggingInterceptor(writer.Object);

            // Act
            sut.Intercept(invocation.Object);

            // Assert
            writer.Verify(
                w => w.WriteLine(It.IsAny<object>()),
                Times.AtLeastOnce);
        }
    }
}
