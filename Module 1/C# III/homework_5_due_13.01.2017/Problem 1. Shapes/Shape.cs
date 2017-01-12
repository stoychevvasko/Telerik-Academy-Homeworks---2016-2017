////-----------------------------------------------------------------------
//// <copyright file="Shape.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    using System;

    /// <summary>
    /// Represents a generalized geometrical shape.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Holds the width value.
        /// </summary>
        private decimal width;

        /// <summary>
        /// Holds the height value;
        /// </summary>
        private decimal height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        /// <param name="width">The width value.</param>
        /// <param name="height">The height value.</param>
        public Shape(decimal width, decimal height)
        {
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Gets the object type in shortened form.
        /// </summary>
        public string Type
        {
            get
            {
                string result = this.GetType().ToString();
                return result.Substring(result.LastIndexOf('.') + 1);
            }
        }

        /// <summary>
        /// Gets or sets the width value.
        /// </summary>
        public decimal Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Invalid width!");
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height value.
        /// </summary>
        public decimal Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Invalid height!");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// Calculates the surface area of a generalized geometrical shape.
        /// </summary>
        /// <returns>A surface area number.</returns>
        public virtual decimal CalculateSurface()
        {
            throw new NotImplementedException("Abstract shapes cannot calculate surface area!");
        }
    }
}