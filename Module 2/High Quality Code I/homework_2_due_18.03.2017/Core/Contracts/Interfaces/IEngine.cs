//// <copyright file="IEngine.cs" company="indepentent developer">Copyright (c) *hidden* 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    /// <summary>Provides custom game engine functionality.</summary>
    public interface IEngine
    {
        /// <summary>Gets or sets current engine command.</summary>
        string Command { get; set; }

        /// <summary>Gets or sets the engine reader.</summary>
        IReader Reader { get; set; }

        /// <summary>Gets or sets the engine writer.</summary>
        IWriter Writer { get; set; }

        /// <summary>Gets or sets the game board minefield.</summary>
        IMinefield Minefield { get; set; }

        /// <summary>Sets the engine in motion.</summary>        
        void Start();
    }
}
