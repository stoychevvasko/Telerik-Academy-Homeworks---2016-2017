﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_04
{
    /// <summary>
    /// Holds a sequence of <see cref="Point3D"/> objects.
    /// </summary>
    public class Path
    {
        /// <summary>
        /// Holds a generic <see cref="List{T}"/> of <see cref="Point3D"/> objects.
        /// </summary>
        private List<Point3D> sequence;

        /// <summary>
        /// Represents a generic <see cref="List{T}"/> of <see cref="Point3D"/> objects.
        /// </summary>
        public List<Point3D> Sequence
        {
            get { return new List<Point3D>(this.sequence); }
            private set { this.sequence = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Path"/> class.
        /// </summary>
        public Path()
        {
            this.Sequence = new List<Point3D>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Path"/> class.
        /// </summary>
        /// <param name="element">a single <see cref="Point3D"/> object</param>
        public Path(Point3D element)
            : this()
        {
            this.AddPoint(element);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Path"/> class.
        /// </summary>
        /// <param name="reverseToString">A <see cref="string"/> parameter in the format of <see cref="Path.ToString"/>.</param>
        public Path(string reverseToString)
        {
            string[] splits = reverseToString.Split('}');
            List<Point3D> result = new List<Point3D>();
            string[] separators = { "{", " ", ",", "}" };
            for (int i = 0; i < 3; i++)
            {
                var item = splits[i];
                var items = item.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                var itemX = items[0];
                var itemY = items[1];
                var itemZ = items[2];
                decimal x = decimal.Parse(itemX);
                decimal y = decimal.Parse(itemY);
                decimal z = decimal.Parse(itemZ);
                Point3D point = new Point3D(x, y, z);
                result.Add(point);
            }
            this.Sequence = result;
        }

        /// <summary>
        /// Adds a <see cref="Path"/> object to the end of the <see cref="Path"/>.
        /// </summary>
        /// <param name="point">a <see cref="Point3D"/> object</param>
        /// <returns>The same <see cref="Path"/> object (<see cref="this"/>) intended for chain-calling.</returns>
        public Path AddPoint(Point3D point)
        {
            this.sequence.Add(point);
            return this;
        }

        /// <summary>
        /// Returns a <see cref="string"/> representation of a <see cref="Path"/> object.
        /// </summary>
        /// <returns>A <see cref="string"/>.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Sequence.Count; i++)
            {
                result.Append(this.Sequence[i].ToString());

                if (i != this.Sequence.Count - 1)
                {
                    result.Append(", ");
                }
            }
            result.Insert(0, '{').Insert(1, ' ').Append(" }");
            return result.ToString();
        }
    }
}
