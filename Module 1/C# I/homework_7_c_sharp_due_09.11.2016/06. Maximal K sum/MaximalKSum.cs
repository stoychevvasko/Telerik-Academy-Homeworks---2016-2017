/**
Maximal K sum

Description

Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.

Input

On the first line you will receive the number N
On the second line you will receive the number K
On the next N lines the numbers of the array will be given
Output

Print the maximal sum of K elements in the array
Constraints

1 <= N <= 1024
1 <= K <= N
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
8
3
3
2
3
-2
5
4
2
7	16
**/

using System;

class MaximalKSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        decimal[] array = new decimal[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = decimal.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        decimal result = 0;
        for (int i = 0; i < k; i++)
        {
            result += array[array.Length - 1 - i];
        }
        Console.WriteLine(result);
    }
}