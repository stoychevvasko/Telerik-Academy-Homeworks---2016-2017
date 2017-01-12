////-----------------------------------------------------------------------
//// <copyright file="Square.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    /// <summary>
    /// Represents a square geometrical shape.
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="side">A square's side value (height=width).</param>
        public Square(decimal side)
            : base(side, side)
        {
        }
    }
}
