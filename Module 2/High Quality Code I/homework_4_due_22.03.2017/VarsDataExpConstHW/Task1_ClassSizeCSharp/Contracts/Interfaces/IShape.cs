//// <copyright file="IShape.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Contracts.Interfaces
{
    /// <summary>Exposes the Height and Width properties of a simple 2D shape;</summary>
    public interface IShape
    {
        /// <summary>Gets or sets the height dimension value of the <see cref="Shape"/>.</summary>
        double Height { get; set; }

        /// <summary>Gets or sets the width dimension value of the <see cref="Shape"/>.</summary>
        double Width { get; set; }
    }
}
