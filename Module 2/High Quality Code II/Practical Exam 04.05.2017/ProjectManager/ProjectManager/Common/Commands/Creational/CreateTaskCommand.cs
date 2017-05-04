namespace ProjectManager.Common.Commands.Creational
{
    using System.Collections.Generic;
    using System.Linq;
    using Bytes2you.Validation;
    using Contracts.Interfaces;
    using Data;
    using Exceptions;
    using Factories;

    public class CreateTaskCommand : ICommand
    {
        public CreateTaskCommand(Database database, ModelsFactory factory)
        {
            Guard.WhenArgument(database, "CreateUserCommand Database").IsNull().Throw();
            Guard.WhenArgument(factory, "CreateUserCommand ModelsFactory").IsNull().Throw();

            this.Database = database;
            this.Factory = factory;
        }

        public Database Database
        {
            get;
            set;
        }

        public ModelsFactory Factory
        {
            get;
            set;
        }

        public string Execute(List<string> commandParameters)
        {
            if (commandParameters.Count != 4)
            {
                throw new UserValidationException("Invalid command parameters count!");
            }

            if (commandParameters.Any(x => x == string.Empty))
            {
                throw new UserValidationException("Some of the passed parameters are empty!");
            }

            var project = this.Database.Projects[int.Parse(commandParameters[0])];
            var owner = project.Users[int.Parse(commandParameters[1])];
            var task = this.Factory.CreateTask(owner, commandParameters[2], commandParameters[3]);

            project.Tasks.Add(task);

            return "Successfully created a new task!";
        }
    }
}
