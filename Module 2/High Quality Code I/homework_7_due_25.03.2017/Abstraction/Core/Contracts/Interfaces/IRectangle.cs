//// <copyright file="IRectangle.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Abstraction.Core.Contracts.Interfaces
{
    /// <summary>Provides rectangle-specific functionality.</summary>
    internal interface IRectangle
    {
        /// <summary>Gets or sets the height of the rectangle's side.</summary>
        double Height { get; set; }

        /// <summary>Gets or sets the width of the rectangle's side.</summary>
        double Width { get; set; }
    }
}
