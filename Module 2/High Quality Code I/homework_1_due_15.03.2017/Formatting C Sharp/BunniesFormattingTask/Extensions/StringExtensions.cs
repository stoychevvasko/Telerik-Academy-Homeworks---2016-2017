////-------------------------------------------------------------------------------------------------
//// <copyright file="StringExtensions.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace BunniesFormattingTask.Extensions
{
    using System.Text;

    /// <summary>
    /// Contains extension functionality for the standard <see cref="string"/> class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Splits a string into separate words starting with an uppercase letter each (inserts spaces between words).
        /// </summary>
        /// <param name="sequence">A sequence of words as a string.</param>
        /// <returns>A new string.</returns>
        public static string SplitToSeparateWordsByUppercaseLetter(this string sequence)
        {
            var probableStringMargin = 10;
            var probableStringSize = sequence.Length + probableStringMargin;
            var builder = new StringBuilder(probableStringSize);

            var singleWhitespace = ' ';
            foreach (var letter in sequence)
            {
                if (char.IsUpper(letter))
                {
                    builder.Append(singleWhitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}
