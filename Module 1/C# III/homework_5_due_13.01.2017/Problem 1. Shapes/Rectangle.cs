////-----------------------------------------------------------------------
//// <copyright file="Rectangle.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    /// <summary>
    /// Represents a rectangle geometrical shape.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">The rectangle's width value.</param>
        /// <param name="height">The rectangle's height value.</param>
        public Rectangle(decimal width, decimal height)
            : base(width, height)
        {
        }

        /// <summary>
        /// Calculates the surface area of a rectangle.
        /// </summary>
        /// <returns>Surface area calculation.</returns>
        public override decimal CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
