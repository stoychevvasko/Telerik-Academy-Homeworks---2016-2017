/*
Problem 3. Static class

* Write a static class with a static method to calculate the distance between two points in the 3D space.
*/

namespace Problem_03
{
    class Program
    {
        static void Main()
        {
            Point3D pointA = new Point3D(1, 1, 1);
            Point3D pointB = Point3D.PointZero;
            decimal distance = Calculate.Distance(pointA, pointB);

            System.Console.WriteLine(distance);

            // from Windows 10 Calculator (scientific mode) - Sqrt(3)
            System.Console.WriteLine("1.7320508075688772935274463415059");
        }
    }
}
