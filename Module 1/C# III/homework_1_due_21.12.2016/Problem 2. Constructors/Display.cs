using System;

namespace Problem_2.Constructors
{
    /// <summary>
    /// Represents an electronic display screen.
    /// </summary>
    public class Display
    {
        // constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem_2.Constructors.Display"/> class.
        /// </summary>
        /// <param name="size">Represents <see cref="Problem_2.Constructors.Display"/> component size/resolution.</param>
        /// <param name="numberOfColors">Represents the number of colors supported by a <see cref="Problem_2.Constructors.Display"/> component.</param>
        public Display(string size, uint? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem_2.Constructors.Display"/> class.
        /// </summary>
        public Display()
            : this(null, null)
        {            
        }

        // public properties

        /// <summary>
        /// Represents size/resolution of a <see cref="Problem_2.Constructors.Display"/> object.
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// Represents number of colors supported by a <see cref="Problem_2.Constructors.Display"/> object.
        /// </summary>
        public uint? NumberOfColors { get; set; }
    }
}
