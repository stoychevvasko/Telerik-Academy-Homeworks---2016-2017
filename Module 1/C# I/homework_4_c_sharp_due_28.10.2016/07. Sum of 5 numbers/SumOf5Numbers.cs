/**
Sum of 5 numbers
Description

Write a program that reads 5 integer numbers from the console and prints their sum.
Input

You will receive 5 numbers on five separate lines.
Output

Your output should consist only of a single line - the sum of the 5 numbers.
Constraints

    All 5 numbers will always be valid integer numbers between -1000 and 1000, inclusive
    Time limit: 0.1s
    Memory limit: 16MB

Sample tests
Input 	Output
1
2
3
4
5 	15
-1
2
-3
4
10 	12
0
0
0
0
0 	0
**/

using System;

class SumOf5Numbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine(a + b + c + d + e);
    }
}