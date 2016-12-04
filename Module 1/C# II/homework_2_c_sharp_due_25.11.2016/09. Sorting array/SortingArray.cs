/*
Sorting array

Description
Write a method that returns the maximal element in a portion of array of integers starting 
at given index. Using it write another method that sorts an array in ascending / descending order. 
Write a program that sorts a given array.

Input
On the first line you will receive the number N - the size of the array
On the second line you will receive N numbers separated by spaces - the array

Output
Print the sorted array 
Elements must be separated by spaces

Constraints
1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
6
3 4 1 5 2 6

10
36 10 1 34 28 38 31 27 30 20

Output
1 2 3 4 5 6

1 10 20 27 28 30 31 34 36 38
*/

using System;

class SortingArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] arrayStrings = Console.ReadLine().Split(' ');
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(arrayStrings[i]);
        }
        int[] ascendingNumbers = new int[array.Length];
        (SortViaMax(array, true)).CopyTo(ascendingNumbers, 0);
        Console.WriteLine(String.Join(" ", ascendingNumbers));
    }

    public static int MaxElementIndex(int[] array, int startIndex, int endIndex)
    {
        int result = startIndex;

        for (int i = startIndex; i <= endIndex; i++)
        {
            if (array[i] >= array[result])
            {
                result = i;
            }
        }

        return result;
    }

    public static int[] SortViaMax(int[] array, bool isAscending)
    {
        if (isAscending)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int maxIndex = MaxElementIndex(array, 0, i);
                int temp = array[i];
                array[i] = array[maxIndex];
                array[maxIndex] = temp;
            }
        }
        else if (!isAscending)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int maxIndex = MaxElementIndex(array, i, array.Length - 1);
                int temp = array[i];
                array[i] = array[maxIndex];
                array[maxIndex] = temp;
            }
        }

        return array;
    }
}
