//// <copyright file="FiguresExample.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Abstraction
{
    using System;
    using Core.Models;

    /// <summary>Sample figure usage.</summary>
    internal class FiguresExample
    {
        /// <summary>Main program executable starts here.</summary>
        public static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine("I am a circle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", circle.CalcPerimeter(), circle.CalcSurface());

            Rectangle rect = new Rectangle(2, 3);
            Console.WriteLine("I am a rectangle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", rect.CalcPerimeter(), rect.CalcSurface());
        }
    }
}
