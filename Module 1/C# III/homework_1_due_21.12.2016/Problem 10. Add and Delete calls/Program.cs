/*
Problem 10. Add/Delete calls

* Add methods in the GSM class for adding and deleting calls from the calls history.
* Add a method to clear the call history.
*/

using System;

namespace Problem_10
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
            testGSM.AddCall(testCall);
            testGSM.AddCall(testCall);

            Console.WriteLine("2 identical calls added");
            for (int i = 0; i < testGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("{0}[{1}]\r\n{2}", testGSM.CallHistory.GetType(), i, testGSM.CallHistory[i]);
            }

            testGSM.DeleteCall(testCall);
            Console.WriteLine("call deleted");
            for (int i = 0; i < testGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("{0}[{1}]\r\n{2}", testGSM.CallHistory.GetType(), i, testGSM.CallHistory[i]);
            }

            testGSM.ClearCallHistory();
            Console.WriteLine("call history cleared");
            for (int i = 0; i < testGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("{0}[{1}]\r\n{2}", testGSM.CallHistory.GetType(), i, testGSM.CallHistory[i]);
            }
        }
    }
}
