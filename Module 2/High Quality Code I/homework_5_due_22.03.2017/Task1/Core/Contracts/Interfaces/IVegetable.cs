//// <copyright file="IVegetable.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Core.Contracts.Interfaces
{
    /// <summary>Provides vegetable-specific functionalities.</summary>
    internal interface IVegetable : IIngredient
    {
        /// <summary>Gets or sets a value indicating whether vegetable has been peeled already.</summary>
        bool IsPeeled { get; set; }

        /// <summary>Gets or sets a value indicating whether vegetable has been cut into pieces already.</summary>
        bool IsCut { get; set; }
    }
}
