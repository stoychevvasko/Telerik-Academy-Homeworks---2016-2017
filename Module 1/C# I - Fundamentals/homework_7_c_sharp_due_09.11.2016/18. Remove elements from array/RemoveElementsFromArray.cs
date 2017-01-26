/**
Remove elements from array

Description

Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order. Print the minimal number of elements that need to be removed in order for the array to become sorted.

Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output

Print the minimal number of elements that need to be removed
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
8
1
4
3
3
6
3
2
3	3
10
14
2
9
8
3
13
17
19
30
1	4
**/

using System;
using System.Collections.Generic;

class RemoveElementsFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        List<int> newArr = new List<int>();
        int maxSeq = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            newArr.Add(1);
        }
        for (int j = 1; j < n; j++)
        {
            for (int k = 0; k < j; k++)
            {
                if ((arr[k] <= arr[j]) && (newArr[j] < (newArr[k] + 1)))
                {
                    newArr[j] = newArr[k] + 1;
                    if (maxSeq < newArr[j])
                    {
                        maxSeq = newArr[j];
                    }
                }
            }
        }
        Console.WriteLine(n - maxSeq);
    }
}
