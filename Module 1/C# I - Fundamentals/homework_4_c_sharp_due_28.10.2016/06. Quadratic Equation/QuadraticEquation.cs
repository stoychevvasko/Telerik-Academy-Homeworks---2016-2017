/**
Quadratic Equation
Description

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Input

    On the first three lines, you will receive the coefficients a, b, and c, each on a separate line in the same order

Output

    If two different real roots exist, print them on two separate lines
        Print the smaller root on the first line
    If only one real root exists, print it on the only output line
    If no real root exists, print the string "no real roots"
    The roots, should they exist, must be printed with precision exactly two digits after the floating point

Constraints

    The input will always consist of valid real numbers in the range [-1000, 1000] and will follow the described format
    Time limit: 0.1s
    Memory limit: 16MB

Sample tests
Input 	Output
2
5
-3 	-3.00
0.50
-1
3
0 	0.00
3.00
-0.5
4
-8 	4.00
5
2
8 	no real roots
**/

using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

        string x1Result = x1.ToString("0.00");
        string x2Result = x2.ToString("0.00");

        if (x1Result == "NaN" && x2Result == "NaN")
        {
            Console.WriteLine("no real roots");
        }
        else if (x1 == x2)
        {
            Console.WriteLine(x1Result);
        }
        else
        {
            if (x1 < x2)
            {
                Console.WriteLine(x1Result);
                Console.WriteLine(x2Result);
            }
            else
            {
                Console.WriteLine(x2Result);
                Console.WriteLine(x1Result);
            }
        }
    }
}