////-------------------------------------------------------------------------------------------------
//// <copyright file="ICommand.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Contracts.Interfaces
{
    /// <summary>
    /// Provides command-related functionality.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes private command logic based on string parameter.
        /// </summary>        
        void Execute();
    }
}
