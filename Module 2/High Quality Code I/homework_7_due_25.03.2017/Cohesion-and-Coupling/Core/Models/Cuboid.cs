//// <copyright file="Cuboid.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace CohesionAndCoupling.Core.Models
{
    using System;
    using Contracts.Interfaces;

    /// <summary>Represents a cuboid shape in three-dimensional space.</summary>
    internal class Cuboid : ICuboid
    {
        /// <summary>Holds depth dimension of a <see cref="Cuboid"/> shape.</summary>
        private double depth;

        /// <summary>Holds height dimension of a <see cref="Cuboid"/> shape.</summary>
        private double height;

        /// <summary>Holds width dimension of a <see cref="Cuboid"/> shape.</summary>
        private double width;

        /// <summary>Initializes a new instance of the <see cref="Cuboid"/> class using default values.</summary>
        public Cuboid()
            : this(1.0f, 1.0f, 1.0f)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Cuboid"/> class.</summary><param name="depth">Cuboid depth dimension.</param><param name="height">Cuboid height dimension.</param><param name="width">Cuboid width dimension.</param>
        public Cuboid(double depth, double height, double width)
        {
            this.Depth = depth;
            this.Height = height;
            this.Width = width;
        }

        /// <summary>Gets or sets the depth dimension of a <see cref="Cuboid"/> shape.</summary>
        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid cuboid depth!");
                }

                this.depth = value;
            }
        }

        /// <summary>Gets or sets the height dimension of a <see cref="Cuboid"/> shape.</summary>
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
                    throw new ArgumentOutOfRangeException("Invalid cuboid height!");
                }

                this.height = value;
            }
        }

        /// <summary>Gets or sets the width dimension of a <see cref="Cuboid"/> shape.</summary>
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
                    throw new ArgumentOutOfRangeException("Invalid cuboid width!");
                }

                this.width = value;
            }
        }

        /// <summary>Calculates the XY diagonal of a cuboid shape.</summary><returns>A <see cref="double"/> value as result.</returns>
        public double CalcDiagonalXY()
        {
            double distance = Point2D.CalcDistance(0, 0, this.Width, this.Height);
            return distance;
        }

        /// <summary>Calculates the XYZ diagonal of a cuboid shape.</summary><returns>A <see cref="double"/> value as result.</returns>
        public double CalcDiagonalXYZ()
        {
            double distance = Point3D.CalcDistance(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        /// <summary>Calculates the XZ diagonal of a cuboid shape.</summary><returns>A <see cref="double"/> value as result.</returns>
        public double CalcDiagonalXZ()
        {
            double distance = Point2D.CalcDistance(0, 0, this.Width, this.Depth);
            return distance;
        }

        /// <summary>Calculates the YZ diagonal of a cuboid shape.</summary><returns>A <see cref="double"/> value as result.</returns>
        public double CalcDiagonalYZ()
        {
            double distance = Point2D.CalcDistance(0, 0, this.Height, this.Depth);
            return distance;
        }

        /// <summary>Calculates the volume of the cuboid shape.</summary><returns>A <see cref="double"/> value as result.</returns>
        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }
    }
}
