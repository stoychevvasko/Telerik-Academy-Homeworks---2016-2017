/*
Problem 2. IEnumerable extensions

*Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
sum, product, min, max, average.
*/

using System;
using System.Collections.Generic;

namespace Problem_02
{
    class Program
    {
        static void Main()
        {
            HashSet<decimal> testCollection = new HashSet<decimal> { -25, 1, 2, 3, -40, 4, 5, 150, -10, -11, -12, -13, -14 };

            Console.WriteLine("SUM: {0}", testCollection.Sum<decimal>());
            Console.WriteLine("PRODUCT: {0:N}", testCollection.Product<decimal>());
            Console.WriteLine("MIN: {0}", testCollection.Min<decimal>());
            Console.WriteLine("MAX: {0}", testCollection.Max<decimal>());
            Console.WriteLine("AVG: {0}", testCollection.Average<decimal>());
            
            Console.WriteLine();
        }
    }
}
