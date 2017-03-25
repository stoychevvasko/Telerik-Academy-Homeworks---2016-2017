//// <copyright file="Circle.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Abstraction.Core.Models
{
    using System;
    using Contracts.Interfaces;

    /// <summary>Represents a generalized circle shape.</summary>
    internal class Circle : ICircle, IFigure
    {
        /// <summary>Holds the radius of a <see cref="Circle"/> geometrical object.</summary>
        private double radius;

        /// <summary>Initializes a new instance of the <see cref="Circle"/> class with standard values.</summary>
        public Circle()
            : this(1.0f)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Circle"/> class.</summary><param name="radius">Circle radius parameter.</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>Gets or sets the radius of a <see cref="Circle"/> geometrical object.</summary>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid radius!");
                }

                this.radius = value;
            }
        }

        /// <summary>Calculates the perimeter of a circle.</summary><returns>Perimeter length as <see cref="double"/> value.</returns>
        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>Calculates the surface area of a circle.</summary><returns>Surface area as <see cref="double"/> value.</returns>
        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
