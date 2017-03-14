////-------------------------------------------------------------------------------------------------
//// <copyright file="IParser.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Contracts.Interfaces
{
    using System;

    /// <summary>
    /// Provides command parser functionality.
    /// </summary>
    public interface IParser
    {
        /// <summary>
        /// Parses a command string into an <see cref="ICommand"/>-like object.
        /// </summary>
        /// <param name="command">Command literal.</param>
        /// <returns>Parsed command.</returns>
        ICommand ParseCommand(string command);        
    }
}
