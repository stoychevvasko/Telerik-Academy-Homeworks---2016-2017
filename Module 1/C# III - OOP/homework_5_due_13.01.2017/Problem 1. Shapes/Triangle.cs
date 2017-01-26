////-----------------------------------------------------------------------
//// <copyright file="Triangle.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    /// <summary>
    /// Represents a triangle geometrical shape.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="side">The side of the triangle.</param>
        /// <param name="height">The height/altitude of the triangle.</param>
        public Triangle(decimal side, decimal height)
            : base(side, height)
        {
        }

        /// <summary>
        /// Calculates the surface area of a triangle.
        /// </summary>
        /// <returns>Surface area calculation.</returns>
        public override decimal CalculateSurface()
        {
            return (this.Height * this.Width) / 2M;
        }
    }
}
