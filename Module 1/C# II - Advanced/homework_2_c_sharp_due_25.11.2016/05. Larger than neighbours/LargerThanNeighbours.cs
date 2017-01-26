/*
Larger than neighbours

Description
Write a method that checks if the element at given position in given array of integers 
is larger than its two neighbours (when such exist). 
Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

Input
On the first line you will receive the number N - the size of the array
On the second line you will receive N numbers separated by spaces - the array

Output
Print how many numbers in the array are larger than their neighbours

Constraints
1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
6
-26 -25 -28 31 2 27

Output
2
*/

using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(input[i]);
        }
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            if (IsLargerThanNeighbours(array, i)) result++;
        }

        Console.WriteLine(result);
    }

    private static bool IsLargerThanNeighbours(int[] array, int position)
    {
        if (position <= 0 || position >= array.Length - 1)
        {
            return false;
        }
        else
        {
            if (array[position] > array[position + 1] && array[position] > array[position - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}