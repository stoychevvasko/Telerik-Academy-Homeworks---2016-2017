//// <copyright file="ILocal.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace InheritanceAndPolymorphism.Core.Contracts.Interfaces
{
    /// <summary>Provides functionality related to locally-held activities.</summary>
    internal interface ILocal
    {
        /// <summary>Gets or sets the local lab.</summary>
        string Lab { get; set; }
    }
}
