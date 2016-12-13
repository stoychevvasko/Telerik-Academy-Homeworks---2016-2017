using System;

namespace Problem_3.Enumeration
{
    /// <summary>
    /// Represents a set of allowed types of <see cref="Problem_3.Enumeration.Battery"/> components.
    /// </summary>
    public enum BatteryType { LiIon, NiMH, NiCd, MgIon, NiFe, KIon, AgZn, DEFAULT_BATTERY_TYPE };

    /// <summary>
    /// Represents a battery component.
    /// </summary>
    public class Battery
        : Problem_2.Constructors.Battery
    {
        // fields

        /// <summary>
        /// Holds the <see cref="Problem_3.Enumeration.BatteryType"/> value for <see cref="Problem_3.Enumeration.Battery"/> objects.
        /// </summary>
        private BatteryType batteryType;

        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem_3.Enumeration.Battery"/> class.
        /// </summary>
        /// <param name="model">Represents <see cref="Problem_3.Enumeration.Battery"/> device model or type.</param>
        /// <param name="hoursIdle">Represents idle time for <see cref="Problem_3.Enumeration.Battery"/> objects.</param>
        /// <param name="hoursTalked">Represents time talked for <see cref="Problem_3.Enumeration.Battery"/> objects.</param>
        /// <param name="batteryType">Represents a set of allowed types of <see cref="Problem_3.Enumeration.Battery"/> components.</param>
        public Battery(string model, double? hoursIdle, double? hoursTalked, BatteryType batteryType)
            : base(model, hoursIdle, hoursTalked)
        {
            this.BatteryType = batteryType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem_3.Enumeration.Battery"/> class.
        /// </summary>
        public Battery()
            : this(Battery.DEFAULT_BATTERY_MODEL, null, null, BatteryType.DEFAULT_BATTERY_TYPE)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem_3.Enumeration.Battery"/> class.
        /// </summary>
        /// <param name="model">Represents <see cref="Problem_3.Enumeration.Battery"/> device model or type.</param>
        /// <param name="hoursIdle">Represents idle time for <see cref="Problem_3.Enumeration.Battery"/> objects.</param>
        /// <param name="hoursTalked">Represents time talked for <see cref="Problem_3.Enumeration.Battery"/> objects.</param>
        public Battery(string model, double? hoursIdle, double? hoursTalked)
            : this(model, hoursIdle, hoursTalked, BatteryType.DEFAULT_BATTERY_TYPE)
        {
        }

        // properties

        /// <summary>
        /// Represents the <see cref="Problem_3.Enumeration.BatteryType"/> value for <see cref="Problem_3.Enumeration.Battery"/> objects.
        /// </summary>
        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
    }
}
