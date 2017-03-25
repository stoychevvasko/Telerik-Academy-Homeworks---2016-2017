//// <copyright file="Point3D.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace CohesionAndCoupling.Core.Models
{
    using System;

    /// <summary>Represents a generalized point in three-dimensional space.</summary>
    internal class Point3D
    {
        /// <summary>Calculates the distance between two points in three-dimensional space.</summary><param name="x1">Start point's x-coordinate.</param><param name="y1">Start point's y-coordinate.</param><param name="z1">Start point's z-coordinate.</param><param name="x2">End point's x-coordinate.</param><param name="y2">End point's y-coordinate.</param><param name="z2">End point's z-coordinate.</param><returns>Distance between the two points as <see cref="double"/> value, calculated via standard formula.</returns>
        public static double CalcDistance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
            return distance;
        }
    }
}
