/**
Selection sort

Description

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

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

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal[] array = new decimal[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = decimal.Parse(Console.ReadLine());
        }
        decimal minNum, swapNum;
        int minNumIndex;
        for (int i = 0; i < n; i++)
        {
            minNum = array[i];
            minNumIndex = i;
            for (int j = i; j < n; j++)
            {
                if (minNum > array[j])
                {
                    minNum = array[j];
                    minNumIndex = j;
                }
            }
            swapNum = array[minNumIndex];
            array[minNumIndex] = array[i];
            array[i] = swapNum;
        }
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}