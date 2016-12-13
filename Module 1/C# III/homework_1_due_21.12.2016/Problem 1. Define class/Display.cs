namespace Problem_1
{
    /// <summary>
    /// Models the display screen of an electronic device.
    /// </summary>
    public class Display
    {
        // public properties

        /// <summary>
        /// Represents size/resolution of a <see cref="Display"/> object.
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// Represents number of colors supported by a <see cref="Display"/> object.
        /// </summary>
        public uint NumberOfColors { get; set; }
    }
}
