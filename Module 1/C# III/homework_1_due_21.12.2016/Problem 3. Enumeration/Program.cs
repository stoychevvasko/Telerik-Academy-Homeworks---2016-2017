/*
Problem 3. Enumeration

Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
*/

using System;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new string('=', 55) + "\r\n");

            Battery testNewBatteryWithType = new Battery();
            PrintBattery(testNewBatteryWithType);

            var test2 = new Battery("IPhone battery", 3, 12);
            PrintBattery(test2);

            var test3 = new Battery("Huawei battery", 5, 6, Battery.BatteryTypes.NiCd);
            PrintBattery(test3);

            Console.WriteLine(new string('=', 55) + "\r\n");
            Console.WriteLine("Press any key for more tests . . . \r\n");
            Console.ReadKey();
            Console.Clear();

            var testGSMWithNewBatteryType = new GSM();
            PrintGSM(testGSMWithNewBatteryType);

            var testGSMMore = new GSM("Blackberry", "Blackberry Ltd.", 9999.98, "Richard Sr.", test3, new Display("24k Mpx/over 9000", 32000));
            PrintGSM(testGSMMore);

            Console.WriteLine(new string('=', 55) + "\r\n");
        }

        /// <summary>
        /// Writes info about a <see cref="Battery"/> object on the <see cref="Console"/>.
        /// </summary>
        /// <param name="battery">Represents an instance of the <see cref="Battery"/> class.</param>
        private static void PrintBattery(Battery battery)
        {
            Console.WriteLine("Device type:        {0}", battery);
            Console.WriteLine(" Model:              {0}", battery.Model);
            Console.WriteLine(" Battery type:       {0}", battery.BatteryType);
            Console.WriteLine(" Hours idle:         {0}", battery.HoursIdle);
            Console.WriteLine(" Hours talked:       {0}", battery.HoursTalked);
            Console.WriteLine();
        }

        /// <summary>
        /// Writes info about a <see cref="GSM"/> object on the <see cref="Console"/>.
        /// </summary>
        /// <param name="gsm">Represents an instance of the <see cref="GSM"/> class.</param>
        private static void PrintGSM(GSM gsm)
        {
            Console.WriteLine("GSM object          {0}", gsm);
            Console.WriteLine(" Manufacturer:       {0}", gsm.Manufacturer);
            Console.WriteLine(" Model:              {0}", gsm.Model);
            Console.WriteLine(" Display object       {0}", gsm.Display);
            Console.WriteLine("  Display size:        {0}", gsm.Display.Size);
            Console.WriteLine("  Number of colors:    {0}", gsm.Display.NumberOfColors);
            Console.WriteLine("  Battery object      {0}", gsm.Battery);
            Console.WriteLine("   Battery type:       {0}", gsm.Battery.BatteryType);
            Console.WriteLine("   Battery model:      {0}", gsm.Battery.Model);
            Console.WriteLine("   Hours talked:       {0}", gsm.Battery.HoursTalked);
            Console.WriteLine("   Hours idle:         {0}", gsm.Battery.HoursIdle);
            Console.WriteLine(" Price:              {0:C2}", gsm.Price);
            Console.WriteLine(" Owner:              {0}", gsm.Owner);
            Console.WriteLine();
        }
    }
}
