//// <copyright file="Statistician.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task2
{
    using Contracts.Providers;

    /// <summary>Task2 solution.</summary>
    public static class Statistician
    {
        /// <summary>Printing capabilities within.</summary>
        private static Output output;

        /// <summary>Initializes static members of the <see cref="Statistician"/> class.</summary>
        static Statistician()
        {
            Statistician.output = new Output();
        }

        /// <summary>Prints analysis of first <paramref name="count"/> number of elements within <paramref name="array"/>.</summary><param name="array">A sequence of floating-point numbers.</param><param name="count">The number of elements to analyze, starting from index 0 of <paramref name="array"/>.</param>
        public static void AnalyzeSequence(double[] array, int count)
        {
            double max = Statistician.CalculateMaximum(array, count);
            Statistician.output.PrintMax(max);

            double min = Statistician.CalculateMinimum(array, count);
            Statistician.output.PrintMin(min);

            double avg = Statistician.CalculateAverage(array, count);
            Statistician.output.PrintAvg(avg);
        }

        /// <summary>Prints maximal of first <paramref name="count"/> number of elements within <paramref name="array"/>.</summary><param name="array">A sequence of floating-point numbers.</param><param name="count">The number of elements to analyze, starting from index 0 of <paramref name="array"/>.</param><returns>The maximal floating-point number among the first <paramref name="count"/> within the <paramref name="array"/>.</returns>
        private static double CalculateMaximum(double[] array, int count)
        {
            double maximum = array[0];
            for (int i = 0; i < count; i++)
            {
                if (array[i] > maximum)
                {
                    maximum = array[i];
                }
            }

            return maximum;
        }

        /// <summary>Prints minimal of first <paramref name="count"/> number of elements within <paramref name="array"/>.</summary><param name="array">A sequence of floating-point numbers.</param><param name="count">The number of elements to analyze, starting from index 0 of <paramref name="array"/>.</param><returns>The minimal floating-point number among the first <paramref name="count"/> within the <paramref name="array"/>.</returns>
        private static double CalculateMinimum(double[] array, int count)
        {
            double minimum = array[0];
            for (int i = 0; i < count; i++)
            {
                if (array[i] < minimum)
                {
                    minimum = array[i];
                }
            }

            return minimum;
        }

        /// <summary>Prints average of first <paramref name="count"/> number of elements within <paramref name="array"/>.</summary><param name="array">A sequence of floating-point numbers.</param><param name="count">The number of elements to analyze, starting from index 0 of <paramref name="array"/>.</param><returns>The average floating-point value among the first <paramref name="count"/> within the <paramref name="array"/>.</returns>
        private static double CalculateAverage(double[] array, int count)
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += array[i];
            }

            double average = sum / count;
            return average;
        }
    }
}