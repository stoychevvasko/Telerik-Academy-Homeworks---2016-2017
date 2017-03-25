//// <copyright file="Problem4.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
using System;
using System.Text;

/// <summary>Contains solutions to the problem 3.</summary>
public class Problem4
{
    /// <summary>Holds a standard set of types of sentences.</summary>
    public enum TypesOfSentences
    {
        /// <summary>A statement-type of sentence.</summary>
        Statement,

        /// <summary>A question-type of sentence.</summary>
        Question
    }

    /// <summary>Main program executable starts here.</summary>
    public static void Main()
    {
        string word = Console.ReadLine();
        int numberOfLines = int.Parse(Console.ReadLine());
        string[] lines = new string[numberOfLines];
        for (int i = 0; i < numberOfLines; i++)
        {
            lines[i] = Console.ReadLine();
        }

        string[] text = ExtractSentences(lines);

        foreach (var sen in text)
        {
            if (IsKeywordFound(word, sen))
            {
                string substring = GetSubstring(word, sen);
                //// Console.WriteLine(substring);

                int code = GetCode(substring);
                Console.WriteLine(code);
                break;
            }
        }
    }

    /// <summary>Extracts sentences from an array of text lines represented as strings.</summary><param name="lines">Original lines of text</param><returns>An array or sentences in string form.</returns>
    public static string[] ExtractSentences(string[] lines)
    {
        string fullText = string.Join(string.Empty, lines);
        int numberOfSentences = fullText.Split('.', '?').Length;
        string[] result = new string[numberOfSentences];

        StringBuilder sb = new StringBuilder();
        int counter = 0;
        for (int i = 0; i < fullText.Length; i++)
        {
            sb.Append(fullText[i]);
            if (fullText[i] == '.' || fullText[i] == '?')
            {
                result[counter] = sb.ToString().Trim();
                counter++;
                sb = new StringBuilder();
            }
        }

        return result;
    }

    /// <summary>Determines whether a keyword matches.</summary><param name="keyword">Keyword string or literal.</param><param name="sentence">Sentence string or literal.</param><returns>True if keyword matched within the sentence, false otherwise.</returns>
    public static bool IsKeywordFound(string keyword, string sentence)
    {
        int index = sentence.IndexOf(keyword);
        if (index == -1)
        {
            return false;
        }

        return true;
    }

    /// <summary>Parses a sentence into its <see cref="TypesOfSentences"/> value.</summary><param name="sentence">Original sentence string.</param><returns>The matching <see cref="TypesOfSentences"/> value.</returns>
    public static TypesOfSentences GetSentenceType(string sentence)
    {
        if (sentence[sentence.Length - 1] == '.')
        {
            return TypesOfSentences.Statement;
        }
        else
        {
            return TypesOfSentences.Question;
        }
    }

    /// <summary>Splits a sentence by a keyword.</summary><param name="keyword">Keyword string or literal.</param><param name="sentence">Sentence string or literal.</param><returns>End result.</returns>
    public static string GetSubstring(string keyword, string sentence)
    {
        TypesOfSentences type = GetSentenceType(sentence);
        int indexOfKeyword = sentence.IndexOf(keyword);
        StringBuilder sb = new StringBuilder();

        switch (type)
        {
            case TypesOfSentences.Statement:
                {
                    int lengthOfSubstring = indexOfKeyword;
                    sb.Append(sentence.Substring(0, lengthOfSubstring).ToUpper());
                    break;
                }

            case TypesOfSentences.Question:
                {
                    int startOfSubstring = indexOfKeyword + keyword.Length;
                    sb.Append(sentence.Substring(startOfSubstring).ToUpper());
                    sb.Length--; // pesky '?' is pesky
                    break;
                }
        }

        return string.Join(string.Empty, sb.ToString().Split(' '));
    }

    /// <summary>Returns character integer value sum from substring.</summary><param name="substring">Original substring.</param><returns>Code value as integer.</returns>
    public static int GetCode(string substring)
    {
        int value = 0;

        foreach (var character in substring)
        {
            value += (int)character;
        }

        return value;
    }
}
