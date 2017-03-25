//// <copyright file="ICourse.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace InheritanceAndPolymorphism.Core.Contracts.Interfaces
{
    using System.Collections.Generic;

    /// <summary>Provides generalized course functionality.</summary>
    internal interface ICourse
    {
        /// <summary>Gets or sets the course name.</summary>
        string Name { get; set; }

        /// <summary>Gets or sets the course teacher name.</summary>
        string TeacherName { get; set; }

        /// <summary>Gets or sets a list of students subscribed to the course.</summary>
        IList<string> Students { get; set; }        
    }
}
