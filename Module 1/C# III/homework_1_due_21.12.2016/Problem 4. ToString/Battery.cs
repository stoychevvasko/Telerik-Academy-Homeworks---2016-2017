using System.Text;

namespace Problem_4
{
    /// <summary>
    /// Represents a battery component.
    /// </summary>
    public class Battery
        : Problem_3.Battery
    {
        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="model">Represents <see cref="Battery"/> device model or type.</param>
        /// <param name="hoursIdle">Represents idle time for <see cref="Battery"/> objects.</param>
        /// <param name="hoursTalked">Represents time talked for <see cref="Battery"/> objects.</param>
        /// <param name="batteryType">Represents a set of allowed types of <see cref="Battery"/> components.</param>
        public Battery(string model, double? hoursIdle, double? hoursTalked, BatteryTypes batteryType)
            : base(model, hoursIdle, hoursTalked, batteryType)
        {
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

        // methods

        /// <summary>
        /// Returns a <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>a <see cref="string"/> value</returns>
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine(string.Format("{0}{1}", " Battery object  ", this.GetType()))
                .AppendLine(string.Format("{0} {1}", "   Model          ", this.Model))
                .AppendLine(string.Format("{0} {1}", "   Type           ", this.BatteryType))
                .AppendLine(string.Format("{0} {1}", "   Hours idle     ", this.HoursIdle))
                .AppendLine(string.Format("{0} {1}", "   Hours talked   ", this.HoursTalked))
                .ToString();
        }
    }
}
