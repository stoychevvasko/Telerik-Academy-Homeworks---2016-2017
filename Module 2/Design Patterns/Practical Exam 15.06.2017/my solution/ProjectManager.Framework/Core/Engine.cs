namespace ProjectManager.Framework.Core
{
    using Bytes2you.Validation;
    using Common.Contracts;

    public class Engine : IEngine
    {
        private ILogger logger;
        private IProcessor processor;
        private IWriter writer;
        private IReader reader;

        public Engine(ILogger logger, IProcessor processor, IWriter writer, IReader reader)
        {
            this.logger = logger;
            this.processor = processor;
            this.writer = writer;
            this.reader = reader;
        }

        public ILogger Loogger
        {
            get
            {
                return this.logger;
            }

            set
            {
                Guard.WhenArgument(value, "Engine Logger provider").IsNull().Throw();
                this.logger = value;
            }
        }

        public IProcessor Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                Guard.WhenArgument(value, "Engine Processor provider").IsNull().Throw();
                this.processor = value;
            }
        }

        public void Start()
        {
            for (;;)
            {
                var commandLine = this.reader.ReadLine();

                if (commandLine.ToLower() == "exit")
                {
                    this.writer.WriteLine("Program terminated.");
                    break;
                }

                this.processor.ProcessCommand(commandLine);
            }
        }
    }
}
