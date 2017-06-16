namespace ProjectManager.Framework.Core.Commands.Decorators
{
    using System;
    using System.Collections.Generic;
    using Contracts;

    public class ValidatableCommand : ICommand
    {
        private readonly ICommand command;

        public ValidatableCommand(ICommand command)
        {
            this.command = command;
        }

        public int ParameterCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Execute(IList<string> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
