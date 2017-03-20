//// <copyright file="IPrinter.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task2.Contracts.Interfaces
{
    /// <summary>Provides standard output printing functionality.</summary>
    public interface IPrinter
    {
        /// <summary>Prints the parameter as maximal element.</summary><param name="element">Floating-point number to print as maximal.</param>
        void PrintMax(double element);

        /// <summary>Prints the parameter as minimal element.</summary><param name="element">Floating-point number to print as minimal.</param>
        void PrintMin(double element);

        /// <summary>Prints the parameter as average element.</summary><param name="element">Floating-point number to print as average.</param>
        void PrintAvg(double element);
    }
}
