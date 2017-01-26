/**
MMSA (Min, Max, Sum, Average) of N Numbers

Description

Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).

The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
The output is like in the examples below.
Input

On the first line, you will receive the number N.
On each of the next N lines, you will receive a single integer number.
Output

You output must always consist of exactly 4 lines - the minimal element on the first line, the maximal on the second, the sum on the third and the average on the fourth, in the following format:
min=3.00
max=6.00
sum=9.00
avg=4.50
Constraints

1 <= N <= 1000
All numbers will be valid integer numbers that will be in the range [-10000, 10000]
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
3
2
5
1	min=1.00
max=5.00
sum=8.00
avg=2.67
3
2
-1
4	min=-1.00
max=4.00
sum=5.00
avg=1.67
**/

using System;

class MMSAOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal[] numbers = new decimal[n];
        for (int i = 1; i < n+1; i++)
        {
            numbers[i - 1] = decimal.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        decimal min = numbers[0];
        decimal max = numbers[numbers.Length - 1];
        decimal sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        decimal avg = (decimal)sum / (decimal)n;
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}