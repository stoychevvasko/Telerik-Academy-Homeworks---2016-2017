using System;

namespace Problem_04
{
    /// <summary>
    /// Provides custom mathematical calculations for the <see cref="decimal"/> type.
    /// </summary>
    public static class Calculate
    {
        /// <summary>
        /// Returns <see cref="decimal"/> square root from x calculated using Isaac Newton's method.
        /// </summary>
        /// <param name="x">base number</param>
        /// <param name="epsilon">accuracy of calculation of the root of x</param>
        /// <returns><see cref="decimal"/> square root from x</returns>
        private static decimal Sqrt(decimal x, decimal epsilon = 0.0M)
        {
            if (x < 0) throw new OverflowException("Cannot calculate square root from a negative number");

            decimal current = (decimal)Math.Sqrt((double)x), previous;
            do
            {
                previous = current;
                if (previous == 0.0M) return 0;
                current = (previous + x / previous) / 2;
            }
            while (Math.Abs(previous - current) > epsilon);
            return current;
        }

        /// <summary>
        /// Returns <see cref="decimal"/> Euclidean distance between 3D points calculated using the Pythagorean formula.
        /// </summary>
        /// <param name="start">start point as <see cref="Point3D"/></param>
        /// <param name="end">start point as <see cref="Point3D"/></param>
        /// <returns>simple distance as <see cref="decimal"/></returns>
        public static decimal Distance(Point3D start, Point3D end)
        {
            return Calculate.Sqrt(
                      (end.X - start.X) * (end.X - start.X)
                    + (end.Y - start.Y) * (end.Y - start.Y)
                    + (end.Z - start.Z) * (end.Z - start.Z)
                      );
        }
    }
}
