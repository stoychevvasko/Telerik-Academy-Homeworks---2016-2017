namespace ProjectManager.Tests.Core.Models.EngineTests
{
    using Moq;
    using NUnit.Framework;
    using ProjectManager.Common.Contracts.Interfaces;
    using ProjectManager.Common.Exceptions;
    using ProjectManager.Common.Providers.Contracts.Interfaces;
    using ProjectManager.Core.Models;

    [TestFixture]
    public class StartMethod_Should
    {
        [Test]
        public void ReadSomething_WhenCalled()
        {
            var fileLoggerStub = new Mock<IFileLogger>();
            var processorStub = new Mock<ICommandProcessor>();
            var readerStub = new Mock<IReader>();
            readerStub.Setup(r => r.ReadLine()).Returns("Exit");
            var writerStub = new Mock<IWriter>();
            var sut = new Engine(fileLoggerStub.Object, processorStub.Object, readerStub.Object, writerStub.Object);

            sut.Start();

            readerStub.Verify(r => r.ReadLine(), Times.Once);
        }

        [Test]
        public void WriteSomething_WhenUserTypesExitCommand()
        {
            var fileLoggerStub = new Mock<IFileLogger>();
            var processorStub = new Mock<ICommandProcessor>();
            var readerStub = new Mock<IReader>();
            readerStub.Setup(r => r.ReadLine()).Returns("Exit");
            var writerStub = new Mock<IWriter>();
            writerStub.Setup(w => w.WriteLine(It.IsAny<string>()));
            var sut = new Engine(fileLoggerStub.Object, processorStub.Object, readerStub.Object, writerStub.Object);

            sut.Start();

            writerStub.Verify(w => w.WriteLine(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void WriteTheCommandExecutionResult_WhenCalledWithCorrectCommand()
        {
            var testInput = "CreateProject DeathStar 2016-1-1 2018-05-04 Active";
            var expectedOutput = "test result from command processor";

            var fileLoggerStub = new Mock<IFileLogger>();
            var processorStub = new Mock<ICommandProcessor>();
            processorStub.Setup(p => p.Process(It.IsAny<string>())).Returns(expectedOutput);
            var readerStub = new Mock<IReader>();
            readerStub.SetupSequence(r => r.ReadLine()).Returns(testInput).Returns("Exit");
            var writerStub = new Mock<IWriter>();
            writerStub.Setup(w => w.WriteLine(expectedOutput));
            var sut = new Engine(fileLoggerStub.Object, processorStub.Object, readerStub.Object, writerStub.Object);

            sut.Start();

            writerStub.Verify(w => w.WriteLine(expectedOutput), Times.Once);
        }

        [Test]
        public void WriteExceptionMessage_WhenAUserValidationExceptionOccurs()
        {
            var testInput = new string[]
            {
                "CreateUser",
                "Exit"
            };

            //// var expectedOutput = "test result from exception";
            var fileLoggerStub = new Mock<IFileLogger>();
            var processorStub = new Mock<ICommandProcessor>();
            processorStub.Setup(p => p.Process(It.IsAny<string>())).Throws(new UserValidationException("error"));
            var readerStub = new Mock<IReader>();
            readerStub.SetupSequence(r => r.ReadLine())
                .Returns(testInput[0])
                .Returns(testInput[1]);

            var writerStub = new Mock<IWriter>();
            writerStub.Setup(w => w.WriteLine(It.IsAny<string>()));
            var sut = new Engine(fileLoggerStub.Object, processorStub.Object, readerStub.Object, writerStub.Object);

        }
    }
}