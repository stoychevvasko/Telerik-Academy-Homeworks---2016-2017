//// <copyright file="HumanFactory.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task_2_Make_4yek_in_C_Sharp.Core.Factories
{
    using Core.Factories.Contracts.Interfaces;
    using Core.Models;    

    /// <summary>Represents a human being.</summary>
    internal class HumanFactory : IHumanFactory
    {       
        /// <summary>Create a new instance of the <see cref="Human"/> class with male gender of age is even number, or female gender if age is odd number.</summary><param name="age">Age of the individual as integer.</param>
        public void CreatePersonAsMaleOfEvenAgeOrFemaleOfOddAge(int age)
        {
            Human person = new Human();
            person.Age = age;
            if (age % 2 == 0)
            {
                person.Name = "generic male";
                person.Gender = GenderInfo.Male;
            }
            else
            {
                person.Name = "generic female";
                person.Gender = GenderInfo.Female;
            }

            System.Console.WriteLine(
                $"{person.GetType().Name} spawned!\n name: {person.Name}\n age: {person.Age}\n gender: {person.Gender}\n");
        }
    }
}
