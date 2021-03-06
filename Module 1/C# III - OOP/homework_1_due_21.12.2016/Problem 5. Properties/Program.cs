﻿/*
Problem 5. Properties

* Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
* Ensure all fields hold correct data at any given time.
*/

using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (Thread.CurrentThread.CurrentCulture.Name != "bg-BG")
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("bg-BG");
            }


            // new Display class tests

            Console.WriteLine();
            Console.WriteLine(" * Display class testing");
            Console.WriteLine();
            Console.WriteLine(new string('=', 55) + "\r\n");

            var testDisplayDefault = new Display();
            Console.WriteLine(testDisplayDefault);

            var testDisplay = new Display("test size value", null);
            Console.WriteLine(testDisplay);

            var testDisplay1 = new Display(null, 1);
            Console.WriteLine(testDisplay1);

            var testDisplay2 = new Display("", 2);
            Console.WriteLine(testDisplay2);

            var testDisplay3 = new Display("Color display", 256);
            Console.WriteLine(testDisplay3);

            Console.WriteLine(new string('=', 55) + "\r\n");
            Console.WriteLine("Press any key for more tests . . . \r\n");
            Console.ReadKey();
            Console.Clear();


            // new Battery class tests

            Console.WriteLine();
            Console.WriteLine(" * Battery class testing");
            Console.WriteLine();
            Console.WriteLine(new string('=', 55) + "\r\n");

            var testBatteryDefault = new Battery();
            Console.WriteLine(testBatteryDefault);

            var testBattery = new Battery("2550mAh Li-Ion Battery", Problem_3.Battery.BatteryTypes.LiIon);
            Console.WriteLine(testBattery);

            var testBattery1 = new Battery("Timely Battery", 1.5M, 4.687M);
            Console.WriteLine(testBattery1);

            var testBattery2 = new Battery("Full model", 72.00M, 168.56M, Problem_3.Battery.BatteryTypes.AgZn);
            Console.WriteLine(testBattery2);

            Console.WriteLine(new string('=', 55) + "\r\n");
            Console.WriteLine("Press any key for more tests . . . \r\n");
            Console.ReadKey();
            Console.Clear();


            // new GSM tests

            Console.WriteLine();
            Console.WriteLine(" * GSM class testing");
            Console.WriteLine();
            Console.WriteLine(new string('=', 55) + "\r\n");

            var gsmDefault = new GSM();
            Console.WriteLine(gsmDefault);

            var testGSM1 = new GSM("Basic GSM", "Basic manufacturer");
            Console.WriteLine(testGSM1);

            var batteryParameter = new Battery("Custom battery", 26.45698M, 23.5M, Problem_3.Battery.BatteryTypes.LiIon);
            var displayParameter = new Display("Custom display", 64000);
            var testGSM2 = new GSM("GSM Complete", "Company Inc.", 123.4567M, "GSM person",
                                  batteryParameter,
                                  displayParameter);
            batteryParameter = new Battery();
            displayParameter = new Display();
            var testGSM3 = new GSM(testGSM2);
            testGSM2 = new GSM();
            var extractedDisplay = testGSM3.Display;
            extractedDisplay = new Display();
            var extractedBattery = testGSM3.Battery;
            extractedBattery = new Battery();
            //testGSM3.Battery = extractedBattery;
            //extractedBattery = new Battery("Custom battery", 26.45698M, 23.5M, Problem_3.Battery.BatteryTypes.LiIon);
            Console.WriteLine(testGSM3);
            //Console.WriteLine(testGSM2);
            //Console.WriteLine(extractedDisplay);
            //Console.WriteLine(extractedBattery);

            Console.WriteLine(new string('=', 55) + "\r\n");
        }
    }
}
