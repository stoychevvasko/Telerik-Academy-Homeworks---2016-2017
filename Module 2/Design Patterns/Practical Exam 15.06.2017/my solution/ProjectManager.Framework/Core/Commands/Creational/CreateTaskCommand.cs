namespace ProjectManager.Framework.Core.Commands.Creational
{
    using System.Collections.Generic;
    using Abstracts;
    using Contracts;
    using Data;
    using Data.Factories;

    public sealed class CreateTaskCommand : CreationalCommand, ICommand
    {
        private const int ParameterCountConstant = 4;

        public CreateTaskCommand(IModelsFactory factory, IDatabase database)
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

            var ownerId = int.Parse(parameters[1]);
            var owner = project.Users[ownerId];

            var task = this.Factory.CreateTask(owner, parameters[2], parameters[3]);
            project.Tasks.Add(task);

            return "Successfully created a new task!";
        }
    }
}
