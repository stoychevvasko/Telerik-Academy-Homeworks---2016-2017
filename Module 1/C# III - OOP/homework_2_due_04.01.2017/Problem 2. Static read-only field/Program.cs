/*
Problem 2. Static read-only field

* Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
* Add a static property to return the point O.
*/

using System;

namespace Problem_02
{
    class Program
    {
        static void Main()
        {
            Point3D test = Point3D.PointZero;
            Console.WriteLine(test);
        }
    }
}
