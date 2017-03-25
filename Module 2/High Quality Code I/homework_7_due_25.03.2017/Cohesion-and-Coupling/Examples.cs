//// <copyright file="Examples.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace CohesionAndCoupling
{
    using System;
    using Core.Models;

    /// <summary>Contains sample usage of classes.</summary>
    internal class Examples
    {
        /// <summary>Main executable starts here.</summary>
        public static void Main()
        {
            Console.WriteLine(Filename.GetExtension("example"));
            Console.WriteLine(Filename.GetExtension("example.pdf"));
            Console.WriteLine(Filename.GetExtension("example.new.pdf"));

            Console.WriteLine(Filename.Get("example"));
            Console.WriteLine(Filename.Get("example.pdf"));
            Console.WriteLine(Filename.Get("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Point2D.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", Point3D.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Cuboid myShape = new Cuboid(5, 4, 3);

            Console.WriteLine("Volume = {0:f2}", myShape.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", myShape.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", myShape.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", myShape.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", myShape.CalcDiagonalYZ());
        }
    }
}
