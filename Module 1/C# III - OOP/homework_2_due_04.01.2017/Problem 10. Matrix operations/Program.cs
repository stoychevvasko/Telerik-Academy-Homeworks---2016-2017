/*
Problem 10. Matrix operations

* Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
* Throw an exception when the operation cannot be performed.
* Implement the true operator (check for non-zero elements).
*/

using System;

namespace Problem_10
{
    class Program
    {
        static void Main()
        {
            GenericMatrix<decimal> matrixOne = new GenericMatrix<decimal>();

            int index = 0;

            for (int row = 0; row < matrixOne.Height; row++)
            {
                for (int col = 0; col < matrixOne.Width; col++)
                {
                    matrixOne[row, col] = (decimal)Math.PI * index;
                    index++;
                }
            }

            Console.WriteLine("matrixOne:");
            Console.WriteLine();
            matrixOne.Print();

            GenericMatrix<decimal> matrixTwo = new GenericMatrix<decimal>();

            index = 0;

            for (int row = 0; row < matrixTwo.Height; row++)
            {
                for (int col = 0; col < matrixTwo.Width; col++)
                {
                    matrixTwo[row, col] = (decimal)Math.PI * index;
                    index++;
                    index++;
                }
            }

            Console.WriteLine("matrixTwo:");
            Console.WriteLine();
            matrixTwo.Print();

            GenericMatrix<decimal> matrixSum = matrixOne + matrixTwo;

            Console.WriteLine("matrixSum (matrixOne + matrixTwo):");
            Console.WriteLine();
            matrixSum.Print();

            GenericMatrix<decimal> matrixDifference = matrixTwo - matrixOne;

            Console.WriteLine("matrixDifference (matrixTwo - matrixOne):");
            Console.WriteLine();
            matrixDifference.Print();

            GenericMatrix<decimal> matrixProduct = matrixOne * matrixTwo;

            Console.WriteLine("matrixProduct (matrixOne * matrixTwo):");
            Console.WriteLine();
            matrixProduct.Print();

            // test exception handling of invalid matrix arithmetic
            // GenericMatrix<decimal> matrixThree = new GenericMatrix<decimal>(4,4);
            GenericMatrix<decimal> matrixThree = new GenericMatrix<decimal>();

            index = 0;

            for (int row = 0; row < matrixThree.Height; row++)
            {
                for (int col = 0; col < matrixThree.Width; col++)
                {
                    matrixThree[row, col] = (decimal)Math.PI * index;
                    index++;
                    index++;
                }
            }

            Console.WriteLine("matrixThree:");
            Console.WriteLine();
            matrixThree.Print();

            // arithmetic operator tests
            try
            {
                Console.WriteLine("matrixOne + matrixThree:");
                (matrixOne + matrixThree).Print();

                Console.WriteLine("matrixOne - matrixThree:");
                (matrixOne - matrixThree).Print();

                Console.WriteLine("matrixOne * matrixThree:");
                (matrixOne * matrixThree).Print();
            }
            catch (System.InvalidOperationException e)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception)
            {
                throw;
            }

            // true and false operator tests
            GenericMatrix<byte> matrixFour = new GenericMatrix<byte>(1, 1);

            // test with a value-containing instance
            // matrixFour[0, 0] = 123;

            if (matrixFour) Console.WriteLine("matrixFour is true");
            else Console.WriteLine("matrixFour is false");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
