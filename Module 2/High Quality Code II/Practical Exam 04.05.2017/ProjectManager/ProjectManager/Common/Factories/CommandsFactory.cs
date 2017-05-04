// <copyright file="CommandsFactory.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>
namespace ProjectManager.Common.Factories
{
    using Commands.Contracts.Interfaces;
    using Commands.Creational;
    using Commands.Listing;
    using Contracts.Interfaces;
    using Data;
    using Exceptions;

    /// <summary>Provides standard factory methods for the creation of command objects.</summary>
    public class CommandsFactory : ICommandsFactory
    {
        /// <summary>Initializes a new instance of the <see cref="CommandsFactory"/> class.</summary>
        /// <param name="dataBase">Database instance.</param>
        /// <param name="factory">Factory instance.</param>
        public CommandsFactory(Database dataBase, ModelsFactory factory)
        {
            this.Database = dataBase;
            this.Factory = factory;
        }

        /// <summary>Gets or sets factory instance.</summary>
        public ModelsFactory Factory
        {
            get;
            set;
        }

        /// <summary>Gets or sets database instance.</summary>
        public Database Database
        {
            get;
            set;
        }

        /// <summary>Creates a new command from a string parameter.</summary>
        /// <param name="commandName">Command candidate string.</param>
        /// <returns>Finished validated command.</returns>
        public ICommand CreateCommandFromString(string commandName)
        {
            var command = this.BuildCommand(commandName);

            switch (command)
            {
                case "createproject": return new CreateProjectCommand(this.Database, this.Factory);
                case "createtask": return new CreateTaskCommand(this.Database, this.Factory);
                case "createuser": return new CreateUserCommand(this.Database, this.Factory);
                case "listprojects": return new ListProjectsCommand(this.Database);
                default: throw new UserValidationException("The passed command is not valid!");
            }
        }

        private string BuildCommand(string parameters)
        {
            var newCommand = string.Empty;

            // var end = DateTime.Now + TimeSpan.FromSeconds(1);
            // while (DateTime.Now < end) { }
            for (int i = 0; i < parameters.Length; i++)
            {
                newCommand += parameters[i].ToString().ToLower();
            }

            return newCommand;
        }
    }
}