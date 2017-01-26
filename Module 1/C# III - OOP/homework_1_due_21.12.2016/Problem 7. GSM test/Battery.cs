namespace Problem_7
{
    /// <summary>
    /// Represents a battery component.
    /// </summary>
    public class Battery
        : Problem_6.Battery
    {
        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="model">Represents <see cref="Battery"/> device model or type.</param>
        /// <param name="hoursIdle">Represents idle time for <see cref="Battery"/> objects.</param>
        /// <param name="hoursTalked">Represents time talked for <see cref="Battery"/> objects.</param>
        /// <param name="batteryType">Represents a set of allowed types of <see cref="Battery"/> components.</param>
        public Battery(string model, decimal? hoursIdle, decimal? hoursTalked, BatteryTypes batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalked = hoursTalked;
            this.BatteryType = batteryType;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        public Battery()
            : this(DEFAULT_BATTERY_MODEL, null, null, BatteryTypes.DEFAULT_BATTERY_TYPE)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="model">Represents <see cref="Battery"/> device model or type.</param>
        /// <param name="hoursIdle">Represents idle time for <see cref="Battery"/> objects.</param>
        /// <param name="hoursTalked">Represents time talked for <see cref="Battery"/> objects.</param>
        public Battery(string model, decimal? hoursIdle, decimal? hoursTalked)
            : this(model, hoursIdle, hoursTalked, BatteryTypes.DEFAULT_BATTERY_TYPE)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="model">Represents <see cref="Battery"/> device model or type.</param>
        /// <param name="batteryType">Represents a set of allowed types of <see cref="Battery"/> components.</param>
        public Battery(string model, BatteryTypes batteryType)
            : this(model, null, null, batteryType)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="battery">Represents an existing <see cref="Battery"/> component.</param>
        public Battery(Battery battery)
            : this(battery.Model, battery.HoursIdle, battery.HoursTalked, battery.BatteryType)
        {
        }
    }
}
