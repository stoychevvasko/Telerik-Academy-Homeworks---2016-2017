////-------------------------------------------------------------------------------------------------
//// <copyright file="IFactory.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Contracts.Interfaces
{
    /// <summary>
    /// Provides factory functionality for all project-related class definitions.
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Gets a new <see cref="ICommand"/>-like object instance.
        /// </summary>
        /// <param name="command">A string command literal.</param>
        /// <returns>A new object of the <see cref="ICommand"/> interface.</returns>
        ICommand CreateCommand(string command);         
    }
}
