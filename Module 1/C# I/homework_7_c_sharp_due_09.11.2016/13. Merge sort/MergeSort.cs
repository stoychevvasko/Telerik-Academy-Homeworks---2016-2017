/**
Merge sort

Description

Write a program that sorts an array of integers using the Merge sort algorithm.

Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output

Print the sorted array
Each number should be on a new line
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
6
3
4
1
5
2
6	1
2
3
4
5
6
10
36
10
1
34
28
38
31
27
30
20	1
10
20
27
28
30
31
34
36
38
**/

using System;

class MergeSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        MergeSortAlgo(array);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    static void MergeSortAlgo(int[] array)
    {
        if (array.Length < 2)
        {
            return;
        }

        int[] leftArray = new int[array.Length / 2];
        int[] rightArray = new int[array.Length - leftArray.Length];

        Array.Copy(array, 0, leftArray, 0, leftArray.Length);
        Array.Copy(array, leftArray.Length, rightArray, 0, rightArray.Length);

        MergeSortAlgo(leftArray);
        MergeSortAlgo(rightArray);

        int leftIndex = 0, rightIndex = 0;

        do
        {
            if (leftArray[leftIndex] < rightArray[rightIndex])
            {
                array[leftIndex + rightIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                array[leftIndex + rightIndex] = rightArray[rightIndex];
                rightIndex++;
            }
        }
        while (leftIndex < leftArray.Length && rightIndex < rightArray.Length);

        for (int i = leftIndex; i < leftArray.Length; i++)
        {
            array[i + rightIndex] = leftArray[i];
        }

        for (int i = rightIndex; i < rightArray.Length; i++)
        {
            array[leftIndex + i] = rightArray[i];
        }
    }
}