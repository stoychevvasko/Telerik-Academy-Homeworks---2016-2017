namespace ProjectManager.Framework.Core.Common.Providers
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Bytes2you.Validation;
    using Commands.Contracts;
    using Contracts;
    using Exceptions;

    public class CommandProcessor : IProcessor
    {
        private ICommandsFactory commandFactory;

        public CommandProcessor(ICommandsFactory commandFactory)
        {
            this.commandFactory = commandFactory;
        }

        public ICommandsFactory CommandFactory
        {
            get
            {
                return this.commandFactory;
            }

            set
            {
                Guard.WhenArgument(value, "CommandProcessor CommandsFactory").IsNull().Throw();
                this.commandFactory = value;
            }
        }

        public string ProcessCommand(string commandLine)
        {
            if (string.IsNullOrWhiteSpace(commandLine))
            {
                throw new UserValidationException("No command has been provided!");
            }

            var commandName = commandLine.Split(' ')[0];
            var commandParameters = commandLine
                .Split(' ')
                .Skip(1)
                .ToList();

            var commandType = this.FindCommand(commandName);

            var command = this.CommandFactory.GetCommand(commandType);

            return command.Execute(commandParameters);
        }

        private TypeInfo FindCommand(string commandName)
        {
            var currentAssembly = this.GetType().GetTypeInfo().Assembly;
            var commandTypeInfo = currentAssembly.DefinedTypes
                .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                .Where(type => type.Name.ToLower().Contains(commandName.ToLower()))
                .SingleOrDefault();

            if (commandTypeInfo == null)
            {
                throw new ArgumentException("The passed command is not found!");
            }

            return commandTypeInfo;
        }
    }
}
