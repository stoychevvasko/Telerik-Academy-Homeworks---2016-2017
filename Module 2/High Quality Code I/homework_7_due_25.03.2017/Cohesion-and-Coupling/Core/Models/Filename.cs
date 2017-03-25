//// <copyright file="Filename.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace CohesionAndCoupling.Core.Models
{
    /// <summary>Represents a generalized filename.</summary>
    internal class Filename
    {
        /// <summary>Extracts the file extension from a filename string.</summary><param name="fileName">The original filename in <see cref="string"/> form.</param><returns>The extracted file extension as <see cref="string"/> value.</returns>
        public static string GetExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>Extracts the file name with file extension cropped from a filename string.</summary><param name="fileName">The original filename in <see cref="string"/> form.</param><returns>The extracted file name up to the extension as <see cref="string"/> value.</returns>
        public static string Get(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
