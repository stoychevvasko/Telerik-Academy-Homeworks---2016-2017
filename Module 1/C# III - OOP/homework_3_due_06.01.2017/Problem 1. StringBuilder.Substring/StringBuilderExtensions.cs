using System.Text;

namespace Problem_01
{
    /// <summary>
    /// Provides extended functionality for the <see cref="StringBuilder"/> class.
    /// </summary>
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Retrieves a substring from this instance as <see cref="StringBuilder"/>. The substring starts at a specified character position and has a specified length.
        /// </summary>
        /// <param name="source">A <see cref="StringBuilder"/> object.</param>
        /// <param name="startIndex">The zero-based starting character position of a substring in this instance.</param>
        /// <param name="length">The number of characters in the substring.</param>
        /// <returns>A string that is equivalent to the substring of length length that begins at startIndex in this instance, or System.String.Empty if startIndex is equal to the length of this instance and length is zero.</returns>
        public static StringBuilder Substring(this StringBuilder source, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();

            if (startIndex < 0)
            {
                throw new System.ArgumentOutOfRangeException("StartIndex cannot be less than zero.");
            }

            if (length < 0)
            {
                throw new System.ArgumentOutOfRangeException("Length cannot be less than zero.");
            }

            if (startIndex > source.Length - 1 || startIndex + length > source.Length)
            {
                throw new System.ArgumentOutOfRangeException("StartIndex and length must refer to a location within the string.");
            }

            for (int i = startIndex; i < startIndex + length; i++)
            {
                result.Append(source[i]);

                if (i >= source.Length - 1)
                {
                    break;
                }
            }

            return result;
        }
    }
}
