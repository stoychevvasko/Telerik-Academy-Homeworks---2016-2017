////-----------------------------------------------------------------------
//// <copyright file="InvalidRangeException.cs" company="independent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_03
{
    using System;

    /// <summary>
    /// Provides custom generic-type exception functionality.
    /// </summary>
    /// <typeparam name="T">A generic type.</typeparam>
    public class InvalidRangeException<T> : ApplicationException
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// Holds the error message itself.
        /// </summary>
        private string errorMessage;

        /// <summary>
        /// Holds the start of the range.
        /// </summary>
        private T start;

        /// <summary>
        /// Holds the end of the range.
        /// </summary>
        private T end;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRangeException{T}"/> class.
        /// </summary>
        /// <param name="start">The start of the allowed range.</param>
        /// <param name="end">The end of the allowed range.</param>
        public InvalidRangeException(T start, T end)
            : this(null, start, end, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRangeException{T}"/> class.
        /// </summary>
        /// <param name="message">The exception message itself.</param>
        /// <param name="start">The start of the allowed range.</param>
        /// <param name="end">The end of the allowed range.</param>
        /// <param name="innerException">The inner exception object.</param>
        public InvalidRangeException(string message, T start, T end, Exception innerException)
            : base(message, innerException)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRangeException{T}"/> class.
        /// </summary>
        /// <param name="message">The exception message itself.</param>
        /// <param name="start">The start of the allowed range.</param>
        /// <param name="end">The end of the allowed range.</param>
        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null)
        {
        }

        /// <summary>
        /// Gets the error message from this exception.
        /// </summary>
        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }

            private set
            {
                this.errorMessage = value;
            }
        }

        /// <summary>
        /// Gets the start of the allowed range.
        /// </summary>
        public T Start
        {
            get
            {
                return this.start;
            }

            private set
            {
                this.start = value;
            }
        }

        /// <summary>
        /// Gets the end of the allowed range.
        /// </summary>
        public T End
        {
            get
            {
                return this.end;
            }

            private set
            {
                this.end = value;
            }
        }
    }
}
