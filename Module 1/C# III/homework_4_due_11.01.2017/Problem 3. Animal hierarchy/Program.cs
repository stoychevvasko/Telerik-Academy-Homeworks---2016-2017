////-----------------------------------------------------------------------
//// <copyright file="Program.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
//// 
//// Problem 3. Animal hierarchy
//// 
//// * Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.Dogs, frogs and cats are 
//// Animals.All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats.All animals are 
//// described by age, name and sex.Kittens can be only female and tomcats can be only male. Each animal produces a specific 
//// sound.
////
//// * Create arrays of different kinds of animals and calculate the average age of each kind of animal using a 
//// static method(you may use LINQ).
////
namespace Problem_03
{
    using System;
    using System.Linq;

    /// <summary>
    /// Program execution starts here.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main exe.
        /// </summary>
        public static void Main()
        {
            Dog dog1 = new Dog(5, "Rex", Sex.Male);
            Dog dog2 = new Dog(2, "Linda", Sex.Female);

            dog1.MakeSound();
            dog2.MakeSound();

            Dog[] dogs = new Dog[] { dog1, dog2 };
            Console.WriteLine("Avg. dog age: {0} years", dogs.Average(x => x.Age));
            Console.WriteLine();

            Cat cat1 = new Cat(3, "Jynx", Sex.Male);
            Kitten cat2 = new Kitten(6, "Suzy");
            Tomcat cat3 = new Tomcat(1, "Fuzzy");

            cat1.MakeSound();
            cat2.MakeSound();
            cat3.MakeSound();

            Cat[] cats = new Cat[] { cat1, cat2, cat3 };
            Console.WriteLine("Avg. cat age: {0} years", cats.Average(x => x.Age));
            Console.WriteLine();

            Frog frog1 = new Frog(1, "Kermit", Sex.Male);
            Frog frog2 = new Frog(2, "Kermitta", Sex.Female);

            frog1.MakeSound();
            frog2.MakeSound();

            Frog[] frogs = new Frog[] { frog1, frog2 };
            Console.WriteLine("Avg. frog age: {0} years", frogs.Average(x => x.Age));
            Console.WriteLine();
        }
    }
}
