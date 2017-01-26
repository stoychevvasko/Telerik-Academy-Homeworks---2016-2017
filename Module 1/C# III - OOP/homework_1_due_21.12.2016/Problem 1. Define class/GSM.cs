namespace Problem_1
{
    /// <summary>
    /// Models a mobile phone device.
    /// </summary>
    public class GSM
    {
        // public properties

        /// <summary>
        /// Represents device model for <see cref="GSM"/> objects.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Represents manufacturer information for <see cref="GSM"/> objects.
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Represents pricing information for <see cref="GSM"/> objects.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Represents owner details for <see cref="GSM"/> objects.
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Represents <see cref="Problem_2.Battery"/> component for <see cref="GSM"/> objects.
        /// </summary>
        public Battery Battery { get; set; }

        /// <summary>
        /// Represents <see cref="Problem_2.Display"/> component for <see cref="GSM"/> objects.
        /// </summary>
        public Display Display { get; set; }
    }
}
