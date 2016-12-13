using System;

namespace Problem_3.Enumeration
{
    /// <summary>
    /// Represents an electronic display screen.
    /// </summary>
    public class Display
        :Problem_2.Constructors.Display
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Problem_3.Enumeration.Display"/> class.
        /// </summary>
        /// <param name="size">Represents <see cref="Problem_3.Enumeration.Display"/> component size/resolution.</param>
        /// <param name="numberOfColors">Represents the number of colors supported by a <see cref="Problem_2.Constructors.Display"/> component.</param>
        public Display(string size, uint? numberOfColors)
            :base(size,numberOfColors)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem_3.Enumeration.Display"/> class.
        /// </summary>
        public Display()
            :this(null,null)
        {
        }
    }
}
