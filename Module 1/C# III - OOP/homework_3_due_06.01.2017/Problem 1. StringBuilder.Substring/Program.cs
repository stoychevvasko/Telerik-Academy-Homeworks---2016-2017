/*
Problem 1. StringBuilder.Substring

* Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
new StringBuilder and has the same functionality as Substring in the class String.
*/

using System;
using System.Text;

namespace Problem_01
{
    class Program
    {
        static void Main()
        {
            string testString = "Lorem ispum";
            StringBuilder testBuilder = new StringBuilder(testString);

            Console.WriteLine("test 01");
            Console.WriteLine(testString.Substring(0, 5));
            Console.WriteLine(testBuilder.Substring(0, 5));
            Console.WriteLine();

            // Console.WriteLine("test 02");
            // Console.WriteLine(testString.Substring(-1, 6));
            // Console.WriteLine(testBuilder.Substring(-1, 6));
            // Console.WriteLine();

            // Console.WriteLine("test 03");
            // Console.WriteLine(testString.Substring(0, 12));
            // Console.WriteLine(testBuilder.Substring(0, 12));
            // Console.WriteLine();

            // Console.WriteLine("test 04");
            // Console.WriteLine(testString.Substring(0, -3));
            // Console.WriteLine(testBuilder.Substring(0, -3));
            // Console.WriteLine();

            Console.WriteLine("test 05");
            Console.WriteLine(testString.Substring(5, 2));
            Console.WriteLine(testBuilder.Substring(5, 2));
            Console.WriteLine();

            Console.WriteLine("test 06");
            Console.WriteLine(testString.Substring(5, 0));
            Console.WriteLine(testBuilder.Substring(5, 0));
            Console.WriteLine();

            Console.WriteLine("test 07");
            Console.WriteLine(testString.Substring(1, 5));
            Console.WriteLine(testBuilder.Substring(1, 5));
            Console.WriteLine();
        }
    }
}
