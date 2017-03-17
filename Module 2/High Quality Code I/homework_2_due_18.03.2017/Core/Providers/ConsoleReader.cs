//// <copyright file="ConsoleReader.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Providers
{
    using System;
    using System.Globalization;
    using System.Text;
    using System.Threading;
    using Contracts.Interfaces;
    using NotificationConstants = Common.Constants.Constants.Game.Notifications;

    /// <summary>Provides standard console input reading functionality.</summary>
    internal class ConsoleReader : IReader
    {
        /// <summary>Initializes a new instance of the <see cref="ConsoleReader"/> class.</summary>
        public ConsoleReader()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 20;
            Console.BufferWidth = Console.WindowWidth = 50;
            Console.Title = NotificationConstants.TitleLine;
        }            

        /// <summary>Reads a new line of text from the console.</summary><returns>Text literal.</returns>        
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        /// <summary>Read a single <see cref="ConsoleKeyInfo"/> value from standard console input.</summary><returns>A <see cref="ConsoleKeyInfo"/> value of user's keystroke.</returns>
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
    }
}
