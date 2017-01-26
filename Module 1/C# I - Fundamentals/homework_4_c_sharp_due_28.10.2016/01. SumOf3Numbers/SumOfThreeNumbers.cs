/**
Sum of 3 numbers
Description

Write a program that reads 3 real numbers from the console and prints their sum.
Input

    On the first line, you will receive the number a
    On the second line, you will receive the number b
    On the third line, you will receive the number c

Output

Your output should consist only of a single line - the sum of the three numbers.
Constraints

    a, b and c will always be valid real numbers between -1000 and 1000, inclusive
    Time limit: 0.1s
    Memory limit: 16MB

Sample tests
Input 	Output
1
2
3 	6
-2
0
3 	1
5.5
4.5
20.1 	30.1
**/

using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        Console.WriteLine(a + b + c);
    }
}