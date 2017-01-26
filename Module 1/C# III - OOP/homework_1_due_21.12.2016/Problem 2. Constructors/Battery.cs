namespace Problem_2
{
    /// <summary>
    /// Represents a battery component.
    /// </summary>
    public class Battery
    {
        // constants

        protected const string DEFAULT_BATTERY_MODEL = "DEFAULT_BATTERY_MODEL";

        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="model">Represents <see cref="Battery"/> device model or type.</param>
        /// <param name="hoursIdle">Represents idle time for <see cref="Battery"/> objects.</param>
        /// <param name="hoursTalked">Represents time talked for <see cref="Battery"/> objects.</param>
        public Battery(string model, double? hoursIdle, double? hoursTalked)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalked = hoursTalked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        public Battery()
            : this(DEFAULT_BATTERY_MODEL, null, null)
        {
        }

        // public properties

        /// <summary>
        /// Represents <see cref="Battery"/> device model or type.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Represents idle time for <see cref="Battery"/> objects.
        /// </summary>
        public double? HoursIdle { get; set; }

        /// <summary>
        /// Represents time talked for <see cref="Battery"/> objects.
        /// </summary>
        public double? HoursTalked { get; set; }
    }
}
