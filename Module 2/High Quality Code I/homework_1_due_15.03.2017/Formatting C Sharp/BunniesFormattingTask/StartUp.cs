////-------------------------------------------------------------------------------------------------
//// <copyright file="StartUp.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace BunniesFormattingTask
{
    using System.Collections.Generic;
    using System.IO;
    using Core.Enumerations;
    using Core.Models;

    /// <summary>
    /// Contains main program executable.
    /// </summary>
    public class StartUp
    {
        /// <summary>
        /// Main exe.
        /// </summary>
        public static void Main()
        {
            var bunnies = new List<Bunny>
            {
                new Bunny
                {
                    Age = 1,
                    Name = "Leonid",
                    FurType = FurType.NotFluffy
                },

                new Bunny
                {
                    Age = 2,
                    Name = "Rasputin",
                    FurType = FurType.ALittleFluffy
                },

                new Bunny
                {
                    Age = 3,
                    Name = "Tiberii",
                    FurType = FurType.ALittleFluffy
                },

                new Bunny
                {
                    Age = 1,
                    Name = "Neron",
                    FurType = FurType.ALittleFluffy
                },

                new Bunny
                {
                    Age = 3,
                    Name = "Klavdii",
                    FurType = FurType.Fluffy
                },

                new Bunny
                {
                    Age = 3,
                    Name = "Vespasian",
                    FurType = FurType.Fluffy
                },

                new Bunny
                {
                    Age = 4,
                    Name = "Domician",
                    FurType = FurType.FluffyToTheLimit
                },

                new Bunny
                {
                    Age = 2,
                    Name = "Tit",
                    FurType = FurType.FluffyToTheLimit
                }
            };

            var consoleWriter = new ConsoleWriter();

            // Introduce all bunnies
            foreach (var bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }

            // Create bunnies text file
            var bunniesFilePath = @"..\..\bunnies.txt";
            var fileStream = File.Create(bunniesFilePath);
            fileStream.Close();

            // Save bunnies to a text file
            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}
