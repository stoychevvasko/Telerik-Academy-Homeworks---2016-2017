using System.Collections.Generic;

namespace Problem_9
{
    /// <summary>
    /// Represents mobile phone device.
    /// </summary>
    public class GSM
        : Problem_8.GSM
    {
        // fields
        /// <summary>
        /// Holds a <see cref="List{Call}"/>, a list of all <see cref="Call"/> instances done by a mobile device of the <see cref="GSM"/> class.
        /// </summary>
        protected List<Call> callHistory;

        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        /// <param name="model">Represents device model for <see cref="GSM"/> objects.</param>
        /// <param name="manufacturer">Represents manufacturer information for <see cref="GSM"/> objects.</param>
        /// <param name="price">Represents price details for <see cref="GSM"/> objects.</param>
        /// <param name="owner">Represents owner details for <see cref="GSM"/> objects.</param>
        /// <param name="battery">Represents <see cref="Battery"/> component for <see cref="GSM"/> objects.</param>
        /// <param name="display">Represents <see cref="Display"/> component for <see cref="GSM"/> objects.</param>
        /// <param name="calls">Represents a <see cref="List{Call}"/>, a list of all <see cref="Call"/> instances done by a mobile device of the <see cref="GSM"/> class.</param>
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display, List<Call> calls)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = calls;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        /// <param name="model">Represents device model for <see cref="GSM"/> objects.</param>
        /// <param name="manufacturer">Represents manufacturer information for <see cref="GSM"/> objects.</param>
        /// <param name="price">Represents price details for <see cref="GSM"/> objects.</param>
        /// <param name="owner">Represents owner details for <see cref="GSM"/> objects.</param>
        /// <param name="battery">Represents <see cref="Battery"/> component for <see cref="GSM"/> objects.</param>
        /// <param name="display">Represents <see cref="Display"/> component for <see cref="GSM"/> objects.</param>
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner, battery, display, new List<Call>())
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        /// <param name="model">Represents device model for <see cref="GSM"/> objects.</param>
        /// <param name="manufacturer">Represents manufacturer information for <see cref="GSM"/> objects.</param>
        public GSM(string model, string manufacturer)
               : this(model, manufacturer, null, null, new Battery(), new Display())
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        public GSM()
            : this(DEFAULT_MODEL, DEFAULT_MANUFACTURER)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        /// <param name="gsm">Represents an existing <see cref="GSM"/> component.</param>
        public GSM(GSM gsm)
            : this(gsm.Model, gsm.Manufacturer, gsm.Price, gsm.Owner,
                  new Battery(gsm.Battery.Model, gsm.Battery.HoursIdle, gsm.Battery.HoursTalked, gsm.Battery.BatteryType),
                  new Display(gsm.Display.Size, gsm.Display.NumberOfColors))
        {
        }

        // properties
        /// <summary>
        /// Represents a <see cref="List{Call}"/>, a list of all <see cref="Call"/> instances done by a mobile device of the <see cref="GSM"/> class.
        /// </summary>
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }
    }
}
