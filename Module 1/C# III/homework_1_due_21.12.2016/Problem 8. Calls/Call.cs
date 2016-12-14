using System;

namespace Problem_8
{
    /// <summary>
    /// Represents a telephone conversation.
    /// </summary>
    public class Call
    {
        // fields
        /// <summary>
        /// Holds time of call for <see cref="Call"/> objects.
        /// </summary>
        private DateTime timeStamp;

        /// <summary>
        /// Holds dialled phone number for <see cref="Call"/> objects.
        /// </summary>
        private char[] dialledNumber;

        /// <summary>
        /// Holds call duration for <see cref="Call"/> objects.
        /// </summary>
        private TimeSpan duration;

        // properties
        /// <summary>
        /// Represents call date (day, month and year) for <see cref="Call"/> objects.
        /// </summary>
        public DateTime Date
        {
            get { return new DateTime(this.timeStamp.Year, this.timeStamp.Month, this.timeStamp.Day); }
            protected set { this.timeStamp = new DateTime(value.Ticks); }
        }

        

        /// <summary>
        /// Represents dialled number for <see cref="Call"/> instances.
        /// </summary>
        public string DialledNumber
        {
            get { return string.Join(string.Empty, this.dialledNumber); }
            protected set { this.dialledNumber = value.ToCharArray(); }
        }

        /// <summary>
        /// Represents phone call duration in seconds for <see cref="Call"/> objects.
        /// </summary>
        public uint Duration
        {
            get { return (uint)Math.Floor(this.duration.TotalSeconds); }
            protected set
            {
                this.duration = new TimeSpan(value * TimeSpan.TicksPerSecond);
            }
        }
    }
}
