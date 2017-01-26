/*
Adding polynomials

Description
Write a method that adds two polynomials. Represent them as arrays of their coefficients. 
Write a program that reads two polynomials and prints their sum.

Input
On the first line you will receive the number N
On the second line you will receive the first polynomial as coefficients separated by spaces
On the third line you will receive the second polynomial as coefficients separated by spaces

Output
Print the sum of the polynomials

Constraints
1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
3
5 0 1
7 4 -3


Output
12 4 -2
*/

using System;

class AddingPolynomials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] firsts = Console.ReadLine().Split(' ');
        string[] seconds = Console.ReadLine().Split(' ');
        int[] firstPolynomial = new int[n];
        int[] secondPolynomial = new int[n];
        for (int i = 0; i < n; i++)
        {
            firstPolynomial[i] = int.Parse(firsts[i]);
            secondPolynomial[i] = int.Parse(seconds[i]);
        }
        int[] result = PolyAddition(firstPolynomial, secondPolynomial);
        Console.WriteLine(String.Join(" ", result));
    }



    public static int[] PolyAddition(int[] polyOne, int[] polyTwo)
    {
        if (polyOne.Length >= polyTwo.Length)
        {
            int[] result = new int[polyOne.Length];

            for (int i = 0; i < polyTwo.Length; i++)
            {
                result[i] = polyOne[i] + polyTwo[i];
            }

            for (int i = polyTwo.Length; i < polyOne.Length; i++)
            {
                result[i] = polyOne[i];
            }

            return result;
        }
        else
        {
            int[] result = new int[polyTwo.Length];

            for (int i = 0; i < polyOne.Length; i++)
            {
                result[i] = polyOne[i] + polyTwo[i];
            }

            for (int i = polyOne.Length; i < polyTwo.Length; i++)
            {
                result[i] = polyTwo[i];
            }

            return result;
        }
    }
}
