using System;
using System.Text;

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
        protected DateTime timeStamp;

        /// <summary>
        /// Holds dialled phone number for <see cref="Call"/> objects.
        /// </summary>
        protected char[] dialledNumber;

        /// <summary>
        /// Holds call duration for <see cref="Call"/> objects.
        /// </summary>
        protected TimeSpan duration;

        //constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Call"/> class.
        /// </summary>
        /// <param name="timeStamp">Represents call date (day, month and year) for <see cref="Call"/> objects.</param>
        /// <param name="dialledNumber">Represents dialled number for <see cref="Call"/> instances.</param>
        /// <param name="duration">Represents phone call duration in seconds for <see cref="Call"/> objects.</param>
        public Call(DateTime timeStamp, string dialledNumber, uint duration)
        {
            this.TimeStamp = timeStamp;
            this.DialledNumber = dialledNumber;
            this.Duration = duration;
        }

        // properties
        /// <summary>
        /// Represents call date (day, month and year) for <see cref="Call"/> objects.
        /// </summary>
        public DateTime TimeStamp
        {
            get { return this.timeStamp; }
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
            protected set { this.duration = new TimeSpan(value * TimeSpan.TicksPerSecond); }
        }

        // methods
        /// <summary>
        /// Returns a <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>a <see cref="string"/> value</returns>
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine(string.Format("{0}{1}", " Call object       ", this.GetType()))
                .AppendLine(string.Format("{0}{1}", "  Timestamp         ", this.TimeStamp))
                .AppendLine(string.Format("{0}{1} seconds", "  Duraction         ", this.Duration))
                .AppendLine(string.Format("{0}{1}", "  Dialled number    ", this.DialledNumber))
                .ToString();
        }
    }
}
