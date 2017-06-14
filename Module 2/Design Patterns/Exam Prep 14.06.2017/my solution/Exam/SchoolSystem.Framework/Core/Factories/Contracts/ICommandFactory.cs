using System;
using SchoolSystem.Framework.Core.Commands.Contracts;

namespace SchoolSystem.Framework.Core.Factories.Contracts
{
    public interface ICommandFactory
    {
        ICommand GetCommand(Type type);
    }
}
