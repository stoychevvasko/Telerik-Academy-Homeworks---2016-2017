/**
Rectangles

Description

Write an expression that calculates rectangle’s area and perimeter by given width and height. The width and height should be read from the console.

Input

The input will consist of 2 lines:
On the first line, you will receive a floating-point number that will represent the width of the rectangle.
On the second line, you will receive another floating-point number that will represent the height of the rectangle.
Output

Output a single line - the rectangle's area and perimeter, separated by a whitespace.
Print the area and perimeter values with exactly 2-digits precision after the floating point
Constraints

The width and height will always be valid floating-point numbers.
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
2.5
3	7.50 11.00
5
5	25.00 20.00
3
4	12.00 14.00
**/

using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:0.00} {1:0.00}", width * height, 2.0 * (width + height));
    }
}