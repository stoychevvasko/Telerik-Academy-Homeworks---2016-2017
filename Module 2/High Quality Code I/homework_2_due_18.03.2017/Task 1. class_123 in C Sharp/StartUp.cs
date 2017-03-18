//// <copyright file="StartUp.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task_1_class_123_in_C_sharp
{
    using Core.Models;

    /// <summary>Main executable.</summary>
    public class StartUp
    {
        /// <summary>Starts here.</summary>
        public static void Main()
        {
            do
            {
                MockConsole.LogLineTrue();
            }
            while (System.Console.ReadLine() != "exit");

            System.Console.WriteLine();
        }
    }
}
