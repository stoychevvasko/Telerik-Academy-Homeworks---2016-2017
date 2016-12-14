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
        private char[] model;

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
        public Battery(string model, decimal? hoursIdle, decimal? hoursTalked, BatteryTypes batteryType)
        {
            this.Model = ((model == null) ? null : model);
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

        // public properties

        /// <summary>
        /// Represents <see cref="Battery"/> device model or type.
        /// </summary>
        new public string Model
        {
            get
            {
                if (this.model == null) return null;
                else if (string.Join(string.Empty, this.model) == string.Empty) return "_empty_string";
                else return string.Join(string.Empty, this.model);
            }
            set
            {
                if (value == null) this.model = null;
                else this.model = value.ToCharArray();
            }
        }

        /// <summary>
        /// Represents idle time for <see cref="Battery"/> objects.
        /// </summary>
        new public decimal? HoursIdle
        {
            get
            {
                if (this.hoursIdle == null) return null;
                else return (decimal?)this.hoursIdle.Value.TotalHours;
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
                    int minutes = (int)Math.Truncate(decimalValue * 60M - (days * 60 * 24) - (hours * 60));
                    int seconds = (int)Math.Truncate(decimalValue * 60M * 60M - (days * 24 * 60 * 60) - (hours * 60 * 60) - (minutes * 60));
                    int milliseconds = (int)Math.Truncate(decimalValue * 60M * 60M * 1000M - (days * 24 * 60 * 60 * 1000) - (hours * 60 * 60 * 1000) - (minutes * 60 * 1000) - (seconds * 1000));
                    this.hoursIdle = new TimeSpan(days, hours, minutes, seconds, milliseconds);
                }
            }
        }

        /// <summary>
        /// Represents time talked for <see cref="Battery"/> objects.
        /// </summary>
        new public decimal? HoursTalked
        {
            get
            {
                if (this.hoursTalked == null) return null;
                else return (decimal?)this.hoursTalked.Value.TotalHours;
            }
            set
            {
                if (value == null) this.hoursTalked = null;
                else if (value < 0M) this.hoursTalked = null;
                else
                {
                    decimal decimalValue = (decimal)value;
                    int days = (int)Math.Truncate(decimalValue) / 24;
                    int hours = (int)Math.Truncate(decimalValue - (days * 24));
                    int minutes = (int)Math.Truncate(decimalValue * 60M - (days * 60 * 24) - (hours * 60));
                    int seconds = (int)Math.Truncate(decimalValue * 60M * 60M - (days * 24 * 60 * 60) - (hours * 60 * 60) - (minutes * 60));
                    int milliseconds = (int)Math.Truncate(decimalValue * 60M * 60M * 1000M - (days * 24 * 60 * 60 * 1000) - (hours * 60 * 60 * 1000) - (minutes * 60 * 1000) - (seconds * 1000));
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
                .AppendLine(string.Format("{0}{1}", " Battery object      ", this.GetType()))
                .AppendLine(string.Format("{0} {1}", "   Model              ", this.Model))
                .AppendLine(string.Format("{0} {1}", "   Type               ", this.BatteryType))
                .AppendLine(string.Format("{0} {1}", "   Hours idle         ",
                               (this.HoursIdle == null) ? "_null_reference" : string.Format("{0:D3}:{1:D2}:{2:D2} hours",
                                   (int)this.HoursIdle, this.hoursIdle.Value.Minutes, this.hoursIdle.Value.Seconds)))
                .AppendLine(string.Format("{0} {1}", "   Hours talked       ",
                               (this.HoursTalked == null) ? "_null_reference" : string.Format("{0:D3}:{1:D2}:{2:D2} hours",
                                   (int)this.HoursTalked, this.hoursTalked.Value.Minutes, this.hoursTalked.Value.Seconds)))
                .ToString();
        }
    }
}
