/*
Problem 6. Divisible by 7 and 3

* Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/

using System;
using System.Linq;


namespace Problem_06
{
    class Program
    {
        static void Main()
        {
            int[] allNums = new int[1000];

            for (int i = 1; i < 1001; i++)
            {
                allNums[i - 1] = i;
            }

            // Lambda expression

            var resultLambda = allNums.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();

            Console.WriteLine("with Lambda expression:");

            foreach (var item in resultLambda)
            {
                Console.Write("{0, 3} ", item);
            }

            Console.WriteLine();

            // LINQ

            var resultLinq =
                from num in allNums
                where num % 7 == 0 && num % 3 == 0
                select num;

            Console.WriteLine();
            Console.WriteLine("with LINQ query:");

            foreach (var item in resultLinq)
            {
                Console.Write("{0, 3} ", item);
            }

            Console.WriteLine();
        }
    }
}
