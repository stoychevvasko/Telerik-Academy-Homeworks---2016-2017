using System;

namespace Problem_1.Define_class
{
    /// <summary>
    /// Models a mobile phone device.
    /// </summary>
    public class GSM
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
    }
}
