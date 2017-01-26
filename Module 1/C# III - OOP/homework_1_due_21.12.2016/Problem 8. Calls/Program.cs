/*
Problem 8. Calls

* Create a class Call to hold a call performed through a GSM.
* It should contain date, time, dialled phone number and duration (in seconds).
*/

using System;

namespace Problem_8
{
    class Program
    {
        static void Main()
        {
            // GSM testGSM = new GSM("GSM Complete", "Company Inc.", 123.4567M, "GSM person",
            //                 new Battery("Custom battery", 24.95M, 23.5M, Problem_3.Battery.BatteryTypes.LiIon),
            //                 new Display("Custom display", 64000));
            // 
            // System.Console.WriteLine(testGSM);

            Call testCall = new Call(new DateTime(2016, 12, 31, 23, 59, 59), "123456789", 120);
            Console.WriteLine(testCall);
        }
    }
}
