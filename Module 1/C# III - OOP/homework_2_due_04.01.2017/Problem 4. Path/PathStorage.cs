/*
Problem 4. Path

[...]
* Create a static class PathStorage with static methods to save and load paths from a text file.
* Use a file format of your choice.
*/

using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Problem_04
{
    public static class PathStorage
    {
        /// <summary>
        /// Appends a <see cref="Path"/> object to the end of a local file as a new line.
        /// </summary>
        /// <param name="pathObject">A <see cref="Path"/> parameter.</param>
        /// <param name="filePath">A filepath as <see cref="string"/>.</param>
        public static void SavePathToFile(Path pathObject, string filePath)
        {
            StreamWriter streamWriter = new StreamWriter(filePath, true);
            streamWriter.WriteLine(pathObject.ToString());
            streamWriter.Flush();
            streamWriter.Close();
        }

        /// <summary>
        /// Loads an <see cref="array"/> of <see cref="Path"/> objects from a local file.
        /// </summary>
        /// <param name="filePath">A filepath as <see cref="string"/>.</param>
        /// <returns>A <see cref="Path"/> object loaded from a local file.</returns>
        public static List<Path> LoadPathsFromFile(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            List<Path> result = new List<Path>();
            while (!reader.EndOfStream)
            {
                result.Add(new Path(reader.ReadLine()));
            }
            return result;
        }
    }
}
