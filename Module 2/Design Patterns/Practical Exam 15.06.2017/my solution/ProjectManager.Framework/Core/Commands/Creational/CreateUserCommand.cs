namespace ProjectManager.Framework.Core.Commands.Creational
{
    using System.Collections.Generic;
    using System.Linq;
    using Abstracts;
    using Common.Exceptions;
    using Contracts;
    using Data;
    using Data.Factories;

    public sealed class CreateUserCommand : CreationalCommand, ICommand
    {
        private const int ParameterCountConstant = 3;

        public CreateUserCommand(IModelsFactory factory, IDatabase database)
            : base(factory, database)
        {
        }

        public override int ParameterCount
        {
            get
            {
                return ParameterCountConstant;
            }
        }

        public override string Execute(IList<string> parameters)
        {
            this.ValidateParameters(parameters);

            var projectId = int.Parse(parameters[0]);
            var project = this.Database.Projects[projectId];

            if (project.Users.Any() && project.Users.Any(x => x.Username == parameters[1]))
            {
                throw new UserValidationException("A user with that username already exists!");
            }

            var user = this.Factory.CreateUser(parameters[1], parameters[2]);
            project.Users.Add(user);

            return "Successfully created a new user!";
        }
    }
}
