/*

*/

using System;
using System.Text;

class Problem04
{
    enum TypesOfSentences { Statement, Question };

    static void Main()
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
                //Console.WriteLine(substring);

                int code = GetCode(substring);
                Console.WriteLine(code);
                break;
            }
        }
    }

    static string[] ExtractSentences(string[] lines)
    {
        string fullText = String.Join("", lines);
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

    static bool IsKeywordFound(string keyword, string sentence)
    {
        int index = sentence.IndexOf(keyword);
        if (index == -1)
        {
            return false;
        }
        return true;
    }

    static TypesOfSentences GetSentenceType(string sentence)
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

    static string GetSubstring(string keyword, string sentence)
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

        return String.Join("", sb.ToString().Split(' '));
    }

    static int GetCode(string substring)
    {
        int value = 0;

        foreach (var character in substring)
        {
            value += (int)character;
        }

        return value;
    }
}
