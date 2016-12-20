using System.Text;

namespace Problem_01
{
    /// <summary>
    /// Represents a geometric point in three-dimensional space.
    /// </summary>
    public struct Point3D
    {
        /// <summary>
        /// Holds the x-axis coordinate value.
        /// </summary>
        private decimal x;

        /// <summary>
        /// Holds the y-axis coordinate value.
        /// </summary>
        private decimal y;

        /// <summary>
        /// Holds the z-axis coordinate value.
        /// </summary>
        private decimal z;

        /// <summary>
        /// Initializes a new <see cref="Point3D"/> struct.
        /// </summary>
        /// <param name="xValue">X-axis coordinate as <see cref="decimal"/></param>
        /// <param name="yValue">Y-axis coordinate as <see cref="decimal"/></param>
        /// <param name="zValue">Z-axis coordinate as <see cref="decimal"/></param>
        public Point3D(decimal xValue, decimal yValue, decimal zValue)
            : this()
        {
            this.X = xValue;
            this.Y = yValue;
            this.Z = zValue;
        }

        /// <summary>
        /// Represents the x-axis coordinate value of a point in 3D Euclidian space.
        /// </summary>
        public decimal X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        /// <summary>
        /// Represents the y-axis coordinate value of a point in 3D Euclidian space.
        /// </summary>
        public decimal Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        /// <summary>
        /// Represents the z-axis coordinate value of a point in 3D Euclidian space.
        /// </summary>
        public decimal Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        /// <summary>
        /// Returns a string representation of 
        /// </summary>
        /// <returns>a <see cref="string"/></returns>
        public override string ToString()
        {
            return new StringBuilder()
                .Append("{ ")
                .AppendFormat("{0}, {1}, {2}", this.X, this.Y, this.Z)
                .Append(" }")
                .ToString();

        }
    }
}
