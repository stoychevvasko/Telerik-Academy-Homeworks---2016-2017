/**
Circle
Description

Write a program that reads from the console the radius r of a circle and prints its perimeter and area, rounded and formatted with 2 digits after the decimal point.
Input

    On the only line of the input you will receive the radius of the circle - r

Output

    You should print one line only: the perimeter and the area of the circle, separated by a whitespace, and with 2 digits precision

Constraints

    The radius r will always be a valid and positive real number
    Time limit: 0.1s
    Memory limit: 16MB

Sample tests
Input 	Output
2 	12.57 12.57
3.5 	21.99 38.48
**/

using System;
using System.Globalization;
using System.Threading;

class Circle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        decimal r = decimal.Parse(Console.ReadLine());
        decimal perimeter = 2 * (decimal)Math.PI * r;
        decimal area = (decimal)Math.PI * r * r;
        Console.WriteLine("{0} {1}", perimeter.ToString("0.00"), area.ToString("0.00"));        
    }
}