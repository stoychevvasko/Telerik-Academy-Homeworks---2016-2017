﻿/*
Problem 20.* Infinite convergent series

By using delegates develop an universal static method to calculate the sum of infinite convergent series 
with given precision depending on a function of its term. By using proper functions for the term calculate 

with a 2-digit precision the sum of the infinite series:
  1 + 1/2 + 1/4 + 1/8 + 1/16 + …
  1 + 1/2! + 1/3! + 1/4! + 1/5! + …
  1 + 1/2 - 1/4 + 1/8 - 1/16 + … 
*/

using System;

namespace Problem_20
{
    public class InfiniteConvergentSeries
    {
        public static void Main()
        {
            double precision = 0.001;
            Console.WriteLine("\n1 + 1/2 + 1/4 + 1/8 + 1/16 + ... = {0:F2}\n",
                              ConvergentSum(x => 1.0 / Math.Pow(2, x), precision));

            Console.WriteLine("1 + 1/2! + 1/3! + 1/4! + 1/5! + ... = {0:F2}\n",
                              ConvergentSum(x => 1.0 / Factorial(x + 1), precision));

            Console.WriteLine("1 + 1/2 - 1/4 + 1/8 - 1/16 + ... = {0:F2}\n",
                              ConvergentSum(x => x == 0 ? 1 : -1.0 / Math.Pow(-2, x), precision));
        }

        private static double ConvergentSum(Func<int, double> term, double precision)
        {
            double sum = 0;
            double t = 1;

            for (int i = 0; Math.Abs(t) > precision; i++)
            {
                t = term(i);
                sum += t;
            }

            return sum;
        }

        private static long Factorial(int num)
        {
            long result = 1;
            while (num > 1)
            {
                result *= num;
                num--;
            }

            return result;
        }
    }
}