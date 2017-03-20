//// <copyright file="Output.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task2.Contracts.Providers
{
    using Interfaces;

    /// <summary>Provides standard printing functionality for statistical studies.</summary>
    public class Output : IPrinter
    {
        /// <summary>Holds console logging functionality.</summary>
        private static ILogger log;

        /// <summary>Initializes static members of the <see cref="Output"/> class.</summary>
        static Output()
        {
            Output.log = new ConsoleLogger();
        }

        /// <summary>Prints to console floating-point parameter as maximum element.</summary><param name="element">Floating-point numeric value.</param>
        public void PrintMax(double element)
        {
            string max = Output.MaxToString(element);
            Output.log.WriteLine(max);
        }

        /// <summary>Prints to console floating-point parameter as minimum element.</summary><param name="element">Floating-point numeric value.</param>
        public void PrintMin(double element)
        {
            string min = Output.MinToString(element);
            Output.log.WriteLine(min);
        }

        /// <summary>Prints to console floating-point parameter as average element.</summary><param name="element">Floating-point numeric value.</param>
        public void PrintAvg(double element)
        {
            string avg = Output.AvgToString(element);
            Output.log.WriteLine(avg);
        }

        private static string MaxToString(double value)
        {
            return string.Format($"maximum: {value} ");
        }

        private static string MinToString(double value)
        {
            return string.Format($"minimum: {value} ");
        }

        private static string AvgToString(double value)
        {
            return string.Format($"average: {value} ");
        }
    }
}
