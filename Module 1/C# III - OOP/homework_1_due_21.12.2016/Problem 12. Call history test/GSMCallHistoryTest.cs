using System;

namespace Problem_12
{
    /// <summary>
    /// Provides <see cref="GSM.CallHistory"/> testing functionality of the <see cref="GSM"/> class.
    /// </summary>
    static public class GSMCallHistoryTest
    {
        /// <summary>
        /// Tests the <see cref="GSM.CallHistory"/> functionality of the <see cref="GSM"/> class.
        /// </summary>
        static public void TestGSMCallHistory()
        {
            // Create an instance of the GSM class.
            GSM testGSM = new GSM("GSM Complete", "Company Inc.", 123.4567M, "GSM person",
                            new Battery("Custom battery", 24.95M, 23.5M, Problem_3.Battery.BatteryTypes.LiIon),
                            new Display("Custom display", 64000));

            // Add few calls.
            testGSM.AddCall(new Call(new DateTime(2016, 12, 31, 23, 59, 59), "123456789", 120));
            testGSM.AddCall(new Call(new DateTime(2017, 1, 1, 8, 0, 0), "123456789", 60));
            testGSM.AddCall(new Call(new DateTime(2017, 1, 10, 10, 0, 0), "123456789", 30));

            // Display the information about the calls.
            foreach (var item in testGSM.CallHistory)
            {
                Console.WriteLine(item);
            }

            // Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine("{0}: {1:C2}", "Total call costs", testGSM.CalculateTotalCallCosts(0.37M));

            // Remove the longest call from the history and calculate the total price again.
            Call longestCall = null;
            uint longestDuration = 0U;
            foreach (var item in testGSM.CallHistory)
            {
                if (item.Duration > longestDuration)
                {
                    longestDuration = item.Duration;
                    longestCall = item;
                }
            }
            testGSM.DeleteCall(longestCall);
            Console.WriteLine("{0}: {1:C2}", "Total call costs", testGSM.CalculateTotalCallCosts(0.37M));

            // Finally clear the call history and print it.
            testGSM.ClearCallHistory();
            foreach (var item in testGSM.CallHistory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
