﻿////-----------------------------------------------------------------------
//// <copyright file="Program.cs" company="independent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
//// 
//// Problem 3. Range Exceptions
//// 
//// * Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//// It should hold error message and a range definition[start … end].
//// 
//// * Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by 
//// entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
//// 
namespace Problem_03
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
            Random rand = new Random();

            //// uncomment to test InvalidRangeException<DateTime>              
            //// while (true)
            //// {
            ////     DateTime now = DateTime.Now;
            ////     DateTime rangeStart = new DateTime(1980, 1, 1);
            ////     DateTime rangeEnd = new DateTime(2013, 12, 31);
            ////     if (now < rangeStart || now > rangeEnd)
            ////     {
            ////         throw new InvalidRangeException<DateTime>("DateTime outside of range [01.01.1980 ... 31.12.2013]", rangeStart, rangeEnd);
            ////     }
            //// }

            //// uncomment to test InvalidRangeException<int>
            //// while (true)
            //// {
            ////     int number = rand.Next(250);
            ////     if (number < 1 || number > 100)
            ////     {
            ////         throw new InvalidRangeException<int>(string.Format("int {0} outside of range [{1},{2}]", number, 1, 100), 1, 100);
            ////     }
            //// }
        }
    }
}
