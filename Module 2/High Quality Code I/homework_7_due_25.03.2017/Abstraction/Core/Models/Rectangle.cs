//// <copyright file="Rectangle.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Abstraction.Core.Models
{
    using System;
    using Contracts.Interfaces;

    /// <summary>Represents a generalized rectangle shape.</summary>
    internal class Rectangle : IFigure, IRectangle
    {
        /// <summary>Holds the height of the rectangle's side.</summary>
        private double height;

        /// <summary>
        /// Holds the width of the rectangle's side.
        /// </summary>
        private double width;

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
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid height value!");
                }

                this.height = value;
            }
        }

        /// <summary>Gets or sets the width of the rectangle's side.</summary>
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid width value!");
                }

                this.width = value;
            }
        }

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
