//// <copyright file="StartUp.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper
{
    using Core.Models;

    /// <summary>Main executable.</summary>
    public class StartUp
    {
        /// <summary>Starts here.</summary>
        public static void Main()
        {
            var engine = Engine.Instance;
            engine.Start();
        }
    }
}
