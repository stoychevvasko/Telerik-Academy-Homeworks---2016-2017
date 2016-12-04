/*
Binary search

Description
Write a program, that reads from the console an array of N integers and an integer K, 
sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

Sample tests

Input
6 3 15 -3 5 10 -8 23 5
16

Output
15

*/

using System;

class BinarySearch
{
    static void Main()
    {
        string[] inputIntegers = Console.ReadLine().Split(' ');
        int[] integers = new int[inputIntegers.Length];
        for (int i = 0; i < integers.Length; i++)
        {
            integers[i] = int.Parse(inputIntegers[i]);
        }
        int k = int.Parse(Console.ReadLine());
        Array.Sort(integers);
        Console.WriteLine("\r\nsorted array:");
        Console.WriteLine(String.Join(" ", integers));
        int indexOfBest = (Array.BinarySearch(integers, k) >= 0) ? 
            Array.BinarySearch(integers, k) : ~Array.BinarySearch(integers, k) - 1;
        if (indexOfBest < 0) indexOfBest = 0;
        Console.WriteLine(integers[indexOfBest]);
    }
}