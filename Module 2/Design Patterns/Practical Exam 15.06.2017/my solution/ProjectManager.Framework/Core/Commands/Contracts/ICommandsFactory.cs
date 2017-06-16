namespace ProjectManager.Framework.Core.Commands.Contracts
{
    using System;

    public interface ICommandsFactory
    {
        ICommand GetCommand(Type type);
    }
}
