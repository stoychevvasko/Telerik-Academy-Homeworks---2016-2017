using System.Text;

namespace Problem_4
{
    /// <summary>
    /// Represents an electronic display screen.
    /// </summary>
    public class Display
        : Problem_3.Display
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

        /// <summary>
        /// Returns a <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>a<see cref="string"/> value</returns>
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine(string.Format("{0}{1}", " Display object  ", this.GetType()))
                .AppendLine(string.Format("{0} {1}", "   Size           ", this.Size))
                .AppendLine(string.Format("{0} {1}", "   Colors         ", this.NumberOfColors))
                .ToString();
        }
    }
}
