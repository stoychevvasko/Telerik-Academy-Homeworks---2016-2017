////-------------------------------------------------------------------------------------------------
//// <copyright file="Messages.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Assets
{
    using System.Text;
    using Core.Models;

    /// <summary>
    /// Contains event-related messaging.
    /// </summary>
    internal static class Messages
    {
        /// <summary>
        /// Holds an output buffer.
        /// </summary>
        private static StringBuilder output = new StringBuilder();

        /// <summary>
        /// Initializes static members of the <see cref="Messages"/> class.
        /// </summary>
        static Messages()
        {
            Messages.output = new StringBuilder();
        }

        /// <summary>
        /// Gets the output value as string from Messages.
        /// </summary>
        public static string Output
        {
            get
            {
                return Messages.output.ToString();
            }
        }

        /// <summary>
        /// Logs an event added.
        /// </summary>
        public static void EventAdded()
        {
            Messages.output.Append("Event added\n");
        }

        /// <summary>
        /// Logs and event deleted.
        /// </summary>
        /// <param name="x">Parameter x apparently :).</param>
        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                Messages.output.AppendFormat("{0} events deleted\n", x);
            }
        }

        /// <summary>
        /// Logs no events added.
        /// </summary>
        public static void NoEventsFound()
        {
            Messages.output.Append("No events found\n");
        }

        /// <summary>
        /// Prints an event.
        /// </summary>
        /// <param name="eventToPrint">Event to print parameter.</param>
        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Messages.output.Append(eventToPrint + "\n");
            }
        }        
    }
}