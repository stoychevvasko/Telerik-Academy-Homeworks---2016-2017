// <copyright file="StartUp.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>
namespace Assertions_Homework
{
    using System;
    using AssertionsHomeworkProject;

    /// <summary>Main program logic.</summary>
    internal class StartUp
    {
        /// <summary>Main() class within</summary>
        private static void Main()
        {
            int[] testArray = new int[] { 1, 5, -10, -2, 20, -5, 20, -10 };
            Console.WriteLine("testArray [ {0} ]", string.Join(", ", testArray));
            AssertionsHomework.SelectionSort(testArray);
            Console.WriteLine("after selection sort [ {0} ]", string.Join(", ", testArray));

            AssertionsHomework.SelectionSort(new int[0]); // Test sorting empty array
            AssertionsHomework.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine();
            Console.WriteLine(AssertionsHomework.BinarySearch(testArray, -55));
            Console.WriteLine(AssertionsHomework.BinarySearch(testArray, 0));
            Console.WriteLine(AssertionsHomework.BinarySearch(testArray, 17));
            Console.WriteLine(AssertionsHomework.BinarySearch(testArray, -5));
            Console.WriteLine(AssertionsHomework.BinarySearch(testArray, 1000));
        }
    }
}
