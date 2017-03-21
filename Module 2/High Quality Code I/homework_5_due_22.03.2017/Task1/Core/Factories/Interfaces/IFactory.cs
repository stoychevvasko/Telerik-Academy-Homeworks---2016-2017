//// <copyright file="IFactory.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Core.Factories.Interfaces
{
    using Models;

    /// <summary>Contains factory-specific functionality.</summary>
    internal interface IFactory
    {
        /// <summary>Creates a new <see cref="Bowl"/> object.</summary><returns>A new <see cref="Bowl"/>instance.</returns>
        Bowl GetBowl();

        /// <summary>Creates a new <see cref="Carrot"/> object.</summary><returns>A new <see cref="Carrot"/>instance.</returns>
        Carrot GetCarrot();

        /// <summary>Creates a new <see cref="Potato"/> object.</summary><returns>A new <see cref="Potato"/>instance.</returns>
        Potato GetPotato();
    }
}
