////-------------------------------------------------------------------------------------------------
//// <copyright file="ListEventsCommand.cs" company="indepentent developer">
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
    /// Provides event listing functionality.
    /// </summary>
    internal class ListEventsCommand : ICommand
    {
        /// <summary>
        /// Holds inner command string.
        /// </summary>
        private string innerCommandLiteral;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEventsCommand"/> class.
        /// </summary>
        /// <param name="command">Command string literal.</param>
        public ListEventsCommand(string command)
        {
            this.innerCommandLiteral = command;
        }

        /// <summary>
        /// Executes a list events command string.
        /// </summary>        
        public void Execute()
        {
            ListEventsCommand.ListEvents(this.innerCommandLiteral);
        }

        /// <summary>
        /// Lists all events.
        /// </summary>
        /// <param name="command">Command to execute.</param>
        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');

            DateTime date = ParameterExtractor.GetDate(command, "ListEvents");

            string countString = command.Substring(pipeIndex + 1);

            int count = int.Parse(countString);
            Engine.Instance.ListEvents(date, count);
        }
    }
}
