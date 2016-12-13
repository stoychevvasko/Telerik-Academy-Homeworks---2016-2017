/*
Problem 2. Constructors

* Define several constructors for the defined classes that take different sets of arguments 
(the full information for the class or part of it).

* Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
*/

using System;

namespace Problem_2
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine(new string('=', 55) + "\r\n");
            
            var testDisplayDefault = new Display();
            PrintDisplay(testDisplayDefault);

            var testDisplay = new Display("600x800px/72dpi", 256);
            PrintDisplay(testDisplay);

            Console.WriteLine(new string('=', 55) + "\r\n");
            Console.WriteLine("Press any key for more tests . . . \r\n");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(new string('=', 55) + "\r\n");
            var testBatteryDefault = new Battery();
            PrintBattery(testBatteryDefault);

            var testBattery = new Battery("Toshiba", 120, 25);
            PrintBattery(testBattery);

            Console.WriteLine(new string('=', 55) + "\r\n");
            Console.WriteLine("Press any key for more tests . . . \r\n");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(new string('=', 55) + "\r\n");
            var testGSMDefault = new GSM();
            PrintGSM(testGSMDefault);

            var testNokia = new GSM("3310", "Nokia");
            PrintGSM(testNokia);

            var testSamsung = new GSM("SAMSUNG Galaxy", "Samsung Electronics", 999.99, "Richie Rich", testBattery, testDisplay);
            PrintGSM(testSamsung);
            Console.WriteLine(new string('=', 55) + "\r\n");
        }

        /// <summary>
        /// Writes info about a <see cref="Problem_2.GSM"/> object on the <see cref="Console"/>.
        /// </summary>
        /// <param name="gsm">Represents an instance of the <see cref="Problem_2.GSM"/> class.</param>
        private static void PrintGSM(GSM gsm)
        {
            Console.WriteLine("Device type:        {0}", gsm);
            Console.WriteLine(" Manufacturer:       {0}", gsm.Manufacturer);
            Console.WriteLine(" Model:              {0}", gsm.Model);
            Console.WriteLine("  Display type:       {0}", gsm.Display);
            Console.WriteLine("   Display size:       {0}", gsm.Display.Size);
            Console.WriteLine("   Number of colors:   {0}", gsm.Display.NumberOfColors);
            Console.WriteLine("  Battery type:       {0}", gsm.Battery);
            Console.WriteLine("   Battery model:      {0}", gsm.Battery.Model);
            Console.WriteLine("   Hours talked:       {0}", gsm.Battery.HoursTalked);
            Console.WriteLine("   Hours idle:         {0}", gsm.Battery.HoursIdle);
            Console.WriteLine(" Price:              {0:C2}", gsm.Price);
            Console.WriteLine(" Owner:              {0}", gsm.Owner);
            Console.WriteLine();
        }

        /// <summary>
        /// Writes info about a <see cref="Battery"/> object on the <see cref="Console"/>.
        /// </summary>
        /// <param name="battery">Represents an instance of the <see cref="Battery"/> class.</param>
        private static void PrintBattery(Battery battery)
        {
            Console.WriteLine("Device type:        {0}", battery);
            Console.WriteLine(" Model:              {0}", battery.Model);
            Console.WriteLine(" Hours idle:         {0}", battery.HoursIdle);
            Console.WriteLine(" Hours talked:       {0}", battery.HoursTalked);
            Console.WriteLine();
        }

        /// <summary>
        /// Writes info about a <see cref="Display"/> object on the <see cref="Console"/>.
        /// </summary>
        /// <param name="display">instance of the <see cref="Display"/> class</param>
        private static void PrintDisplay(Display display)
        {
            Console.WriteLine("Device type:        {0}", display);
            Console.WriteLine(" Size:               {0}", display.Size);
            Console.WriteLine(" Number of colors:   {0}", display.NumberOfColors);
            Console.WriteLine();
        }
    }
}
