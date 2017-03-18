//// <copyright file="IHumanFactory.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task_2_Make_4yek_in_C_Sharp.Core.Factories.Contracts.Interfaces
{
    /// <summary>Provides factory functionality for the creation of humans.</summary>
    public interface IHumanFactory
    {
        /// <summary>Create a new instance of the <see cref="Human"/> class with male gender of age is even number, or female gender if age is odd number.</summary><param name="age">Age of the individual as integer.</param>
        void CreatePersonAsMaleOfEvenAgeOrFemaleOfOddAge(int age);
    }
}
