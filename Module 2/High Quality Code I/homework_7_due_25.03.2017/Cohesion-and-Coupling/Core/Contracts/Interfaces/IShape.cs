//// <copyright file="IShape.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace CohesionAndCoupling.Core.Contracts.Interfaces
{
    /// <summary>Provides shape-specific functionality.</summary>
    internal interface IShape
    {
        /// <summary>Calculates the volume of a generalized three-dimensional shape.</summary><returns>Volume as a <see cref="double"/> value.</returns>
        double CalcVolume();
    }
}
