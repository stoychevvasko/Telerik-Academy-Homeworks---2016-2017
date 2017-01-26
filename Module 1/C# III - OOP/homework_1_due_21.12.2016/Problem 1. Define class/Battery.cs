namespace Problem_1
{
    /// <summary>
    /// Models a battery component.
    /// </summary>
    public class Battery
    {
        // public properties

        /// <summary>
        /// Represents <see cref="Battery"/> device model or type.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Represents idle time for <see cref="Battery"/> objects.
        /// </summary>
        public double HoursIdle { get; set; }

        /// <summary>
        /// Represents time talked for <see cref="Battery"/> objects.
        /// </summary>
        public double HoursTalk { get; set; }
    }
}
