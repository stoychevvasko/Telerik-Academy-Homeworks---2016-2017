using System.Text;

namespace Problem_5
{
    /// <summary>
    /// Represents an electronic display screen.
    /// </summary>
    public class Display
        : Problem_4.Display
    {
        // private fields

        /// <summary>
        /// Holds size/resolution spelling for a <see cref="Display"/> object.
        /// </summary>
        protected char[] size;

        /// <summary>
        /// Holds number of colors supported by a <see cref="Display"/> object.
        /// </summary>
        protected uint? numberOfColors;


        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Display"/> class.
        /// </summary>
        /// <param name="size">Represents <see cref="Display"/> component size/resolution.</param>
        /// <param name="numberOfColors">Represents the number of colors supported by a <see cref="Display"/> component.</param>
        public Display(string size, uint? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Display"/> class.
        /// </summary>
        public Display()
            : this(null, null)
        {
        }


        // public properties

        /// <summary>
        /// Represents size/resolution of a <see cref="Display"/> object.
        /// </summary>
        new public string Size
        {
            get
            {
                if (this.size == null) return null;
                else return string.Join("", this.size);
            }
            set
            {
                if (value == null) this.size = null;
                else if (value == string.Empty) this.size = null;
                else this.size = value.ToCharArray();
            }
        }

        /// <summary>
        /// Represents number of colors supported by a <see cref="Display"/> object.
        /// </summary>
        new public uint? NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }

        // methods

        /// <summary>
        /// Returns a <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>a<see cref="string"/> value</returns>
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine(string.Format("{0}{1}", " Display object  ", this.GetType()))
                .AppendLine(string.Format("{0} {1}", "   Size           ", (this.size == null) ? "_null_reference" : this.Size))
                .AppendLine(string.Format("{0} {1:N}", "   Colors         ", (this.numberOfColors == null) ? "_null_reference" : (this.numberOfColors==1||this.numberOfColors==2)?"monocrhome": this.NumberOfColors.ToString()))
                .ToString();
        }
    }
}
