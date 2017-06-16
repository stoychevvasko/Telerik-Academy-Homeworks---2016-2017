namespace ProjectManager.Framework.Core.Commands.Abstracts
{
    using System.Collections.Generic;
    using System.Linq;
    using Common.Exceptions;
    using Contracts;
    using Data;

    public abstract class Command : ICommand
    {
        protected readonly IDatabase Database;

        public Command(IDatabase database)
        {
            this.Database = database;
        }

        public abstract int ParameterCount
        {
            get;
        }

        public abstract string Execute(IList<string> parameters);

        protected virtual void ValidateParameters(IList<string> parameters)
        {
            if (parameters.Count != this.ParameterCount)
            {
                throw new UserValidationException("Invalid command parameters count!");
            }

            if (parameters.Any(x => x == string.Empty))
            {
                throw new UserValidationException("Some of the passed parameters are empty!");
            }
        }
    }
}
