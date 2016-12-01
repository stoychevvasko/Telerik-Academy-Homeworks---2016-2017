/*
https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Workshops/2016%20Dec%201%20-%20Strings
*/

using System;
using System.Text;
using System.Text.RegularExpressions;

class DecodeAndDecrypt
{
    static void Main()
    {
        // 100 Points

        string encode = Console.ReadLine();
        string length = Regex.Match(encode, @"[0-9]+\z").Value;
        encode = encode.Substring(0, encode.Length - length.Length);
        encode = ReplaceDigits(encode);

        int cypherLength = int.Parse(length);
        string cypher = encode.Substring((encode.Length - cypherLength), cypherLength);
        string encryptedMessage = encode.Substring(0, encode.Length - (cypherLength));

        if (encryptedMessage.Length >= cypherLength)
        {
            Console.WriteLine(EncryptLongerMessage(encryptedMessage, cypher));
        }
        else
        {
            Console.WriteLine(EncryptLongerCypher(encryptedMessage, cypher));
        }
    }

    static string EncryptLongerCypher(string message, string cypher)
    {
        StringBuilder sb = new StringBuilder();
        int cypherCounter;
        int code;

        for (int i = 0; i < message.Length; i++)
        {
            cypherCounter = i;
            code = message[i] - 65;

            if (cypherCounter < cypher.Length)
            {
                int cyph = (cypher[cypherCounter] - 65);
                code = (code ^ (cyph));

                cypherCounter += message.Length;
            }

            code += 65;

            sb.Append((char)code);
        }

        return sb.ToString();
    }

    static string EncryptLongerMessage(string message, string cypher)
    {
        StringBuilder sb = new StringBuilder();
        int cypherCounter = 0;

        for (int i = 0; i < message.Length; i++)
        {
            int mess = message[i] - 'A';
            int cyph = cypher[cypherCounter] - 'A';
            int code = (mess ^ cyph) + 'A';

            sb.Append((char)code);

            cypherCounter++;

            if (cypherCounter >= cypher.Length)
            {
                cypherCounter = 0;
            }
        }

        return sb.ToString();
    }

    static string ReplaceDigits(string str)
    {
        string pattern = @"([0-9]+)(.)";
        Match match = Regex.Match(str, pattern);
        string replaced = str.Clone().ToString();

        while (match.Success)
        {
            string stringToReplaceWith = new string(match.Groups[2].ToString()[0], int.Parse(match.Groups[1].ToString()));
            replaced = replaced.Replace(match.Value, stringToReplaceWith);
            match = match.NextMatch();
        }

        return replaced;
    }
}