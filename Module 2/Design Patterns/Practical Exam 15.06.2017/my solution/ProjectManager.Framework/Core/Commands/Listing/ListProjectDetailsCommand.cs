namespace ProjectManager.Framework.Core.Commands.Listing
{
    using System.Collections.Generic;
    using Abstracts;
    using Common.Exceptions;
    using Contracts;
    using Data;

    public sealed class ListProjectDetailsCommand : Command, ICommand
    {
        private const int ParameterCountConstant = 1;

        public ListProjectDetailsCommand(IDatabase database)
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

            var projectId = int.Parse(parameters[0]);
            if (this.Database.Projects.Count <= projectId || projectId < 0)
            {
                throw new UserValidationException("The project is not present in the database");
            }

            var project = this.Database.Projects[projectId];

            return project.ToString();
        }
    }
}
