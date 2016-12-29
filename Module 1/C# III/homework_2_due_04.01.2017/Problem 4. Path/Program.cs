/*

Problem 4. Path

* Create a class Path to hold a sequence of points in the 3D space.
* Create a static class PathStorage with static methods to save and load paths from a text file.
* Use a file format of your choice.
*/

using System;
using System.Collections.Generic;

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

            pointA = new Point3D(1, 1, 1);
            pointB = new Point3D(2, 2, 2);
            pointC = new Point3D(3, 3, 3);
            Path testPath1 = new Path(pointA).AddPoint(pointB).AddPoint(pointC);

            Console.WriteLine(testPath);
            Console.WriteLine(testPath1);
            string filePath = "..\\..\\someTestPaths.path";
            PathStorage.SavePathToFile(testPath, filePath);
            PathStorage.SavePathToFile(testPath1, filePath);
            Console.WriteLine("Saved to file: {0} - successful", filePath);

            string filePath2 = filePath + "Copy";
            List<Path> list = PathStorage.LoadPathsFromFile(filePath);
            foreach (var item in list)
            {
                PathStorage.SavePathToFile(item, filePath2);
            }
            Console.WriteLine("Saved to file: {0} - successful", filePath2);
        }
    }
}
