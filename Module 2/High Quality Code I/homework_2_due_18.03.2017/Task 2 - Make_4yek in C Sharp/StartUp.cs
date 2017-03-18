//// <copyright file="StartUp.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task_2_Make_4yek_in_C_Sharp
{
    using Core.Factories;
    using Core.Factories.Contracts.Interfaces;

    /// <summary>Main executable.</summary>
    public class StartUp
    {
        /// <summary>Starts here.</summary>
        public static void Main()
        {
            IHumanFactory factory = new HumanFactory();
            factory.CreatePersonAsMaleOfEvenAgeOrFemaleOfOddAge(1);
            factory.CreatePersonAsMaleOfEvenAgeOrFemaleOfOddAge(2);
            factory.CreatePersonAsMaleOfEvenAgeOrFemaleOfOddAge(3);
            factory.CreatePersonAsMaleOfEvenAgeOrFemaleOfOddAge(4);
        }
    }
}
