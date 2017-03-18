//// <copyright file="IEngine.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Contracts.Interfaces
{
    using Minesweeper.Common.Enumerations;

    /// <summary>Provides custom game engine functionality.</summary>
    public interface IEngine
    {
        /// <summary>Gets or sets current engine command.</summary>
        CommandTypes Command { get; set; }

        /// <summary>Gets or sets mine counter.</summary>
        ICounter MineCounter { get; set; }

        /// <summary>Gets or sets the game board minefield.</summary>
        IMinefield Minefield { get; set; }

        /// <summary>Gets or sets the engine reader.</summary>
        IReader Reader { get; set; }

        /// <summary>Gets or sets the engine writer.</summary>
        IWriter Writer { get; set; }        

        /// <summary>Sets the engine in motion.</summary>        
        void Start();
    }
}
