//// <copyright file="Shape.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1
{
    using System;
    using Contracts.Interfaces;

    /// <summary>Represents a primitive shape in two-dimensional space.</summary>
    public class Shape : IShape, IRotateable
    {
        /// <summary>Holds the height dimension value of the <see cref="Shape"/>.</summary>
        private double height;

        /// <summary>Holds the width dimension value of the <see cref="Shape"/>.</summary>
        private double width;

        /// <summary>Initializes a new instance of the <see cref="Shape"/> class.</summary><param name="height">Height dimension value for the new <see cref="Shape"/> object.</param><param name="width">Width dimension value for the new <see cref="Shape"/> object.</param>
        public Shape(double height, double width)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format($"Constructor cannot Shape with dimensions height: {height}, width: {width}."));
            }

            this.Height = height;
            this.Width = width;
        }

        /// <summary>Gets or sets the height dimension value of the <see cref="Shape"/>.</summary>
        public double Height
        {
            get
            {
                if (this.height <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format($"Shape state corrupted! Found invalid height {this.height}"));
                }

                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format($"Invalid dimensions! Cannot set height: {value}"));
                }

                this.height = value;
            }
        }

        /// <summary>Gets or sets the width dimension value of the <see cref="Shape"/>.</summary>
        public double Width
        {
            get
            {
                if (this.width <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format($"Shape state corrupted! Found invalid width {this.width}"));
                }

                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format($"Invalid dimensions! Cannot set width: {value}"));
                }

                this.width = value;
            }
        }

        /// <summary>Rotates a <see cref="Shape"/> object in two-dimensional space.</summary><param name="original">Initial dimensions before rotation.</param><param name="rotationAngle">Rotation factor.</param><returns>A resulting new <see cref="Shape"/> of transformed dimensions.</returns>
        public IRotateable Rotate(IRotateable original, double rotationAngle)
        {
            var width = original.Width;
            var height = original.Height;

            var absoluteCos = Math.Abs(Math.Cos(rotationAngle));
            var absoluteSin = Math.Abs(Math.Sin(rotationAngle));

            var trasformedWidth = (absoluteCos * width) + (absoluteSin * height);
            var transformedHeight = (absoluteSin * width) + (absoluteCos * height);

            Shape transformedShape = new Shape(trasformedWidth, transformedHeight);

            return transformedShape;
        }
    }
}
