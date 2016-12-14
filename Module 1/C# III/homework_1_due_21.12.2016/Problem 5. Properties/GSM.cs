using System.Text;

namespace Problem_5
{
    /// <summary>
    /// Represents mobile phone device.
    /// </summary>
    public class GSM
        : Problem_4.GSM
    {
        // private fields

        /// <summary>
        /// Holds device model spelling for <see cref="GSM"/> objects.
        /// </summary>
        protected char[] model;

        /// <summary>
        /// Holds manufacturer spelling for <see cref="GSM"/> objects.
        /// </summary>
        protected char[] manufacturer;

        /// <summary>
        /// Holds retail price value for <see cref="GSM"/> objects.
        /// </summary>
        protected decimal? price;

        /// <summary>
        /// Holds owner name spelling for <see cref="GSM"/> objects.
        /// </summary>
        protected char[] owner;

        /// <summary>
        /// Holds <see cref="Battery"/> class component for <see cref="GSM"/> objects.
        /// </summary>
        protected Battery battery;

        /// <summary>
        /// Holds a <see cref="Display"/> class component for <see cref="GSM"/> objects.
        /// </summary>
        protected Display display;


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
        /// <param name="price">Represents price details for <see cref="GSM"/> objects.</param>
        /// <param name="owner">Represents owner details for <see cref="GSM"/> objects.</param>
        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, new Battery(), new Display())
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
            : this(gsm.Model, gsm.Manufacturer, gsm.Price, gsm.Owner, gsm.Battery, gsm.Display)
        {
        }


        // public properties

        /// <summary>
        /// Represents device model for <see cref="GSM"/> objects.
        /// </summary>
        new public string Model
        {
            get
            {
                if (this.model == null) return null;
                else return string.Join("", this.model);
            }
            set
            {
                if (value == null) this.model = null;
                else this.model = value.ToCharArray();
            }
        }

        /// <summary>
        /// Represents manufacturer information for <see cref="GSM"/> objects.
        /// </summary>
        new public string Manufacturer
        {
            get
            {
                if (this.manufacturer == null) return null;
                else return string.Join("", this.manufacturer);
            }
            set
            {
                if (value == null) this.manufacturer = null;
                else this.manufacturer = value.ToCharArray();
            }
        }

        /// <summary>
        /// Represents retail price for <see cref="GSM"/> objects.
        /// </summary>
        new public decimal? Price
        {
            get
            {
                if (this.price == null) return null;
                else return this.price;
            }
            set
            {
                if (value == null) this.price = null;
                else if (value <= 0) this.price = null;
                else this.price = value;
            }
        }

        /// <summary>
        /// Represents owner details for <see cref="GSM"/> objects.
        /// </summary>
        new public string Owner
        {
            get
            {
                if (this.owner == null) return null;
                else return string.Join("", this.owner);
            }
            set
            {
                if (value == null) this.owner = null;
                else this.owner = value.ToCharArray();
            }
        }

        /// <summary>
        /// Represents a <see cref="Battery"/> class component for <see cref="GSM"/> objects.
        /// </summary>
        new public Battery Battery
        {
            get
            {
                if (this.battery == null) return null;
                else return this.battery;
            }
            set
            {
                if (value == null) this.battery = null;
                else this.battery = value;
            }
        }

        /// <summary>
        /// Represents a <see cref="Display"/> class component for <see cref="GSM"/> objects.
        /// </summary>
        new public Display Display
        {
            get
            {
                if (this.display == null) return null;
                else return this.display;
            }
            set
            {
                if (value == null) this.display = null;
                else this.display = value;
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
                .AppendLine(string.Format("{0} {1}", "GSM object         ", this.GetType()))
                .AppendLine(string.Format("{0} {1}", " Model              ", (this.model == null) ? "_null_reference" : ((this.Model == string.Empty) ? "_empty_string" : this.Model)))
                .AppendLine(string.Format("{0} {1}", " Manufacturer       ", (this.manufacturer == null) ? "_null_reference" : ((this.Manufacturer == string.Empty) ? "_empty_string" : this.Manufacturer)))
                .AppendLine(string.Format("{0} {1}", " Owner              ", (this.owner == null) ? "_null_reference" : ((this.Owner == string.Empty) ? "_empty_string" : this.Owner)))
                .AppendLine(string.Format("{0} {1}", " Price              ", (this.Price == null) ? "_null_reference" : ((decimal)this.Price).ToString("C2")))
                .Append(string.Format(">{0}", (this.battery == null) ? " Battery object   _null_reference\r\n" : (((this.Battery.ToString() == string.Empty) ? "_empty_string" : this.Battery.ToString()))))
                .Append(string.Format(">{0}", (this.display == null) ? " Display object   _null_reference\r\n" : (((this.Display.ToString() == string.Empty) ? "_empty_string" : this.Display.ToString()))))
                .ToString();
        }
    }
}
