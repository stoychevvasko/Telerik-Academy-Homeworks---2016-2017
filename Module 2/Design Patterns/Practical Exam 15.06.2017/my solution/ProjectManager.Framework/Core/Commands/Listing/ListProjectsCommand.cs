namespace ProjectManager.Framework.Core.Commands.Listing
{
    using System;
    using System.Collections.Generic;
    using Abstracts;
    using Contracts;
    using Data;
    using Data.Factories;

    public class ListProjectsCommand : Command, ICommand
    {
        private const int ParameterCountConstant = 0;

        public ListProjectsCommand(IModelsFactory factory, IDatabase database)
            : base(database)
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

            var projects = this.Database.Projects;

            if (projects.Count == 0)
            {
                return "No projects in the database!";
            }

            return string.Join(Environment.NewLine, projects);
        }
    }
}
