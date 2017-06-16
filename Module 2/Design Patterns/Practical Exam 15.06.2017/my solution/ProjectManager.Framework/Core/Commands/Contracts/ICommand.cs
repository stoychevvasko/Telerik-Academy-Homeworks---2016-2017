namespace ProjectManager.Framework.Core.Commands.Contracts
{
    using System.Collections.Generic;

    public interface ICommand
    {
        int ParameterCount { get; }

        string Execute(IList<string> parameters);
    }
}
