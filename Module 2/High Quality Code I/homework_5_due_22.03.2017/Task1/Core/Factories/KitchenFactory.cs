//// <copyright file="KitchenFactory.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Core.Factories
{
    using Interfaces;
    using Models;

    /// <summary>Provides standard kitchen item creation capabilities.</summary>
    internal class KitchenFactory : IFactory
    {
        /// <summary>Holds kitchen factory singleton instance.</summary>
        private static IFactory instanceHolder = new KitchenFactory();

        /// <summary>Prevents a default instance of the <see cref="KitchenFactory"/> class from being created.</summary>
        private KitchenFactory()
        {
        }

        /// <summary>Gets the core factory singleton instance.</summary>
        public static IFactory Instance
        {
            get
            {
                return KitchenFactory.instanceHolder;
            }
        }

        /// <summary>Creates a new <see cref="Bowl"/> object.</summary><returns>A new <see cref="Bowl"/>instance.</returns>
        public Bowl GetBowl()
        {
            return new Bowl();
        }

        /// <summary>Creates a new <see cref="Carrot"/> object.</summary><returns>A new <see cref="Carrot"/>instance.</returns>
        public Carrot GetCarrot()
        {
            return new Carrot();
        }

        /// <summary>Creates a new <see cref="Potato"/> object.</summary><returns>A new <see cref="Potato"/>instance.</returns>
        public Potato GetPotato()
        {
            return new Potato();
        }
    }
}
