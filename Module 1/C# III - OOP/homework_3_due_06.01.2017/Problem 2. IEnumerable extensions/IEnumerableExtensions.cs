using System;
using System.Collections.Generic;

namespace Problem_02
{
    /// <summary>
    /// Provides extended functionality for <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Retrieves the sum of a <see cref="IEnumerable{T}"/> collection.
        /// </summary>
        /// <typeparam name="T">A generic type.</typeparam>
        /// <param name="collection">An <see cref="IEnumerable{T}"/> collection.</param>
        /// <returns>Sum of the generic collection.</returns>
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic result = 0;

            foreach (var item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        /// <summary>
        /// Retrieves the product of a <see cref="IEnumerable{T}"/> collection.
        /// </summary>
        /// <typeparam name="T">A generic type.</typeparam>
        /// <param name="collection">An <see cref="IEnumerable{T}"/> collection.</param>
        /// <returns>Product of the generic collection.</returns>
        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic result = 1;

            foreach (var item in collection)
            {
                result *= (dynamic)item;

                if (result == 0)
                {
                    return result;
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves the minimal element of a <see cref="IEnumerable{T}"/> collection.
        /// </summary>
        /// <typeparam name="T">A generic type.</typeparam>
        /// <param name="collection">An <see cref="IEnumerable{T}"/> collection.</param>
        /// <returns>Minimal element of the generic collection.</returns>
        public static T Min<T>(this IEnumerable<T> collection)
        {
            dynamic result = long.MaxValue;

            foreach (var item in collection)
            {
                if (item < result)
                    result = item;
            }

            return result;
        }

        /// <summary>
        /// Retrieves the maximal element of a <see cref="IEnumerable{T}"/> collection.
        /// </summary>
        /// <typeparam name="T">A generic type.</typeparam>
        /// <param name="collection">An <see cref="IEnumerable{T}"/> collection.</param>
        /// <returns>Maximal element of the generic collection.</returns>
        public static T Max<T>(this IEnumerable<T> collection)
        {
            dynamic result = long.MinValue;

            foreach (var item in collection)
            {
                if (item > result)
                    result = item;
            }

            return result;
        }

        /// <summary>
        /// Retrieves the average element of a <see cref="IEnumerable{T}"/> collection.
        /// </summary>
        /// <typeparam name="T">A generic type.</typeparam>
        /// <param name="collection">An <see cref="IEnumerable{T}"/> collection.</param>
        /// <returns>Average element of the generic collection.</returns>
        public static T Average<T>(this IEnumerable<T> collection)
        {
            dynamic result = 0, counter = 0;

            foreach (var item in collection)
            {
                result += item;
                counter++;
            }

            if (counter == 0)
            {
                throw new ArgumentException("Empty collection!");
            }

            return result / counter;
        }
    }
}