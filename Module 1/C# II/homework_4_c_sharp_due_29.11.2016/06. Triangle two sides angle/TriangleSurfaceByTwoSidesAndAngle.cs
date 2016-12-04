/*
Triangle surface by two sides and an angle

Description
Write program that calculates the surface of a triangle by given two sides and an angle between them.

Input
On the first line you will receive the length of the first side of the triangle
On the second line you will receive the length of the second side of the triangle
On the third line you will receive the angle between the given sides 
Angle is given in degrees

Output
Print the surface of the rectangle with two digits of precision

Constraints
Input data describes a valid triangle
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
10
7
25

Output
14.79
*/

using System;

class TriangleSurfaceByTwoSidesAndAngle
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angleC = DegreesToRadians(double.Parse(Console.ReadLine()));
        Console.WriteLine("{0:f2}", 0.5 * a * b * Math.Sin(angleC));
    }

    private static double DegreesToRadians(double v)
    {
        return v * (Math.PI / 180d);
    }
}