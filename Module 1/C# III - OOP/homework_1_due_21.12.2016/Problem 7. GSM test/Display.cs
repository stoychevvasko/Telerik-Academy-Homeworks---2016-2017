namespace Problem_7
{
    /// <summary>
    /// Represents an electronic display screen.
    /// </summary>
    public class Display
        :Problem_6.Display
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
        /// <summary>
        /// Initializes a new instance of the <see cref="Display"/> class.
        /// </summary>
        /// <param name="display">Represents an existing <see cref="Display"/> component.</param>
        public Display(Display display)
                : this(display.Size, display.NumberOfColors)
        {
        }
    }
}
