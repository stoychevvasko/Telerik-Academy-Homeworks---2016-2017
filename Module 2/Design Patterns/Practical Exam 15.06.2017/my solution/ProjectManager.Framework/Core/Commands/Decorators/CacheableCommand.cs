namespace ProjectManager.Framework.Core.Commands.Decorators
{
    using System.Collections.Generic;
    using Contracts;

    public class CacheableCommand : ICommand
    {
        private readonly ICommand command;

        public CacheableCommand(ICommand command)
        {
            this.command = command;
        }

        public int ParameterCount
        {
            get
            {
                return this.command.ParameterCount;
            }
        }

        public string Execute(IList<string> parameters)
        {
            return this.command.Execute(parameters);
        }
    }
}
