//// <copyright file="IFigure.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Abstraction.Core.Contracts.Interfaces
{
    /// <summary>Provides figure-specific functionality.</summary>
    internal interface IFigure
    {
        /// <summary>Calculates the perimeter of a figure.</summary><returns>Perimeter length as <see cref="double"/> value.</returns>
        double CalcPerimeter();

        /// <summary>Calculates the surface area of a figure.</summary><returns>Surface area as <see cref="double"/> value.</returns>
        double CalcSurface();
    }
}
