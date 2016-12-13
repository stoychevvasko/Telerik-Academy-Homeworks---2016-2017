namespace Problem_2
{
    /// <summary>
    /// Represents mobile phone device.
    /// </summary>
    public class GSM
    {
        // constants

        /// <summary>
        /// Represents a default value for the <see cref="Model"/> property.
        /// </summary>
        protected const string DEFAULT_MODEL = "DEFAULT_GSM_MODEL";

        /// <summary>
        /// Represents a default value for the <see cref="Manufacturer"/> property.
        /// </summary>
        protected const string DEFAULT_MANUFACTURER = "DEFAULT_GSM_MANUFACTURER";

        // constructors

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

        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        /// <param name="model">Represents device model for <see cref="GSM"/> objects.</param>
        /// <param name="manufacturer">Represents manufacturer information for <see cref="GSM"/> objects.</param>
        /// <param name="battery">Represents <see cref="Problem_2.Battery"/> component for <see cref="GSM"/> objects.</param>
        /// <param name="display">Represents <see cref="Problem_2.Display"/> component for <see cref="GSM"/> objects.</param>
        public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        // public properties

        /// <summary>
        /// Represents device model for <see cref="GSM"/> objects.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Represents manufacturer information for <see cref="GSM"/> objects.
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Represents pricing information for <see cref="GSM"/> objects.
        /// </summary>
        public double? Price { get; set; }

        /// <summary>
        /// Represents owner details for <see cref="GSM"/> objects.
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Represents <see cref="Problem_2.Battery"/> component for <see cref="GSM"/> objects.
        /// </summary>
        public Battery Battery { get; set; }

        /// <summary>
        /// Represents <see cref="Problem_2.Display"/> component for <see cref="GSM"/> objects.
        /// </summary>
        public Display Display { get; set; }
    }
}
