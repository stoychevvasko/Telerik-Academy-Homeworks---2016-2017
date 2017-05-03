namespace SchoolSystem.Commands.Contracts
{
    using System.Collections.Generic;

    /// <summary>Provides command-related functionality.</summary>
    public interface ICommand
    {
        /// <summary>Executes a command using a series of parameters.</summary>
        /// <param name="parameters">Command parameters</param>
        /// <returns>Command output.</returns>
        string Execute(IList<string> parameters);
    }
}
