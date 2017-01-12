////-----------------------------------------------------------------------
//// <copyright file="Program.cs" company="independent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
////
//// Problem 1. Shapes
////
//// * Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
////
//// * Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure
//// (height* width for rectangle and height* width/2 for triangle).
////
//// * Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement 
//// the CalculateSurface() method.
////
//// * Write a program that tests the behaviour of the CalculateSurface() method for different shapes(Square, Rectangle, Triangle) 
//// stored in an array.
////
namespace Problem_01
{
    using System;

    /// <summary>
    /// Program execution starts here.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main exe.
        /// </summary>
        public static void Main()
        {
            Shape[] arrayOfShapes = new Shape[]
            {
                new Rectangle(1M, 1M),
                new Rectangle(1M, 2M),
                new Triangle(1M, 1M),
                new Triangle(5M, 3M),
                new Square(1M),
                new Square(2.345M),
                new Rectangle(4M, 5M),
                new Triangle(2M, 8M),
                new Square(6M)
            };

            foreach (var shape in arrayOfShapes)
            {
                Console.WriteLine(
                    "{0, -10}  Surface area:   {1, 10}  square units",
                    shape.Type,
                    shape.CalculateSurface().ToString("0.000000"));
            }

            Console.WriteLine();
        }
    }
}
