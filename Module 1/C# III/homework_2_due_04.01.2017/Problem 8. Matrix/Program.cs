/*
Problem 8. Matrix

* Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
*/

using System;

namespace Problem_08
{
    class Program
    {
        static void Main()
        {
            // use constructor with dimension parameters
            GenericMatrix<int> testInts = new GenericMatrix<int>(5, 12);
            Console.WriteLine("testInts.Width: {0},    testInts.Height: {1}", testInts.Width, testInts.Height);
            Console.WriteLine();

            // use parameterless constructor
            GenericMatrix<decimal> testDecimals = new GenericMatrix<decimal>();
            Console.WriteLine("testDecimals.Width: {0},    testDecimals.Height: {1}", testDecimals.Width, testDecimals.Height);
            Console.WriteLine();
        }
    }
}
