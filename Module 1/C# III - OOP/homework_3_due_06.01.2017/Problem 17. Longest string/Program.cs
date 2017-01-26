/*
Problem 17. Longest string

* Write a program to return the string with maximum length from an array of strings.
* Use LINQ.
*/

using System;
using System.Linq;

namespace Problem_17
{
    class Program
    {
        static void Main()
        {
            string[] array = new string[] { "short", "mini", "this_is_the_longest_string_here", "longer", "this_one_is_long" };

            Console.WriteLine("The longest string is:");
            Console.WriteLine();

            string result = (from str in array orderby str.Length select str).Last();

            Console.WriteLine(result);

            Console.WriteLine();
        }
    }
}
