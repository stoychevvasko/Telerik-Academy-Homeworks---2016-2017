namespace Problem_6
{
    /// <summary>
    /// Represents mobile phone device.
    /// </summary>
    public class GSM
        : Problem_5.GSM
    {
        // fields
        /// <summary>
        /// Holds a static <see cref="GSM"/> object for the IPHone4S model.
        /// </summary>
        protected static GSM iPhone4S;

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
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
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
        /// <summary>
        /// Sets static <see cref="GSM"/> class values (static "constructor").
        /// </summary>
        static GSM()
        {
            iPhone4S = new GSM("iPhone 4S", "Apple Inc.", 450M, null,
                           new Battery("Built-in rechargeable battery", null, null, Problem_3.Battery.BatteryTypes.LiIon),
                           new Display("960/640 px multi-touch display", 16777216U));
        }

        // public properties

        public static GSM IPhone4s
        {
            get { return new GSM(GSM.iPhone4S); }
        }
    }
}
