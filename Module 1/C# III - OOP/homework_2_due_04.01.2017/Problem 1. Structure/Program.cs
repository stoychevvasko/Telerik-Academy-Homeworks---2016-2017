/*
Problem 1. Structure

* Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
* Implement the ToString() to enable printing a 3D point.
*/

using System;

namespace Problem_01
{
    class Program
    {
        static void Main()
        {
            Point3D testZero = new Point3D(0, 0, 0);
            Point3D testOne = new Point3D(1, 2, 3);
            Point3D testTwo = new Point3D(-12.56M, -1337M, -12321.12321M);

            Console.WriteLine(testZero);
            Console.WriteLine(testOne);
            Console.WriteLine(testTwo);
        }
    }
}
