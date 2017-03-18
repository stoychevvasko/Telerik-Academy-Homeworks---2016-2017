//// <copyright file="Human.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task_2_Make_4yek_in_C_Sharp.Core.Models
{
    /// <summary>Represents a human being.</summary>
    internal class Human : IHuman
    {
        /// <summary>Gets or sets a person's gender.</summary>
        public int Age { get; set; }

        /// <summary>Gets or sets a person's name.</summary>
        public GenderInfo Gender { get; set; }

        /// <summary>Gets or sets a person's age.</summary>
        public string Name { get; set; }
    }
}
