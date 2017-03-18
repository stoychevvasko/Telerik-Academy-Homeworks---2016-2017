//// <copyright file="IHuman.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task_2_Make_4yek_in_C_Sharp.Core.Models
{
    /// <summary>Provides human-related info and functionality.</summary>
    internal interface IHuman
    {
        /// <summary>Gets or sets a person's gender.</summary>
        GenderInfo Gender { get; set; }

        /// <summary>Gets or sets a person's name.</summary>
        string Name { get; set; }

        /// <summary>Gets or sets a person's age.</summary>
        int Age { get; set; }
    }
}
