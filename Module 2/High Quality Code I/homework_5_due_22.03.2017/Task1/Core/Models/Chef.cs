//// <copyright file="Chef.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Core.Models
{
    using Contracts.Interfaces;
    using Factories;

    /// <summary>Represents a cook.</summary>
    public class Chef
    {
        /// <summary>Make chef cook a typical dish for demo purposes.</summary>
        public void Cook()
        {
            Potato potato = KitchenFactory.Instance.GetPotato();
            Carrot carrot = KitchenFactory.Instance.GetCarrot();
            Bowl bowl = KitchenFactory.Instance.GetBowl();

            this.Peel(potato);
            this.Peel(carrot);
            
            this.Cut(potato);
            this.Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }
        
        /// <summary>The chef cuts the vegetable according to documented specifications.</summary><param name="veg">An <see cref="IVegetable"/>-compatible food item.</param>
        private void Cut(IVegetable veg)
        {
            veg.IsCut = true;
        }

        /// <summary>The chef peels the vegetable according to documented specifications.</summary><param name="veg">An <see cref="IVegetable"/>-compatible food item.</param>
        private void Peel(IVegetable veg)
        {
            veg.IsPeeled = true;
        }
    }
}
