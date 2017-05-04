// <copyright file="IEngine.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>
namespace ProjectManager.Core.Contracts.Interfaces
{
    using Common.Contracts.Interfaces;
    using Common.Providers.Contracts.Interfaces;

    /// <summary>Provides standard engine functionality.</summary>
    public interface IEngine
    {
        /// <summary>Gets or sets engine's file logger.</summary>
        IFileLogger FileLogger { get; set; }

        /// <summary>Gets or sets engine's command processor.</summary>
        ICommandProcessor CommandProcessor { get; set; }

        /// <summary>Gets or sets engine's reader.</summary>
        IReader Reader { get; set; }

        /// <summary>Gets or sets engine's writer.</summary>
        IWriter Writer { get; set; }

        /// <summary>Starts engine.</summary>
        void Start();
    }
}
