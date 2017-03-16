//// <copyright file="Engine.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Models
{
    using Contracts.Interfaces;
    using Providers;

    /// <summary>Main engine in the Minesweeper game.</summary>
    public class Engine : IEngine
    {
        /// <summary>Holds engine singleton instance.</summary>
        private static IEngine instanceHolder = new Engine();

        /// <summary>Prevents a default instance of the <see cref="Engine"/> class from being created.</summary>
        private Engine()
        {
            this.Reader = new ConsoleReader();
            this.Writer = new ConsoleWriter();
        }

        /// <summary>Gets the engine singleton instance.</summary>
        public static IEngine Instance
        {
            get { return Engine.instanceHolder; }
        }

        /// <summary>Gets or sets the engine reader.</summary>
        public IReader Reader { get; set; }

        /// <summary>Gets or sets the engine writer.</summary>
        public IWriter Writer { get; set; }

        /// <summary>Sets the engine in motion.</summary>        
        public void Start()
        {
            //// TO-DO: cycle
        }
    }
}
