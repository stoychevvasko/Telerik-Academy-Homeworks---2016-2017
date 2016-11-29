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
using System.Linq;
namespace FindWord
{
    class ExtractSentences
    {
        static void Main()
        {
            string inputWord = Console.ReadLine();
            string inputStr = Console.ReadLine();
            string[] inputSentences = inputStr.Split('.').ToArray();

            char[] delimiters = inputStr.Where(x => !char.IsLetter(x))
                .Distinct()
                .ToArray();

            for (int i = 0; i < inputSentences.Length; i++)
            {
                string[] sentenceWords = inputSentences[i]
                    .Split(delimiters)
                    .ToArray();

                if (sentenceWords.Contains(inputWord))
                {
                    Console.Write("{0}. ", inputSentences[i].Trim());
                }
            }
        }
    }
}