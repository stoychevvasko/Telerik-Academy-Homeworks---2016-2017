/*
Triangle surface by three sides

Description
Write program that calculates the surface of a triangle by given its three sides.

Input
On the first line you will receive the length of the first side of the triangle
On the second line you will receive the length of the second side of the triangle
On the third line you will receive the length of the third side of the triangle

Output
Print the surface of the rectangle with two digits of precision

Constraints
Input data describes a valid triangle
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
11
12
13

Output
61.48
*/

using System;

class TriangleSurfaceByThreeSides
{
    static void Main()
    {
        double firstSide = double.Parse(Console.ReadLine());
        double secondSide = double.Parse(Console.ReadLine());
        double thirdSide = double.Parse(Console.ReadLine());
        double result = CalcTriangleSurface(firstSide, secondSide, thirdSide);
        Console.WriteLine("{0:f2}", result);
    }

    private static double CalcTriangleSurface(double a, double b, double c)
    {
        double s = (a + b + c) / 2.0d;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}