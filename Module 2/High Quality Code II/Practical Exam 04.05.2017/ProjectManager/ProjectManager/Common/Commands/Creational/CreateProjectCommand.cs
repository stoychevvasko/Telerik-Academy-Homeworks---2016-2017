namespace ProjectManager.Common.Commands.Creational
{
    using System.Collections.Generic;
    using System.Linq;
    using Bytes2you.Validation;
    using Contracts.Interfaces;
    using Data;
    using Exceptions;
    using Factories;

    public class CreateProjectCommand : ICommand
    {
        public CreateProjectCommand(Database database, ModelsFactory factory)
        {
            Guard.WhenArgument(database, "CreateProjectCommand Database").IsNull().Throw();
            Guard.WhenArgument(factory, "CreateProjectCommand ModelsFactory").IsNull().Throw();

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

            if (this.Database.Projects.Any(x => x.Name == commandParameters[0]))
            {
                throw new UserValidationException("A project with that name already exists!");
            }

            var project = this.Factory.CreateProject(commandParameters[0], commandParameters[1], commandParameters[2], commandParameters[3]);
            this.Database.Projects.Add(project);

            return "Successfully created a new project!";
        }
    }
}
