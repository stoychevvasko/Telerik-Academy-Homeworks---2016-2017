using System;
using System.Text;

namespace Problem_5
{
    /// <summary>
    /// Represents a battery component.
    /// </summary>
    public class Battery
        : Problem_4.Battery
    {
        // private properties

        /// <summary>
        /// Holds device model or type details of a <see cref="Battery"/> object.
        /// </summary>
        private string model;

        /// <summary>
        /// Holds idle time value for <see cref="Battery"/> objects.
        /// </summary>
        private TimeSpan? hoursIdle;

        /// <summary>
        /// Holds idle time value for <see cref="Battery"/> objects.
        /// </summary>
        private TimeSpan? hoursTalked;


        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="model">Represents <see cref="Battery"/> device model or type.</param>
        /// <param name="hoursIdle">Represents idle time for <see cref="Battery"/> objects.</param>
        /// <param name="hoursTalked">Represents time talked for <see cref="Battery"/> objects.</param>
        /// <param name="batteryType">Represents a set of allowed types of <see cref="Battery"/> components.</param>
        public Battery(string model, double? hoursIdle, double? hoursTalked, BatteryTypes batteryType)
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
        public Battery(string model, double? hoursIdle, double? hoursTalked)
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


        // public properties

        /// <summary>
        /// Represents <see cref="Battery"/> device model or type.
        /// </summary>
        new public string Model
        {
            get
            {
                if (this.model == null) return "_null_reference";
                else if (this.model == string.Empty) return "_empty_string";
                else return this.model.ToString();
            }
            set
            {
                this.model = value.ToString();
            }
        }

        /// <summary>
        /// Represents idle time for <see cref="Battery"/> objects.
        /// </summary>
        new public double? HoursIdle
        {
            get
            {
                if (this.hoursIdle == null) return null;
                else return this.hoursIdle.Value.TotalHours;
            }
            set
            {
                if (value == null) this.hoursIdle = null;
                else if (value < 0) this.hoursIdle = null;
                else
                {
                    decimal decimalValue = (decimal)value;
                    int days = (int)Math.Truncate(decimalValue) / 24;
                    int hours = (int)Math.Truncate(decimalValue - (days * 24M));
                    int minutes = (int)Math.Truncate(decimalValue * 60 - (days * 60 * 24) - (hours * 60));
                    int seconds = (int)Math.Truncate(decimalValue * 60 * 60 - (days * 24M * 60M * 60M) - (hours * 60M * 60M) - (minutes * 60M));
                    int milliseconds = (int)Math.Truncate(decimalValue * 60 * 60 * 1000 - (days * 24 * 60 * 60 * 1000) - (hours * 60 * 60M * 1000) - (minutes * 60 * 1000) - (seconds * 1000));
                    this.hoursIdle = new TimeSpan(days, hours, minutes, seconds, milliseconds);
                }
            }
        }

        /// <summary>
        /// Represents time talked for <see cref="Battery"/> objects.
        /// </summary>
        new public double? HoursTalked
        {
            get
            {
                if (this.hoursTalked == null) return null;
                else return this.hoursTalked.Value.TotalHours;
            }
            set
            {
                if (value == null) this.hoursTalked = null;
                else if (value < 0D) this.hoursTalked = null;
                else
                {
                    decimal decimalValue = (decimal)value;
                    int days = (int)Math.Truncate(decimalValue) / 24;
                    int hours = (int)Math.Truncate(decimalValue - (days * 24M));
                    int minutes = (int)Math.Truncate(decimalValue * 60 - (days * 60 * 24) - (hours * 60));
                    int seconds = (int)Math.Truncate(decimalValue * 60 * 60 - (days * 24M * 60M * 60M) - (hours * 60M * 60M) - (minutes * 60M));
                    int milliseconds = (int)Math.Truncate(decimalValue * 60 * 60 * 1000 - (days * 24 * 60 * 60 * 1000) - (hours * 60 * 60M * 1000) - (minutes * 60 * 1000) - (seconds * 1000));
                    this.hoursTalked = new TimeSpan(days, hours, minutes, seconds, milliseconds);
                }
            }
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
                .AppendLine(string.Format("{0} {1}", "   Hours idle     ",
                               (this.HoursIdle == null) ? "_null_reference" : string.Format("{0:D3}:{1:D2}:{2:D2}",
                                   (int)this.HoursIdle, this.hoursIdle.Value.Minutes, this.hoursIdle.Value.Seconds)))
                .AppendLine(string.Format("{0} {1}", "   Hours talked   ",
                               (this.HoursTalked == null) ? "_null_reference" : string.Format("{0:D3}:{1:D2}:{2:D2}",
                                   (int)this.HoursTalked, this.hoursTalked.Value.Minutes, this.hoursTalked.Value.Seconds)))
                .ToString();
        }
    }
}
