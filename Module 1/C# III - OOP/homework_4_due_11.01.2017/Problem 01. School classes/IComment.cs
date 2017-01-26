////-----------------------------------------------------------------------
//// <copyright file="IComment.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    /// <summary>
    /// Allows the use of optional comments as a free text block. 
    /// </summary>
    public interface IComment
    {
        /// <summary>
        /// Gets all comments as a single <see cref="string"/>.
        /// </summary>
        string Comments
        {
            get;
        }

        /// <summary>
        /// Clears all comments.
        /// </summary>
        void ClearComments();

        /// <summary>
        /// Adds a new comment.
        /// </summary>
        /// <param name="comment">A <see cref="string"/>.</param>
        void AddComment(string comment);
    }
}
