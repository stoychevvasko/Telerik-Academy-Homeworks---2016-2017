////-------------------------------------------------------------------------------------------------
//// <copyright file="EventHolder.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Models
{
    using System;
    using Core.Assets;
    using Wintellect.PowerCollections;

    /// <summary>
    /// Represents an event holder model.
    /// </summary>
    internal class EventHolder
    {
        /// <summary>
        /// Holds an event selection by title.
        /// </summary>
        private MultiDictionary<string, Event> selectedByTitle;

        /// <summary>
        /// Holds an event selection by date.
        /// </summary>
        private OrderedBag<Event> selectedByDate;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHolder"/> class.
        /// </summary>        
        public EventHolder()
        {
            this.selectedByTitle = new MultiDictionary<string, Event>(true);
            this.selectedByDate = new OrderedBag<Event>();
        }

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
            OrderedBag<Event>.View eventsToShow = this.selectedByDate.RangeFrom(
                                                      new Event(date, string.Empty, string.Empty),
                                                      true);

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
