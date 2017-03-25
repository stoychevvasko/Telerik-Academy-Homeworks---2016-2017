//// <copyright file="Point2D.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace CohesionAndCoupling.Core.Models
{
    using System;

    /// <summary>Represents a simplified two-dimensional geometrical point.</summary>
    internal class Point2D
    {
        /// <summary>Calculates the distance between two points in two-dimensional space.</summary><param name="x1">Start point's x-coordinate.</param><param name="y1">Start point's y-coordinate.</param><param name="x2">End point's x-coordinate.</param><param name="y2">End point's y-coordinate.</param><returns>Distance as <see cref="double"/> value calculated using standard formula.</returns>
        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }
    }
}
