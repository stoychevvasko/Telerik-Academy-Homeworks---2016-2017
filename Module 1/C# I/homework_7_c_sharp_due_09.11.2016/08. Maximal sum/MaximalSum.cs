/**
Maximal sum

Description

Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.

Can you do it with only one loop (with single scan through the elements of the array)?
Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output

Print the maximal sum of consecutive numbers
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
10
2
3
-6
-1
2
-1
6
4
-8
8	11
**/

using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }


        int endOfMaxSeq = 0, currentStart = 0, currentMax = array[0], currentMaxEnd = array[0];
        int count = 1;

        for (int i = 0; i < n; i++)
        {
            if (currentMaxEnd < 0)
            {
                currentMaxEnd = array[i];
                currentStart = i;
                count = 1;
            }
            else
            {
                currentMaxEnd += array[i];
            }

            if (currentMaxEnd >= currentMax)
            {
                currentMax = currentMaxEnd;
                endOfMaxSeq = i;
                count++;
            }
        }
        Console.WriteLine(currentMax);
    }
}