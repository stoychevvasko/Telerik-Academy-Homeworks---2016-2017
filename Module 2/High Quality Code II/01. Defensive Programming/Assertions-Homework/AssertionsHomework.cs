// <copyright file="AssertionsHomework.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>

namespace AssertionsHomeworkProject
{
    using System;
    using System.Diagnostics;

    /// <summary>Homework assignment due June 8, 2014.</summary>
    internal class AssertionsHomework
    {
        /// <summary>Performs a generic selection sort algorithm.</summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="arr">an array of generic elements</param>
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array reference cannot point to null!");

            int len = arr.Length;
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            // assertion whether the array is sorted
            for (int i = 0; i < len - 1; i++)
            {
                Debug.Assert(arr[i].CompareTo(arr[i + 1]) <= 0, "The array is not sorted!");
            }
        }

        /// <summary>Finds the index of a search item in a sorted generic-type array.</summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="arr">array of generic-type items</param>
        /// <param name="value">search item</param>
        /// <returns>index of item if found or -1 if not found</returns>
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array reference cannot point to null!");
            Debug.Assert(value != null, "Sought value cannot be null!");

            // binary search algorithm requires array to be sorted already
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Debug.Assert(arr[i].CompareTo(arr[i + 1]) <= 0, "The array is not sorted!");
            }

            var result = BinarySearch(arr, value, 0, arr.Length - 1);
            Debug.Assert(result < -1, "Binary search cannot produce invalid result index!");
            return result;
        }

        /// <summary>Performs a generic binary search within a specific index range.</summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="arr">array of generic-type items</param>
        /// <param name="value">search item</param>
        /// <param name="startIndex">start index for the search</param>
        /// <param name="endIndex">end index for the search</param>
        /// <returns>index of search item if found or -1 otherwise</returns>
        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(startIndex <= endIndex, "Start index should be less than or equal to end index!");
            Debug.Assert(startIndex >= 0, "Start index should be non-negative!");
            Debug.Assert(startIndex <= arr.Length - 1, "Start index cannot exceed the array's length!");
            Debug.Assert(endIndex >= 0, "End index should be non-negative!");
            Debug.Assert(endIndex <= arr.Length - 1, "End index cannot exceed the array's length!");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    Debug.Assert(midIndex >= 0, "midIndex must be a non-negative number!");
                    Debug.Assert(midIndex <= arr.Length - 1, "midIndex cannot exceed the array's length!");
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    startIndex = midIndex + 1;
                }
                else
                {
                    endIndex = midIndex - 1;
                }
            }

            return -1;
        }

        /// <summary>Finds the minimal element's index in an array of generic-type elements.</summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="arr">an array of any number of T-type elements</param>
        /// <param name="startIndex">starting index for the search</param>
        /// <param name="endIndex">ending index for the search</param>
        /// <returns>index of the element if found, otherwise -1</returns>
        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null!");
            Debug.Assert(startIndex >= 0, "Start index should be positive!");
            Debug.Assert(endIndex >= 0, "End index should be positive!");
            Debug.Assert(endIndex <= arr.Length - 1, "End index should be smaller than the length of the array!");
            Debug.Assert(startIndex <= endIndex, "Start index should be smaller than or equal to end index!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            for (int i = startIndex + 1; i < endIndex; i++)
            {
                Debug.Assert(arr[minElementIndex].CompareTo(arr[i]) <= 0, "The element" + arr[minElementIndex] + " is not the smallest!");
            }

            return minElementIndex;
        }

        /// <summary>Swaps two generic-type variables' values.</summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="x">first parameter for swap</param>
        /// <param name="y">second parameter for swap</param>
        private static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null, "Reference to left element cannot be null!");
            Debug.Assert(y != null, "Reference to right element cannot be null!");

            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}