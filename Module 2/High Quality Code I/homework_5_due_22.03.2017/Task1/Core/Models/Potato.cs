﻿//// <copyright file="Potato.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Core.Models
{
    using Contracts.Interfaces;

    /// <summary>Represents a potato.</summary>
    internal class Potato : IVegetable
    {
        /// <summary>Initializes a new instance of the <see cref="Potato"/> class.</summary>
        public Potato()
            : this(false, false)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Potato"/> class.</summary><param name="isCut">Boolean value confirming whether potato has been cut already.</param><param name="isPeeled">Boolean value confirming whether potato has been peeled already.</param>
        public Potato(bool isCut, bool isPeeled)
        {
            this.IsCut = isCut;
            this.IsPeeled = isPeeled;
        }

        /// <summary>Gets or sets a value indicating whether potato was cut.</summary>
        public bool IsCut
        {
            get;
            set;
        }

        /// <summary>Gets or sets a value indicating whether potato was peeled.</summary>
        public bool IsPeeled
        {
            get;
            set;
        }
    }
}
