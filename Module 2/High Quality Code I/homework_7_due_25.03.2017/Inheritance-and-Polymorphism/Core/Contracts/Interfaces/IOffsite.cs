//// <copyright file="IOffsite.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace InheritanceAndPolymorphism.Core.Contracts.Interfaces
{
    /// <summary>Provides functionality specific to activities held offsite (remotely).</summary>
    internal interface IOffsite
    {
        /// <summary>Gets or sets the town where offsite activities take place.</summary>
        string Town { get; set; }
    }
}
