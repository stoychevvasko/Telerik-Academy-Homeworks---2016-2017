/*
Problem 6. Static field

* Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
*/

using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Problem_6
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

            Console.WriteLine();
            Console.WriteLine(" * Static field, property, constructor testing");
            Console.WriteLine();
            Console.WriteLine(new string('=', 55) + "\r\n");

            GSM myIphone = GSM.IPhone4s;
            myIphone.Owner = "me, myself and I";

            Console.WriteLine(GSM.IPhone4s);
            Console.WriteLine(myIphone);

            Console.WriteLine(new string('=', 55) + "\r\n");
        }
    }
}
