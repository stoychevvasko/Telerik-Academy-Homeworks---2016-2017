/*
Problem 7. GSM test

* Write a class GSMTest to test the GSM class: 
    * Create an array of few instances of the GSM class.
    * Display the information about the GSMs in the array.
    * Display the information about the static property IPhone4S.
*/

using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Problem_7
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
            Console.WriteLine("   * Create an array of few instances of the GSM class.");
            Console.WriteLine("   * Display the information about the GSMs in the array.");
            Console.WriteLine();

            Console.WriteLine(new string('=', 55) + "\r\n");

            var array = GSMTest.CreateGSMArray();
            Console.Write("Type of collection - array: {0}{1}", array.GetType(), "\r\n{\r\n");
            foreach (var item in array)
            {
                Console.Write(item);
                Console.WriteLine(", ");
            }
            Console.WriteLine("}");

            Console.WriteLine(new string('=', 55) + "\r\n");
            Console.WriteLine("Press any key for more tests . . .");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("   * Display the information about the static property IPhone4S.");
            Console.WriteLine();

            Console.WriteLine(new string('=', 55) + "\r\n");
            Console.WriteLine(GSMTest.DisplayStaticIPhone4);

        }
    }
}
