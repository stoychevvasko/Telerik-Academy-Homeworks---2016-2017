namespace ProjectManager.Common.Commands.Contracts.Interfaces
{
    using System.Collections.Generic;

    public interface ICommand
    {
        string Execute(List<string> parameters);
    }
}
