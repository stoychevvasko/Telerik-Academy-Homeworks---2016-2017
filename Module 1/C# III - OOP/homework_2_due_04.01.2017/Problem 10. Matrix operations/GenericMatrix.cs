using System;

namespace Problem_10
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

        /// <summary>
        /// Returns <see cref="GenericMatrix{T}"/> element by index positions.
        /// </summary>
        /// <param name="row">Row index parameter.</param>
        /// <param name="col">Column index parameter.</param>
        /// <returns></returns>
        public T this[int row, int col]
        {
            get { return this.data[row, col]; }
            set { this.data[row, col] = value; }
        }

        /// <summary>
        /// Displays a <see cref="GenericMatrix{T}"/> object on the standard console.
        /// </summary>
        public void Print()
        {
            for (int row = 0; row < this.Height; row++)
            {
                for (int col = 0; col < this.Width; col++)
                {
                    Console.Write("{0, 9:F} ", this[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Overrides the standard + operator for addition of <see cref="GenericMatrix{T}"/> objects.
        /// </summary>
        /// <param name="matrix1"><see cref="GenericMatrix{T}"/> parameter for addition.</param>
        /// <param name="matrix2"><see cref="GenericMatrix{T}"/> parameter for addition.</param>
        /// <returns>A <see cref="GenericMatrix{T}"/> result from addition of <see cref="GenericMatrix{T}"/> objects.</returns>
        public static GenericMatrix<T> operator +(GenericMatrix<T> matrix1, GenericMatrix<T> matrix2)
        {
            GenericMatrix<T> result = new GenericMatrix<T>(matrix1.Height, matrix1.Width);

            if (matrix1.Height != matrix2.Height || matrix1.Width != matrix2.Width)
            {
                throw new System.InvalidOperationException("Cannot add matrices of incompatible dimensions!");
            }

            for (int row = 0; row < result.Height; row++)
            {
                for (int col = 0; col < result.Width; col++)
                {
                    result[row, col] = (T)((dynamic)matrix1[row, col] + (dynamic)matrix2[row, col]);
                }
            }

            return result;
        }

        /// <summary>
        /// Overrides the standard - operator for subtraction of <see cref="GenericMatrix{T}"/> objects.
        /// </summary>
        /// <param name="matrix1"><see cref="GenericMatrix{T}"/> parameter for subtraction.</param>
        /// <param name="matrix2"><see cref="GenericMatrix{T}"/> parameter for subtraction.</param>
        /// <returns>A <see cref="GenericMatrix{T}"/> result from subtraction of <see cref="GenericMatrix{T}"/> objects.</returns>
        public static GenericMatrix<T> operator -(GenericMatrix<T> matrix1, GenericMatrix<T> matrix2)
        {
            GenericMatrix<T> result = new GenericMatrix<T>(matrix1.Height, matrix1.Width);

            if (matrix1.Height != matrix2.Height || matrix1.Width != matrix2.Width)
            {
                throw new System.InvalidOperationException("Cannot subtract matrices of incompatible dimensionss!");
            }

            for (int row = 0; row < result.Height; row++)
            {
                for (int col = 0; col < result.Width; col++)
                {
                    result[row, col] = (T)((dynamic)matrix1[row, col] - (dynamic)matrix2[row, col]);
                }
            }

            return result;
        }

        /// <summary>
        /// Overrides the standard - operator for multiplication of <see cref="GenericMatrix{T}"/> objects.
        /// </summary>
        /// <param name="matrix1"><see cref="GenericMatrix{T}"/> parameter for multiplication.</param>
        /// <param name="matrix2"><see cref="GenericMatrix{T}"/> parameter for multiplication.</param>
        /// <returns>A <see cref="GenericMatrix{T}"/> result from multiplication of <see cref="GenericMatrix{T}"/> objects.</returns>
        public static GenericMatrix<T> operator *(GenericMatrix<T> matrix1, GenericMatrix<T> matrix2)
        {
            if (((matrix1.Height != matrix2.Width) || (matrix1.Width != matrix2.Height)))
            {
                throw new System.InvalidOperationException("Cannot multiply matrices of incompatible dimensions!");
            }

            int resultHeight = (matrix1.Height <= matrix2.Height) ? matrix1.Height : matrix2.Height;
            int resultWidth = (matrix1.Width <= matrix2.Width) ? matrix1.Width : matrix2.Width;
            dynamic resultElement = 0;

            GenericMatrix<T> result = new GenericMatrix<T>(resultHeight, resultWidth);

            for (int resRow = 0; resRow < resultHeight; resRow++)
            {
                for (int resCol = 0; resCol < resultWidth; resCol++)
                {
                    resultElement = 0;

                    for (int i = 0; i < matrix1.Width; i++)
                    {
                        resultElement += (dynamic)matrix1[resRow, i] * (dynamic)matrix2[i, resCol];
                    }

                    result[resRow, resCol] = resultElement;
                }
            }

            return result;
        }

        /// <summary>
        /// Overrides the standard <see cref="operator true(GenericMatrix{T})"/> operator.
        /// </summary>
        /// <param name="matrix">A <see cref="GenericMatrix{T}"/> parameter.</param>
        /// <returns>A <see cref="bool"/> true/false statement.</returns>
        public static bool operator true(GenericMatrix<T> matrix)
        {
            if (matrix.Height <= 0 || matrix.Width <= 0)
            {
                return false;
            }

            for (int row = 0; row < matrix.Height; row++)
            {
                for (int col = 0; col < matrix.Width; col++)
                {
                    int zero = 0;
                    if (matrix[row, col].CompareTo((T)Convert.ChangeType(zero, typeof(T))) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Overrides the standard <see cref="operator false(GenericMatrix{T})"/> operator.
        /// </summary>
        /// <param name="matrix">A <see cref="GenericMatrix{T}"/> parameter.</param>
        /// <returns>A <see cref="bool"/> true/false statement.</returns>
        public static bool operator false(GenericMatrix<T> matrix)
        {
            for (int row = 0; row < matrix.Height; row++)
            {
                for (int col = 0; col < matrix.Width; col++)
                {
                    if (matrix[row, col].CompareTo(new T()) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
