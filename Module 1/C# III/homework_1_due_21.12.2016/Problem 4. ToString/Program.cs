/*
Problem 4. ToString

* Add a method in the GSM class for displaying all information about it.

* Try to override ToString().
*/

using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Problem_4
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

            GSM testGSM = new GSM(
                "Xiaomi Mi 5s", "Beijing Xiaomi Technology Co., Ltd", 780, "Xiaomi Fan Boi",
                new Battery("Li-Ion battery, capacity: 3200mAh", 15, 20, Problem_3.Battery.BatteryTypes.LiIon),
                new Display("5.15\"\\1920x1080px\\IPS LCD", 16000000U)
                );

            Console.WriteLine(testGSM.ToString());
        }
    }
}
