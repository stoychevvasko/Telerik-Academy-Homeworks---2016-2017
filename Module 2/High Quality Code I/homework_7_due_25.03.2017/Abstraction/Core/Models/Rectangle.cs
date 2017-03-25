//// <copyright file="Rectangle.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Abstraction.Core.Models
{
    using Contracts.Interfaces;

    /// <summary>Represents a generalized rectangle shape.</summary>
    internal class Rectangle : IFigure, IRectangle
    {
        /// <summary>Initializes a new instance of the <see cref="Rectangle"/> class using standard values.</summary>
        public Rectangle()
            : this(1.0f, 1.0f)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Rectangle"/> class.</summary><param name="width">Width of rectangle side.</param><param name="height">Height of rectangle side.</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>Gets or sets the height of the rectangle's side.</summary>
        public double Height { get; set; }

        /// <summary>Gets or sets the width of the rectangle's side.</summary>
        public double Width { get; set; }

        /// <summary>Calculates the perimeter of the rectangle.</summary><returns>Perimeter calculated as a <see cref="double"/> value.</returns>
        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>Calculates the surface area of the rectangle.</summary><returns>Surface area calculated as a <see cref="double"/> value.</returns>
        public double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
