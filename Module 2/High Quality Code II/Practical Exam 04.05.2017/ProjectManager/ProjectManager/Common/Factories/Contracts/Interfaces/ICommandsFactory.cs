// <copyright file="ICommandsFactory.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>
namespace ProjectManager.Common.Factories.Contracts.Interfaces
{
    using Commands.Contracts.Interfaces;
    using Data;

    /// <summary>Provides command factory functionality.</summary>
    public interface ICommandsFactory
    {
        /// <summary>Gets or sets factory instance.</summary>
        ModelsFactory Factory { get; set; }

        /// <summary>Gets or sets database instance.</summary>
        Database Database { get; set; }

        /// <summary>Creates a new command from string parameter.</summary>
        /// <param name="commandName">Command candidate string.</param>
        /// <returns>Validated finished command.</returns>
        ICommand CreateCommandFromString(string commandName);
    }
}
