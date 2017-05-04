namespace ProjectManager.Common
{
    using System;
    using System.Linq;
    using Contracts.Interfaces;
    using Factories;

    public class CommandProcessor : ICommandProcessor
    {
        private CommandsFactory factory;

        public CommandProcessor(CommandsFactory factory)
        {
            this.factory = factory;
        }

        public string Process(string commandString)
        {
            if (string.IsNullOrWhiteSpace(commandString))
            {
                throw new Exceptions.UserValidationException("No command has been provided!");
            }

            var command = this.factory.CreateCommandFromString(commandString.Split(' ')[0]);
                        
            if (commandString.Split(' ').Count() > 10)
            {
                throw new ArgumentException();
            }

            return command.Execute(commandString.Split(' ').Skip(1).ToList());
        }
    }
}
