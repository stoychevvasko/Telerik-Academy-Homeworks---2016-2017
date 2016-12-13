using System;

namespace Problem_3.Enumeration
{
    public class GSM
        :Problem_2.Constructors.GSM
    {
        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem_3.Enumeration.GSM"/> class.
        /// </summary>
        /// <param name="model">Represents device model for <see cref="Problem_3.Enumeration.GSM"/> objects.</param>
        /// <param name="manufacturer">Represents manufacturer information for <see cref="Problem_3.Enumeration.GSM"/> objects.</param>
        /// <param name="battery">Represents <see cref="Problem_3.Enumeration.Battery"/> component for <see cref="Problem_3.Enumeration.Battery"/> objects.</param>
        /// <param name="display">Represents <see cref="Problem_3.Enumeration.Display"/> component for <see cref="Problem_3.Enumeration.GSM"/> objects.</param>
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
        /// Initializes a new instance of the <see cref="Problem_3.Enumeration.GSM"/> class.
        /// </summary>
        /// <param name="model">Represents a <see cref="Problem_3.Enumeration.GSM"/> device model.</param>
        /// <param name="manufacturer">Represents manufacturer information for <see cref="Problem_3.Enumeration.GSM"/> objects.</param>
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, new Battery(), new Display())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem_3.Enumeration.GSM"/> class.
        /// </summary>
        public GSM()
            : this(GSM.DEFAULT_MODEL, GSM.DEFAULT_MANUFACTURER)
        {
        }

        // public properties

        /// <summary>
        /// Represents <see cref="Problem_3.Enumeration.Battery"/> component for <see cref="Problem_3.EnumerationGSM"/> objects.
        /// </summary>
        new public Battery Battery { get; set; }
    }
}
