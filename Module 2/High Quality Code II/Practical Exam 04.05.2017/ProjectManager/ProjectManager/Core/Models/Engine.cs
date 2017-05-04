namespace ProjectManager.Core.Models
{
    using System;
    using Bytes2you.Validation;
    using Common.Contracts.Interfaces;
    using Common.Exceptions;
    using Common.Providers.Contracts.Interfaces;
    using Contracts.Interfaces;

    public class Engine : IEngine
    {
        public Engine(IFileLogger logger, ICommandProcessor processor, IReader reader, IWriter writer)
        {
            // validate clauses
            Guard.WhenArgument(logger, "Engine Logger provider").IsNull().Throw();
            Guard.WhenArgument(processor, "Engine Processor provider").IsNull().Throw();

            this.FileLogger = logger;
            this.CommandProcessor = processor;
            this.Reader = reader;
            this.Writer = writer;
        }

        public IFileLogger FileLogger
        {
            get;
            set;
        }

        public ICommandProcessor CommandProcessor
        {
            get;
            set;
        }

        public IReader Reader
        {
            get;
            set;
        }

        public IWriter Writer
        {
            get;
            set;
        }

        public void Start()
        {
            for (;;)
            {
                // read from console
                var userInput = this.Reader.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    this.Writer.WriteLine("Program terminated.");
                    break;
                }

                try
                {
                    var executionResult = this.CommandProcessor.Process(userInput);
                    this.Writer.WriteLine(executionResult);
                }
                catch (UserValidationException ex)
                {
                    this.Writer.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    this.Writer.WriteLine("Opps, something happened. :(");
                    this.FileLogger.Error(ex.Message);
                }
            }
        }
    }
}
