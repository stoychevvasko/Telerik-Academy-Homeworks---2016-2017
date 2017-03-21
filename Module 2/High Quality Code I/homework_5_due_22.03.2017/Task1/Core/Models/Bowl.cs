//// <copyright file="Bowl.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Core.Models
{
    using System.Collections.Generic;
    using Contracts.Interfaces;    

    /// <summary>Represents a cooking bowl.</summary>
    internal class Bowl : IBowl
    {
        /// <summary>Holds ingredients as bowl contents.</summary>
        private IList<IIngredient> contents;

        /// <summary>Initializes a new instance of the <see cref="Bowl"/> class.</summary>
        public Bowl()
        {
            this.contents = new List<IIngredient>();
        }

        /// <summary>Adds a new ingredient to the bowl.</summary><param name="ingredient">An ingredient item to be added.</param>
        public void Add(IIngredient ingredient)
        {
            this.contents.Add(ingredient);
        }
    }
}
