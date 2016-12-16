/*
Problem 9. Call history

* Add a property CallHistory in the GSM class to hold a list of the performed calls.
* Try to use the system class List<Call>.
*/

using System;

namespace Problem_9
{
    class Program
    {
        static void Main()
        {
            GSM testGSM = new GSM("GSM Complete", "Company Inc.", 123.4567M, "GSM person",
                            new Battery("Custom battery", 24.95M, 23.5M, Problem_3.Battery.BatteryTypes.LiIon),
                            new Display("Custom display", 64000));
            Console.WriteLine(testGSM);
            Call testCall = new Call(new DateTime(2016, 12, 31, 23, 59, 59), "123456789", 120);
            testGSM.CallHistory.Add(testCall);
            Console.WriteLine(testGSM.CallHistory[0]);
        }
    }
}
