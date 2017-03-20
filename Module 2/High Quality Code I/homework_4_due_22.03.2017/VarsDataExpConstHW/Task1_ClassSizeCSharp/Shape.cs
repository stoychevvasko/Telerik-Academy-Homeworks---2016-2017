//// <copyright file="Shape.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1
{
    using System;
    using Contracts.Interfaces;

    /// <summary>Represents a primitive shape in two-dimensional space.</summary>
    public class Shape : IShape, IRotatable
    {
        /// <summary>Holds the height dimension value of the <see cref="Shape"/>.</summary>
        private double height;

        /// <summary>Holds the width dimension value of the <see cref="Shape"/>.</summary>
        private double width;

        /// <summary>Initializes a new instance of the <see cref="Shape"/> class.</summary><param name="height">Height dimension value for the new <see cref="Shape"/> object.</param><param name="width">Width dimension value for the new <see cref="Shape"/> object.</param>
        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        /// <summary>Gets or sets the height dimension value of the <see cref="Shape"/>.</summary>
        public double Height
        {
            get
            {
                Shape.Validations.Property.Getter.Height.Validate(this.height);
                return this.height;
            }

            set
            {
                Shape.Validations.Property.Setter.Height.Validate(value);
                this.height = value;
            }
        }

        /// <summary>Gets or sets the width dimension value of the <see cref="Shape"/>.</summary>
        public double Width
        {
            get
            {
                Shape.Validations.Property.Getter.Width.Validate(this.width);
                return this.width;
            }

            set
            {
                Shape.Validations.Property.Setter.Width.Validate(value);
                this.width = value;
            }
        }

        /// <summary>Rotates a <see cref="Shape"/> object in two-dimensional space.</summary><param name="original">Initial dimensions before rotation.</param><param name="rotationAngle">Rotation factor.</param><returns>A resulting new <see cref="Shape"/> of transformed dimensions.</returns>
        public IRotatable Rotate(IRotatable original, double rotationAngle)
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

        /// <summary>Shape-specific validation logic.</summary>
        internal static class Validations
        {
            /// <summary>Validations called within properties of the <see cref="Shape"/> class.</summary>
            public static class Property
            {
                /// <summary>Validations for the getter side of Shape properties.</summary>
                public static class Getter
                {
                    /// <summary>Validations for the Height property getter.</summary>
                    public static class Height
                    {
                        /// <summary>Throws if 2D shape height dimension is invalid get value.</summary><param name="height">The height dimension of a simple 2D shape.</param>
                        public static void Validate(double height)
                        {
                            if (height <= 0)
                            {
                                throw new ArgumentOutOfRangeException(
                                    string.Format($"Shape state corrupted! Found invalid height {height}"));
                            }
                        }
                    }

                    /// <summary>Validations for the Width property getter.</summary>
                    public static class Width
                    {
                        /// <summary>Throws if 2D shape width dimension is invalid get value.</summary><param name="width">The width dimension of a simple 2D shape.</param>
                        public static void Validate(double width)
                        {
                            if (width <= 0)
                            {
                                throw new ArgumentOutOfRangeException(
                                    string.Format($"Shape state corrupted! Found invalid width {width}"));
                            }
                        }
                    }
                }

                /// <summary>Validations for the setter side of Shape properties.</summary>
                public static class Setter
                {
                    /// <summary>Validations for the Height property setter.</summary>
                    public static class Height
                    {
                        /// <summary>Throws if 2D shape height dimension is invalid set value.</summary><param name="height">The height dimension of a simple 2D shape.</param>
                        public static void Validate(double height)
                        {
                            if (height <= 0)
                            {
                                throw new Exception(
                                    string.Format($"Invalid dimensions! Cannot set height: {height}"));
                            }
                        }
                    }

                    /// <summary>Validations for the Height property setter.</summary>
                    public static class Width
                    {
                        /// <summary>Throws if 2D shape width dimension is invalid set value.</summary><param name="width">The width dimension of a simple 2D shape.</param>
                        public static void Validate(double width)
                        {
                            if (width <= 0)
                            {
                                throw new ArgumentOutOfRangeException(
                                    string.Format($"Invalid dimensions! Cannot set width: {width}"));
                            }
                        }
                    }
                }
            }
        }
    }
}
