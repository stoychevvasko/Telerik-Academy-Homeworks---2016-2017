/**
Frequent number

Description

Write a program that finds the most frequent number in an array of N elements.

Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output

Print the most frequent number and how many time it is repeated
Output should be REPEATING_NUMBER (REPEATED_TIMES times)
Constraints

1 <= N <= 1024
0 <= each number in the array <= 10000
There will be only one most frequent number
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
13
4
1
1
4
2
3
4
4
1
2
4
9
3	4 (5 times)
**/

using System;

class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int[] frequency = new int[n];
        int count, value;
        for (int i = 0; i < n; i++)
        {
            count = 0;
            value = numbers[i];
            for (int j = i; j < n; j++)
            {
                if (value == numbers[j])
                {
                    count++;
                }
            }
            frequency[i] = count;
        }
        int maxFrequency = frequency[0];
        int maxIndex = 0;
        for (int i = 0; i < n; i++)
        {
            if (frequency[i] > maxFrequency)
            {
                maxFrequency = frequency[i];
                maxIndex = i;
            }
        }
        Console.WriteLine("{0} ({1} times)", numbers[maxIndex], maxFrequency);
    }
}