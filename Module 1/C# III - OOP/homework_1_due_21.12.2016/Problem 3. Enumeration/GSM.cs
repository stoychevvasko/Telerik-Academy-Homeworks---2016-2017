namespace Problem_3
{
    /// <summary>
    /// Represents mobile phone device.
    /// </summary>
    public class GSM
        :Problem_2.GSM
    {
        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        /// <param name="model">Represents device model for <see cref="Problem_3.GSM"/> objects.</param>
        /// <param name="manufacturer">Represents manufacturer information for <see cref="GSM"/> objects.</param>
        /// <param name="price">Represents price details for <see cref="GSM"/> objects.</param>
        /// <param name="owner">Represents owner details for <see cref="GSM"/> objects.</param>
        /// <param name="battery">Represents <see cref="Problem_3.Battery"/> component for <see cref="GSM"/> objects.</param>
        /// <param name="display">Represents <see cref="Display"/> component for <see cref="GSM"/> objects.</param>
        public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display)
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
        /// <param name="model">Represents a <see cref="GSM"/> device model.</param>
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

        // public properties

        /// <summary>
        /// Represents <see cref="Problem_3.Battery"/> component for <see cref="GSM"/> objects.
        /// </summary>
        new public Battery Battery { get; set; }
    }
}
