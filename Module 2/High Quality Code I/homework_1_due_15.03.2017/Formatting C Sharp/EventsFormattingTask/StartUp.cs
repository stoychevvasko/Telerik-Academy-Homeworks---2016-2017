////-------------------------------------------------------------------------------------------------
//// <copyright file="StartUp.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask
{
    using System;
    using System.Text;
    using Models;
    using Wintellect.PowerCollections;

    /// <summary>
    /// Contains main program executable.
    /// </summary>
    public class StartUp
    {
        /// <summary>
        /// A <see cref="StringBuilder"/> item to contain all outputs.
        /// </summary>
        private static StringBuilder output = new StringBuilder();

        /// <summary>
        /// Holds all event items.
        /// </summary>
        private static EventHolder events = new EventHolder();

        /// <summary>
        /// Main program executable.
        /// </summary>        
        public static void Main()
        {
            while (ExecuteNextCommand())
            {
            }

            Console.WriteLine(output);
        }

        /// <summary>
        /// Executes the next command.
        /// </summary>
        /// <returns>A <see cref="bool"/> result indicating command execution status.</returns>
        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();
            if (command[0] == 'A')
            {
                AddEvent(command);
                return true;
            }

            if (command[0] == 'D')
            {
                DeleteEvents(command);
                return true;
            }

            if (command[0] == 'L')
            {
                ListEvents(command);
                return true;
            }

            if (command[0] == 'E')
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// Lists all events.
        /// </summary>
        /// <param name="command">Command to execute.</param>
        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');

            DateTime date = GetDate(command, "ListEvents");

            string countString = command.Substring(pipeIndex + 1);

            int count = int.Parse(countString);
            events.ListEvents(date, count);
        }

        /// <summary>
        /// Deletes a command.
        /// </summary>
        /// <param name="command">Command to delete.</param>
        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);
            events.DeleteEvents(title);
        }

        /// <summary>
        /// Adds a new event.
        /// </summary>
        /// <param name="command">Command to execute.</param>
        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;
            GetParameters(command, "AddEvent", out date, out title, out location);
            events.AddEvent(date, title, location);
        }

        /// <summary>
        /// Gets all parameters.
        /// </summary>
        /// <param name="commandForExecution">Command for execution.</param>
        /// <param name="commandType">Command type.</param>
        /// <param name="dateAndTime">Date and time.</param>
        /// <param name="eventTitle">Event title.</param>
        /// <param name="eventLocation">Event location.</param>
        private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
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
        private static DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
            return date;
        }

        /// <summary>
        /// Contains event-related messages.
        /// </summary>
        private static class Messages
        {
            /// <summary>
            /// Logs an event added.
            /// </summary>
            public static void EventAdded()
            {
                output.Append("Event added\n");
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
                    output.AppendFormat("{0} events deleted\n", x);
                }
            }

            /// <summary>
            /// Logs no events added.
            /// </summary>
            public static void NoEventsFound()
            {
                output.Append("No events found\n");
            }

            /// <summary>
            /// Prints an event.
            /// </summary>
            /// <param name="eventToPrint">Event to print parameter.</param>
            public static void PrintEvent(Event eventToPrint)
            {
                if (eventToPrint != null)
                {
                    output.Append(eventToPrint + "\n");
                }
            }
        }

        /// <summary>
        /// Represents an event holder model.
        /// </summary>
        private class EventHolder
        {
            /// <summary>
            /// Holds an event selection by title.
            /// </summary>
            private MultiDictionary<string, Event> selectedByTitle = new MultiDictionary<string, Event>(true);

            /// <summary>
            /// Holds an event selection by date.
            /// </summary>
            private OrderedBag<Event> selectedByDate = new OrderedBag<Event>();

            /// <summary>
            /// Adds a new event.
            /// </summary>
            /// <param name="date">Event date.</param>
            /// <param name="title">Event title.</param>
            /// <param name="location">Event location.</param>
            public void AddEvent(DateTime date, string title, string location)
            {
                Event newEvent = new Event(date, title, location);
                this.selectedByTitle.Add(title.ToLower(), newEvent);
                this.selectedByDate.Add(newEvent);
                Messages.EventAdded();
            }

            /// <summary>
            /// Deletes events by title.
            /// </summary>
            /// <param name="titleToDelete">Event title.</param>
            public void DeleteEvents(string titleToDelete)
            {
                string title = titleToDelete.ToLower();
                int removed = 0;

                foreach (var eventToRemove in this.selectedByTitle[title])
                {
                    removed++;
                    this.selectedByDate.Remove(eventToRemove);
                }

                this.selectedByTitle.Remove(title);
                Messages.EventDeleted(removed);
            }

            /// <summary>
            /// Lists all events.
            /// </summary>
            /// <param name="date">Date parameter.</param>
            /// <param name="count">Count parameter.</param>
            public void ListEvents(DateTime date, int count)
            {
                OrderedBag<Event>.View eventsToShow = this.selectedByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
                int showed = 0;

                foreach (var eventToShow in eventsToShow)
                {
                    if (showed == count)
                    {
                        break;
                    }

                    Messages.PrintEvent(eventToShow);
                    showed++;
                }

                if (showed == 0)
                {
                    Messages.NoEventsFound();
                }
            }
        }
    }
}