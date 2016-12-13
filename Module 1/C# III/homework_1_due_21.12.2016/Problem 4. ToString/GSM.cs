using System.Text;

namespace Problem_4
{
    /// <summary>
    /// Represents mobile phone device.
    /// </summary>
    public class GSM
        : Problem_3.GSM
    {
        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        /// <param name="model">Represents device model for <see cref="GSM"/> objects.</param>
        /// <param name="manufacturer">Represents manufacturer information for <see cref="GSM"/> objects.</param>
        /// <param name="price">Represents price details for <see cref="GSM"/> objects.</param>
        /// <param name="owner">Represents owner details for <see cref="GSM"/> objects.</param>
        /// <param name="battery">Represents <see cref="Problem_4.Battery"/> component for <see cref="GSM"/> objects.</param>
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

        // public properties

        /// <summary>
        /// Represents <see cref="Problem_4.Battery"/> component for <see cref="GSM"/> objects.
        /// </summary>
        new public Battery Battery { get; set; }

        // methods

        /// <summary>
        /// Returns a <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>a <see cref="string"/> value</returns>
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine(string.Format("{0} {1}", "GSM object      ", this.GetType()))
                .AppendLine(string.Format("{0} {1}", " Model          ", this.Model))
                .AppendLine(string.Format("{0} {1}", " Manufacturer   ", this.Manufacturer))
                .AppendLine(string.Format("{0} {1}", " Owner          ", this.Owner))
                .AppendLine(string.Format("{0} {1:C2}", " Price          ", this.Price))
                .Append(">" + string.Format(this.Battery.ToString()))
                .Append(">" + string.Format(this.Display.ToString()))
                .ToString();
        }
    }
}
