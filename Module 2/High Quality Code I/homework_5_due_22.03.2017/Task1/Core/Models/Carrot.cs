//// <copyright file="Carrot.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Core.Models
{
    using Contracts.Interfaces;

    /// <summary>Represents a carrot.</summary>
    internal class Carrot : IVegetable
    {
        /// <summary>Initializes a new instance of the <see cref="Carrot"/> class.</summary>
        public Carrot()
            : this(false, false)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Carrot"/> class.</summary><param name="isCut">Boolean value confirming whether carrot has been cut already.</param><param name="isPeeled">Boolean value confirming whether carrot has been peeled already.</param>
        public Carrot(bool isCut, bool isPeeled)
        {
            this.IsCut = isCut;
            this.IsPeeled = isPeeled;
        }

        /// <summary>Gets or sets a value indicating whether carrot has been cut into pieces already.</summary>
        public bool IsCut
        {
            get;
            set;
        }

        /// <summary>Gets or sets a value indicating whether carrot has been peeled already.</summary>
        public bool IsPeeled
        {
            get;
            set;
        }
    }
}
