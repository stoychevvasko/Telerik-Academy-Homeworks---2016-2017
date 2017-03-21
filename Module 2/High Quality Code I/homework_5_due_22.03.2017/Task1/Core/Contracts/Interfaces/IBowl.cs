//// <copyright file="IBowl.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Core.Contracts.Interfaces
{
    /// <summary>Provides functionality common to all cooking vessels such as pots, pans and trays.</summary>
    internal interface IBowl
    {
        /// <summary>Adds an <see cref="IVegetable"/>-compatible item into the bowl.</summary><param name="veg">A vegetable abstraction.</param>
        void Add(IIngredient veg);
    }
}
