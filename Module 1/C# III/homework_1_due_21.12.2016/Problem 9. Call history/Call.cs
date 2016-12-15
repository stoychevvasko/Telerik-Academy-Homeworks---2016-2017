using System;
using System.Text;

namespace Problem_9
{
    /// <summary>
    /// Represents a telephone conversation.
    /// </summary>
    public class Call
        :Problem_8.Call
    {
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
    }
}
