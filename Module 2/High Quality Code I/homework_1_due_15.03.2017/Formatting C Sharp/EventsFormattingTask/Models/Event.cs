////-------------------------------------------------------------------------------------------------
//// <copyright file="Event.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Models
{
    using System;
    using System.Text;

    /// <summary>
    /// Represents a model of an event-type object.
    /// </summary>
    public class Event : IComparable
    {
        /// <summary>
        /// Represents the date of the event.
        /// </summary>
        private DateTime date;

        /// <summary>
        /// Represents the title of the event.
        /// </summary>
        private string title;

        /// <summary>
        /// Represents the location of the event.
        /// </summary>
        private string location;

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        /// <param name="date">The event name as a <see cref="string"/>.</param>
        /// <param name="title">The event title as a <see cref="string"/>.</param>
        /// <param name="location">The event location as a <see cref="string"/>.</param>
        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        /// <summary>
        /// Gets or sets the date value of the this event.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        /// <summary>
        /// Gets or sets the title value of this event.
        /// </summary>
        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
            }
        }

        /// <summary>
        /// Gets or sets the location value of this event.
        /// </summary>
        public string Location
        {
            get
            {
                return this.location;
            }

            set
            {
                this.location = value;
            }
        }

        /// <summary>
        /// Compares for difference one event against another.
        /// </summary>
        /// <param name="obj">The target <see cref="Event"/>-type object subject to comparison.</param>
        /// <returns>Result value from the comparison performed.</returns>
        public int CompareTo(object obj)
        {
            Event other = obj as Event;

            int comparedByDate = this.date.CompareTo(other.date);
            int comparedByTitle = this.title.CompareTo(other.title);
            int comparedByLocation = this.location.CompareTo(other.location);

            if (comparedByDate == 0)
            {
                if (comparedByTitle == 0)
                {
                    return comparedByLocation;
                }
                else
                {
                    return comparedByTitle;
                }
            }
            else
            {
                return comparedByDate;
            }
        }

        /// <summary>
        /// Represents an <see cref="Event"/>-type object in <see cref="string"/> form.
        /// </summary>
        /// <returns>A new <see cref="string"/>.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            builder.Append(" | " + this.title);

            if (this.location != null && this.location != string.Empty)
            {
                builder.Append(" | " + this.location);
            }

            return builder.ToString();
        }
    }
}
