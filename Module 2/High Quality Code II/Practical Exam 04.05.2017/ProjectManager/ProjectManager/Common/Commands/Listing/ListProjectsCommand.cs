namespace ProjectManager.Common.Commands.Listing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Bytes2you.Validation;
    using Contracts.Interfaces;
    using Data;
    using Exceptions;

    public sealed class ListProjectsCommand : ICommand
    {
        public ListProjectsCommand(Database database)
        {
            // guard clause
            Guard.WhenArgument(database, "ListProjectsCommand Database").IsNull().Throw();
            this.DataBase = database;
        }

        public Database DataBase
        {
            get;
            set;
        }

        public string Execute(List<string> parameters)
        {
            if (parameters.Count != 0)
            {
                throw new UserValidationException("Invalid command parameters count!");
            }

            if (parameters.Any(x => x == string.Empty))
            {
                throw new UserValidationException("Some of the passed parameters are empty!");
            }

            return string.Join(Environment.NewLine, this.DataBase.Projects);
        }
    }
}
