using System;

namespace Problem_1.Define_class
{
    /// <summary>
    /// Models a battery component.
    /// </summary>
    public class Battery
    {
        public string Model { get; set; }
        public double HoursIdle { get; set; }
        public double HoursTalk { get; set; }
    }
}
