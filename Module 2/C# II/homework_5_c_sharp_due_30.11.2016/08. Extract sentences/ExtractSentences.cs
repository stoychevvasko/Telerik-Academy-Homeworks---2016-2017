/*
Extract sentences

Description
Write a program that extracts from a given text all sentences containing given word.

Input
On the first line you will receive a string - the word
On the second line you will receive a string - the text

Output
Print only the sentences containing the word on a single line

Constraints
Sentences are separated by . and the words – by non-letter symbols
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
in
We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

Output
We are living in a yellow submarine. We will move out of it in 5 days.
*/

using System;
using System.Text;
using System.Threading;

namespace FindWord
{
    class ExtractSentences
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            int startIndex = 0;
            int endIndex = text.IndexOf('.');
            StringBuilder result = new StringBuilder();
            string temp;
            while (endIndex > 0)
            {
                temp = text.Substring(startIndex, endIndex - startIndex);

                if (chechPrint(temp.Trim(), word))
                {
                    result.Append(temp.Trim());
                    result.Append(". ");
                }

                startIndex = endIndex + 1;
                endIndex = text.IndexOf('.', startIndex);
            }
            Console.WriteLine(result.ToString().Trim());
        }

        static bool chechPrint(string temp, string word)
        {
            int subStart = temp.IndexOf(word, 0);
            bool print = false;
            int checkStartIndex;
            int checkEndIndex;
            while (subStart >= 0 && print == false)
            {
                checkStartIndex = subStart - 1;
                checkEndIndex = subStart + word.Length;
                if (
                  (checkStartIndex < 0 || !char.IsLetter(temp[checkStartIndex])) &&
                  (checkEndIndex >= temp.Length || !char.IsLetter(temp[checkEndIndex]))
                  )
                {
                    print = true;
                }
                subStart = temp.IndexOf(word, checkEndIndex);
            }
            return print;
        }
    }
}