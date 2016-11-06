/**
Quick sort

Description

Write a program that sorts an array of integers using the Quick sort algorithm.

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

class QuickSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        QuickSortAlgo(array, 0, n - 1);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    static void QuickSortAlgo(int[] elements, int left, int right)
    {
        int i = left, j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            QuickSortAlgo(elements, left, j);
        }

        if (i < right)
        {
            QuickSortAlgo(elements, i, right);
        }
    }
}