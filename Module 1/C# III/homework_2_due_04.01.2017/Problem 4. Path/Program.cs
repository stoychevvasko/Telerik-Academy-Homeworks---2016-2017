/*

Problem 4. Path

* Create a class Path to hold a sequence of points in the 3D space.
* Create a static class PathStorage with static methods to save and load paths from a text file.
* Use a file format of your choice.
*/

namespace Problem_04
{
    class Program
    {
        static void Main()
        {
            Point3D pointA = Point3D.PointZero,
                    pointB = new Point3D(1, 1, 1),
                    pointC = new Point3D(2, 2, 2);

            Path testPath = new Path(pointA).AddPoint(pointB).AddPoint(pointC);
            System.Console.WriteLine(testPath);

        }
    }
}
