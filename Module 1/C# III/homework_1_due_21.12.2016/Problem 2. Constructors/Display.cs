namespace Problem_2
{
    /// <summary>
    /// Represents an electronic display screen.
    /// </summary>
    public class Display
    {
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
        public string Size { get; set; }

        /// <summary>
        /// Represents number of colors supported by a <see cref="Display"/> object.
        /// </summary>
        public uint? NumberOfColors { get; set; }
    }
}
