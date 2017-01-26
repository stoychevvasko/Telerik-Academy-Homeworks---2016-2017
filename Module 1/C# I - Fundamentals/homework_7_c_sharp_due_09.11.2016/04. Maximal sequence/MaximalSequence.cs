/**
Maximal sequence

Description

Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output

Print the length of the maximal sequence
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
10
2
1
1
2
3
3
2
2
2
1	3
**/

using System;

class MaximalSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int[] lengths = new int[n];

        for (int i = 0; i < n; i++)
        {
            lengths[i] = CountElements(array, i, n);
        }

        Array.Sort(lengths);
        Console.WriteLine(lengths[lengths.Length - 1]);
    }

    static int CountElements(int[] array, int index, int arrayLength)
    {
        if (index + 1 >= arrayLength)
        {
            return 1;
        }
        else if (array[index] != array[index + 1])
        {
            return 1;
        }
        else
        {
            return (1 + CountElements(array, index + 1, arrayLength));
        }
    }
}