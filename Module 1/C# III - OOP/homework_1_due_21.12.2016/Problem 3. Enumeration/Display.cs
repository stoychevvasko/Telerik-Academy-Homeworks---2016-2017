namespace Problem_3
{
    /// <summary>
    /// Represents an electronic display screen.
    /// </summary>
    public class Display
        : Problem_2.Display
    {
        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Display"/> class.
        /// </summary>
        /// <param name="size">Represents <see cref="Display"/> component size/resolution.</param>
        /// <param name="numberOfColors">Represents the number of colors supported by a <see cref="Display"/> component.</param>
        public Display(string size, uint? numberOfColors)
            : base(size, numberOfColors)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Display"/> class.
        /// </summary>
        public Display()
            : this(null, null)
        {
        }
    }
}
