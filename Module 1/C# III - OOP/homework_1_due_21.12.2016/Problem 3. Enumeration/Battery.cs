namespace Problem_3
{
    /// <summary>
    /// Represents a battery component.
    /// </summary>
    public class Battery
        : Problem_2.Battery
    {
        /// <summary>
        /// Represents a set of allowed types of <see cref="Battery"/> components.
        /// </summary>
        public enum BatteryTypes { LiIon, NiMH, NiCd, MgIon, NiFe, KIon, AgZn, DEFAULT_BATTERY_TYPE };

        // fields

        /// <summary>
        /// Holds the <see cref="Problem_3.BatteryType"/> value for <see cref="Battery"/> objects.
        /// </summary>
        protected BatteryTypes batteryType;

        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="model">Represents <see cref="Battery"/> device model or type.</param>
        /// <param name="hoursIdle">Represents idle time for <see cref="Battery"/> objects.</param>
        /// <param name="hoursTalked">Represents time talked for <see cref="Battery"/> objects.</param>
        /// <param name="batteryType">Represents a set of allowed types of <see cref="Battery"/> components.</param>
        public Battery(string model, double? hoursIdle, double? hoursTalked, BatteryTypes batteryType)
            : base(model, hoursIdle, hoursTalked)
        {
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
        public Battery(string model, double? hoursIdle, double? hoursTalked)
            : this(model, hoursIdle, hoursTalked, BatteryTypes.DEFAULT_BATTERY_TYPE)
        {
        }

        // properties

        /// <summary>
        /// Represents the <see cref="Problem_3.BatteryType"/> value for <see cref="Battery"/> objects.
        /// </summary>
        public BatteryTypes BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
    }
}
