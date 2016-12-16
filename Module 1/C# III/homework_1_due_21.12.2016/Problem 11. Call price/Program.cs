/*
Problem 11. Call price

* Add a method that calculates the total price of the calls in the call history.
* Assume the price per minute is fixed and is provided as a parameter.
*/

using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Problem_11
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("bg-BG");

            GSM testGSM = new GSM("GSM Complete", "Company Inc.", 123.4567M, "GSM person",
                            new Battery("Custom battery", 24.95M, 23.5M, Problem_3.Battery.BatteryTypes.LiIon),
                            new Display("Custom display", 64000));
            Console.WriteLine(testGSM);

            Call testCall1 = new Call(new DateTime(2016, 12, 31, 23, 59, 59), "123456789", 120);
            Call testCall2 = new Call(new DateTime(2017, 1, 1, 8, 0, 0), "123456789", 60);
            Call testCall3 = new Call(new DateTime(2017, 1, 10, 10, 0, 0), "123456789", 30);

            testGSM.AddCall(testCall1);
            testGSM.AddCall(testCall2);
            testGSM.AddCall(testCall3);

            foreach (var item in testGSM.CallHistory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("{0}: {1:C2}", "Total call costs", testGSM.CalculateTotalCallCosts(0.37M));
        }
    }
}
