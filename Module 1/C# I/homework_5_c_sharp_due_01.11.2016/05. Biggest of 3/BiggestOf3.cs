/**
Biggest of 3

Description

Write a program that finds the biggest of three numbers that are read from the console.

Input

On the first three lines you will receive the three numbers, each on a separate line.
Output

On the only output line, write the biggest of the three numbers.
Constraints

The three numbers will always be valid floating-point numbers in the range [-200, 200].
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
4
4
4	4
-0.5
-10
0	0
**/

using System;

class BiggestOf3
{
    static void Main()
    {
        decimal[] numbers = new decimal[3];
        numbers[0] = decimal.Parse(Console.ReadLine());
        numbers[1] = decimal.Parse(Console.ReadLine());
        numbers[2] = decimal.Parse(Console.ReadLine());
        Array.Sort(numbers);
        Console.WriteLine(numbers[2]);
    }
}