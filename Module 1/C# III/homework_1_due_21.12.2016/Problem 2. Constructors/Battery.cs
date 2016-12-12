using System;

namespace Problem_2.Constructors
{
    /// <summary>
    /// Represents a battery component.
    /// </summary>
    public class Battery
    {
        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem_2.Constructors.Battery"/> class.
        /// </summary>
        /// <param name="model">Represents <see cref="Problem_2.Constructors.Battery"/> device model or type.</param>
        /// <param name="hoursIdle">Represents idle time for <see cref="Problem_2.Constructors.Battery"/> objects.</param>
        /// <param name="hoursTalked">Represents time talked for <see cref="Problem_2.Constructors.Battery"/> objects.</param>
        public Battery(string model, double? hoursIdle, double? hoursTalked)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalked = hoursTalked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem_2.Constructors.Battery"/> class.
        /// </summary>
        public Battery()
            : this(null, null, null)
        {
        }

        // public properties

        /// <summary>
        /// Represents <see cref="Problem_2.Constructors.Battery"/> device model or type.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Represents idle time for <see cref="Problem_2.Constructors.Battery"/> objects.
        /// </summary>
        public double? HoursIdle { get; set; }

        /// <summary>
        /// Represents time talked for <see cref="Problem_2.Constructors.Battery"/> objects.
        /// </summary>
        public double? HoursTalked { get; set; }
    }
}
