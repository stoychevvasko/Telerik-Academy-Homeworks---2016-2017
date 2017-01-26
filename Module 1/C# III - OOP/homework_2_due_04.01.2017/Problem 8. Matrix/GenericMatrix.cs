using System;

namespace Problem_08
{
    /// <summary>
    /// Represents a strongly typed 2-D matrix of objects that can be accessed by index. 
    /// </summary>
    /// <typeparam name="T">T is generic notation for base type <see cref="T"/></typeparam>
    public class GenericMatrix<T>
        where T : struct, IComparable, IComparable<T>, IConvertible
    {
        /// <summary>
        /// Holds elements of the <see cref="T"/> type within this <see cref="GenericMatrix{T}"/> object.
        /// </summary>
        private T[,] data;

        /// <summary>
        /// Holds the max width value for this <see cref="GenericMatrix{T}"/> object.
        /// </summary>
        private int width;

        /// <summary>
        /// Holds the max height value for this <see cref="GenericMatrix{T}"/> object.
        /// </summary>
        private int height;

        //public T[,] Data
        //{            
        //    get { return (T[,])this.data.Clone(); }
        //    private set { this.data = value; }
        //}

        /// <summary>
        /// Represents the max width value of a <see cref="GenericMatrix{T}"/> object.
        /// </summary>
        public int Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        /// <summary>
        /// Represents the max height value of a <see cref="GenericMatrix{T}"/> object.
        /// </summary>
        public int Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericMatrix{T}"/> class.
        /// </summary>
        public GenericMatrix()
            : this(3, 3)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericMatrix{T}"/> class.
        /// </summary>
        /// <param name="width">Maximum width parameter.</param>
        /// <param name="height">Maximum height parameter.</param>
        public GenericMatrix(int width, int height)
        {
            this.data = new T[height, width];
            this.Width = width;
            this.Height = height;
        }
    }
}
