using System.Collections.Generic;

namespace Problem_01
{
    /// <summary>
    /// Allows the use of optional comments as a free text block. 
    /// </summary>
    public interface IComment
    {
        /// <summary>
        /// Returns a all comments as a single <see cref="string"/>.
        /// </summary>
        string Comments
        {
            get;
        }

        /// <summary>
        /// Removes all comments.
        /// </summary>
        void Clear();

        /// <summary>
        /// Adds a new comment.
        /// </summary>
        /// <param name="comment">A <see cref="string"/>.</param>
        void Add(string comment);
    }
}
