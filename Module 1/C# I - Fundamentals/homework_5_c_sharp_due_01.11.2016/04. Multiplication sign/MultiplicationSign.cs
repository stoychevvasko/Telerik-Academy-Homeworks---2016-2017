/**
Multiplication sign

Description

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.

Use a sequence of if operators.
Input

On the first three lines, you will receive the three numbers, each on a separate line
Output

Output a single line - the sign of the product of the three numbers
Constraints

The input will always consist of valid floating-point numbers
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
2
5
2	+
2
5
-2	-
-0.5
0
-2	0
**/

using System;

class MultiplicationSign
{
    static void Main()
    {
        decimal num1 = decimal.Parse(Console.ReadLine());
        decimal num2 = decimal.Parse(Console.ReadLine());
        decimal num3 = decimal.Parse(Console.ReadLine());

        if (num1 == 0 || num2 == 0 || num3 == 0)
        {
            Console.WriteLine("0");
        }
        else if (num1 < 0 && (((num2 < 0) && (num3 < 0)) || ((num2 > 0) && (num3 > 0))))
        {
            Console.WriteLine("-");
        }
        else if (num1 < 0 && (((num2 < 0) && (num3 > 0)) || ((num2 > 0) && (num3 < 0))))
        {
            Console.WriteLine("+");
        }
        else if (num1 > 0 && (((num2 < 0) && (num3 < 0)) || ((num2 > 0) && (num3 > 0))))
        {
            Console.WriteLine("+");
        }
        else if (num1 > 0 && (((num2 < 0) && (num3 > 0)) || ((num2 > 0) && (num3 < 0))))
        {
            Console.WriteLine("-");
        }
    }
}