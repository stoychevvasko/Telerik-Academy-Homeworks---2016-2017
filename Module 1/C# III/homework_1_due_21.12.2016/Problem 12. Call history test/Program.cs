/*

Problem 12. Call history test

* Write a class GSMCallHistoryTest to test the call history functionality of the GSM class. 
  * Create an instance of the GSM class.
  * Add few calls.
  * Display the information about the calls.
  * Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
  * Remove the longest call from the history and calculate the total price again.
  * Finally clear the call history and print it.
*/

using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Problem_12
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("bg-BG");

            GSMCallHistoryTest.TestGSMCallHistory();
        }
    }
}
