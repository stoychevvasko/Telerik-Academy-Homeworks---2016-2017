namespace ProjectManager.Common.Commands.Creational
{
    using System.Collections.Generic;
    using System.Linq;
    using Bytes2you.Validation;
    using Contracts.Interfaces;
    using Data;
    using Exceptions;
    using Factories;

    public class CreateUserCommand : ICommand
    {
        public CreateUserCommand(Database database, ModelsFactory factory)
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
            if (commandParameters.Count != 3)
            {
                throw new UserValidationException("Invalid command parameters count!");
            }

            if (commandParameters.Any(x => x == string.Empty))
            {
                throw new UserValidationException("Some of the passed parameters are empty!");
            }

            if (this.Database.Projects[int.Parse(commandParameters[0])].Users.Any() && this.Database.Projects[int.Parse(commandParameters[0])].Users.Any(x => x.Username == commandParameters[1]))
            {
                throw new UserValidationException("A user with that username already exists!");
            }

            this.Database.Projects[int.Parse(commandParameters[0])].Users.Add(this.Factory.CreateUser(commandParameters[1], commandParameters[2]));

            return "Successfully created a new user!";
        }
    }
}
