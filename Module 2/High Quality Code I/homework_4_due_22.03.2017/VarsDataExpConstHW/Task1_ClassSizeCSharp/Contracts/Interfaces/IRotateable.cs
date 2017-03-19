//// <copyright file="IRotateable.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Contracts.Interfaces
{
    /// <summary>Exposes rotate functionality of simple shapes in 2D space.</summary>
    public interface IRotateable : IShape
    {
        /// <summary>Rotates a <see cref="Shape"/> object in two-dimensional space.</summary><param name="original">Initial dimensions before rotation.</param><param name="rotationAngle">Rotation factor.</param><returns>A resulting new <see cref="Shape"/> of transformed dimensions.</returns>
        IRotateable Rotate(IRotateable original, double rotationAngle);
    }
}
