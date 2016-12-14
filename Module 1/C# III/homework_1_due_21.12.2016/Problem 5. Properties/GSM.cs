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
        private char[] model;

        /// <summary>
        /// Holds manufacturer spelling for <see cref="GSM"/> objects.
        /// </summary>
        private char[] manufacturer;

        /// <summary>
        /// Holds retail price value for <see cref="GSM"/> objects.
        /// </summary>
        private decimal? price;

        /// <summary>
        /// Holds owner name spelling for <see cref="GSM"/> objects.
        /// </summary>
        private char[] owner;

        /// <summary>
        /// Holds <see cref="Battery"/> class component for <see cref="GSM"/> objects.
        /// </summary>
        private Battery battery;

        /// <summary>
        /// Holds a <see cref="Display"/> class component for <see cref="GSM"/> objects.
        /// </summary>
        private Display display;


        // constructors


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
                else return this.owner.ToString();
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
                else return new Battery(this.battery.Model, this.battery.HoursIdle, this.battery.HoursTalked, this.battery.BatteryType);
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
                else return new Display(this.display.Size, this.display.NumberOfColors);
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
                .AppendLine(string.Format("{0} {1}", "GSM object      ", this.GetType()))
                .AppendLine(string.Format("{0} {1}", " Model          ", (this.model == null) ? "_null_reference" : ((this.Model == string.Empty) ? "_empty_string" : this.Model)))
                .AppendLine(string.Format("{0} {1}", " Manufacturer   ", (this.manufacturer == null) ? "_null_reference" : ((this.Manufacturer == string.Empty) ? "_empty_string" : this.Manufacturer)))
                .AppendLine(string.Format("{0} {1}", " Owner          ", (this.owner == null) ? "_null_reference" : ((this.Owner == string.Empty) ? "_empty_string" : this.Owner)))
                .AppendLine(string.Format("{0} {1:C2}", " Price          ", (this.Price == null) ? "_null_reference" : this.Price.ToString()))
                .Append(string.Format(">{0}", (this.battery == null) ? " Battery object   _null_reference\r\n" : (((this.Battery.ToString() == string.Empty) ? "_empty_string" : this.Battery.ToString()))))
                .Append(string.Format(">{0}", (this.display == null) ? " Display object   _null_reference\r\n" : (((this.Display.ToString() == string.Empty) ? "_empty_string" : this.Display.ToString()))))
                .ToString();
        }
    }
}
