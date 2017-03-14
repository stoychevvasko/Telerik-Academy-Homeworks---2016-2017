////-------------------------------------------------------------------------------------------------
//// <copyright file="AddEventCommand.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Commands
{
    using System;
    using Core.Contracts.Interfaces;
    using Core.Contracts.Providers;
    using Core.Models;    

    /// <summary>
    /// Provides add-event functionality.
    /// </summary>
    internal class AddEventCommand : ICommand
    {
        /// <summary>
        /// Holds inner command string.
        /// </summary>
        private string innerCommandLiteral;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEventCommand"/> class.
        /// </summary>
        /// <param name="command">Command string literal.</param>
        public AddEventCommand(string command)
        {
            this.innerCommandLiteral = command;
        }

        /// <summary>
        /// Calls private add-event logic.
        /// </summary>        
        public void Execute()
        {
            AddEventCommand.AddEvent(this.innerCommandLiteral);
        }

        /// <summary>
        /// Adds a new event.
        /// </summary>
        /// <param name="command">Command literal.</param>
        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;
            ParameterExtractor.GetParameters(command, "AddEvent", out date, out title, out location);
            Engine.Instance.AddEvent(date, title, location);
        }
    }
}
