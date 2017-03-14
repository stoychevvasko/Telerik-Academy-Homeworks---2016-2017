////-------------------------------------------------------------------------------------------------
//// <copyright file="ParameterExtractor.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Contracts.Providers
{
    using System;

    /// <summary>
    /// Provides parameter extraction functionality;
    /// </summary>
    internal class ParameterExtractor
    {
        /// <summary>
        /// Holds core factory singleton instance.
        /// </summary>
        private static ParameterExtractor instanceHolder = new ParameterExtractor();

        /// <summary>
        /// Prevents a default instance of the <see cref="ParameterExtractor"/> class from being created.
        /// </summary>
        private ParameterExtractor()
        {
        }

        /// <summary>
        /// Gets the core factory singleton instance.
        /// </summary>
        public static ParameterExtractor Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        /// <summary>
        /// Gets all parameters.
        /// </summary>
        /// <param name="commandForExecution">Command for execution.</param>
        /// <param name="commandType">Command type.</param>
        /// <param name="dateAndTime">Date and time.</param>
        /// <param name="eventTitle">Event title.</param>
        /// <param name="eventLocation">Event location.</param>
        public static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = ParameterExtractor.GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');

            int lastPipeIndex = commandForExecution.LastIndexOf('|');
            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        /// <summary>
        /// Gets a new <see cref="DateTime"/> object.
        /// </summary>
        /// <param name="command">Command to execute.</param>
        /// <param name="commandType">Command type.</param>
        /// <returns>A new <see cref="DateTime"/> object.</returns>
        public static DateTime GetDate(string command, string commandType)
        {            
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
            return date;
        }
    }
}
