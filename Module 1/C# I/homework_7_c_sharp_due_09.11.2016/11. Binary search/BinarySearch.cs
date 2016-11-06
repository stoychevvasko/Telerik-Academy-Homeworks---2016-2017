/**
Binary search

Description

Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.

Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
On the last line you will receive the number X
Output

Print the index where X is in the array
If there is more than one occurence print the first one
If there are no occurences print -1
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
10
1
2
4
8
16
31
32
64
77
99
32	6
**/

using System;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine(BinarySearchAlgo(array, x));
    }

    static private int BinarySearchAlgo(int[] array, int elementSought)
    {
        int upperLimit = array.Length - 1;
        int lowerLimit = 0;

        while (upperLimit >= lowerLimit)
        {
            int middle = (lowerLimit + upperLimit) / 2;

            if (array[middle] < elementSought)
            {
                lowerLimit = middle + 1;
            }
            else if (array[middle] > elementSought)
            {
                upperLimit = middle - 1;
            }
            else
            {
                return middle;
            }
        }
        return -1;
    }
}