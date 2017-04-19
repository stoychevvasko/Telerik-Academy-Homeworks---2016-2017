// <copyright file="ExceptionsHomework.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>

namespace ExceptionsHomeworkProject
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>Contains logic pertaining to Task 02 of this homework.</summary>
    public class ExceptionsHomework
    {
        /// <summary>Returns a subsequence from an array of generic elements.</summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="arr">array of generic items</param>
        /// <param name="startIndex">beginning of subsequence</param>
        /// <param name="count">number of elements in the subsequence</param>
        /// <returns>new array containing the subsequence of elements</returns>
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (startIndex < 0 || startIndex > arr.Length)
            {
                throw new ArgumentOutOfRangeException("Start index out of array range!");
            }

            if (startIndex + count > arr.Length)
            {
                throw new IndexOutOfRangeException("Index exceeded array length!");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        /// <summary>Extracts a substring from an index count until the end of the original string.</summary>
        /// <param name="str">original string</param>
        /// <param name="count">index for substring</param>
        /// <returns>resulting substring</returns>
        public static string ExtractEnding(string str, int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("Count cannot be negative!");
            }

            if (count >= str.Length)
            {
                return str;
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        /// <summary>Checks if a number is prime.</summary>
        /// <param name="number">integer to check if prime</param>
        /// <returns>true if prime, false if not prime</returns>
        public static bool CheckPrime(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Number cannot be non-positive!");
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }        
    }
}