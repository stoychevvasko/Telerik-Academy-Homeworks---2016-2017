//// <copyright file="Score.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Models
{
    using Common.Constants;

    /// <summary>Keeps Minesweeper player scores.</summary>
    public class Score
    {
        /// <summary>Holds player name.</summary>
        private string name;

        /// <summary>Holds number of points at game-end.</summary>
        private int points;
        
        /// <summary>Initializes a new instance of the <see cref="Score"/> class with default values.</summary>
        public Score() : this(Constants.Player.DefaultName, Constants.Player.DefaultPoints)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Score"/> class.</summary><param name="name">Player name.</param><param name="points">Player score points.</param>
        public Score(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        /// <summary>Gets or sets player name.</summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>Gets or sets Minesweeper end-game score points.</summary>
        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                this.points = value;
            }
        }
    }
}
