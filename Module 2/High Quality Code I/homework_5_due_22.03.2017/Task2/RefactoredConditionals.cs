//// <copyright file="RefactoredConditionals.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task2
{
    using Task1.Core.Contracts.Interfaces;
    using Task1.Core.Models;

    /// <summary>Solution to the second task from the homework.</summary>
    internal class RefactoredConditionals
    {
        /// <summary>The first conditional statement refactored.</summary>
        public void FirstIfStatement()
        {
            var potato = new Potato();
            if (potato != null)
            {
                if (!potato.IsRotten)
                {
                    if (potato.IsPeeled)
                    {
                        this.Cook(potato);
                    }
                }
            }
        }        

        /// <summary>The second conditional statement refactored.</summary>        
        /// <param name="x">X parameter value.</param>
        /// <param name="y">Y parameter value.</param>
        /// <param name="minX">X minimal limit parameter value.</param>
        /// <param name="maxX">X maximal  limit parameter value.</param>
        /// <param name="minY">Y minimal parameter value.</param>
        /// <param name="maxY">Y maximal parameter value.</param>
        /// <param name="isVisited">Boolean value confirming if cell was visited before.</param>
        public void SecondIfStatement(int x, int y, int minX, int maxX, int minY, int maxY, bool isVisited)
        {
            if (!isVisited)
            {
                if (minX < x && x <= maxX)
                {
                    if (minY < y && y <= maxY)
                    {
                        this.VisitCell();
                    }
                }
            }            
        }

        private void Cook(IIngredient ingredient)
        {
        }

        private void VisitCell()
        {
        }
    }
}
