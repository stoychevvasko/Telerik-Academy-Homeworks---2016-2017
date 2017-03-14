////-------------------------------------------------------------------------------------------------
//// <copyright file="DeleteEventsCommand.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Commands
{
    using Core.Contracts.Interfaces;
    using Core.Models;

    /// <summary>
    /// Provides delete-events functionality.
    /// </summary>
    internal class DeleteEventsCommand : ICommand
    {
        /// <summary>
        /// Holds inner command string.
        /// </summary>
        private string innerCommandLiteral;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEventsCommand"/> class.
        /// </summary>
        /// <param name="command">Command string literal.</param>
        public DeleteEventsCommand(string command)
        {
            this.innerCommandLiteral = command;
        }

        /// <summary>
        /// Calls private delete-events logic.
        /// </summary>        
        public void Execute()
        {
            DeleteEventsCommand.DeleteEvents(this.innerCommandLiteral);
        }

        /// <summary>
        /// Deletes a command.
        /// </summary>
        /// <param name="command">Command to delete.</param>
        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);
            Engine.Instance.DeleteEvents(title);
        }
    }
}
