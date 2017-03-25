//// <copyright file="Problem1.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
using System;
using System.Text;

/// <summary>Contains solutions to the problem 1.</summary>
internal class Problem1
{
    /// <summary>Main program executable starts here.</summary>
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(',');
        string num1 = input[0].Trim();
        string num2 = input[1].Trim();
        string num3 = input[2].Trim();

        ulong hex1 = ConvertHexToDec(ReplaceFunctionalDigits(num1));
        ulong hex2 = ConvertHexToDec(ReplaceFunctionalDigits(num2));
        ulong hex3 = ConvertHexToDec(ReplaceFunctionalDigits(num3));

        Console.WriteLine(hex1 * hex2 * hex3);
    }

    /// <summary>Takes a number to a power using standard calculations.</summary><param name="number">Original number.</param><param name="power">Power for raising.</param><returns>The number raised to the power specified.</returns>
    public static ulong SimplePower(ulong number, ulong power)
    {
        ulong result = 1;

        for (ulong i = 0; i < power; i++)
        {
            result *= number;
        }

        return result;
    }

    /// <summary>Converts a string representation of a hexadecimal number as a <see cref="ulong"/>.</summary><param name="hexAsString">A hexadecimal number represented as a string of digit-characters.</param><returns>A <see cref="ulong"/> number as the result in decimal numeral system.</returns>
    public static ulong ConvertHexToDec(string hexAsString)
    {
        string hexDigits = "0123456789ABCDEF";
        StringBuilder num = new StringBuilder(hexAsString);
        ulong result = 0;
        ulong pow = 0;

        while (num.Length != 0)
        {
            result += ((ulong)hexDigits.IndexOf(num[num.Length - 1])) * SimplePower(16, pow);
            num = num.Remove(num.Length - 1, 1);
            pow++;
        }

        return result;
    }

    /// <summary>Replaces custom digits with their matching decimal digit counterparts.</summary><param name="originalNumber">The source number represented as <see cref="string"/>.</param><returns>A new string containing decimal digits only.</returns>
    public static string ReplaceFunctionalDigits(string originalNumber)
    {
        string result = originalNumber.Replace("commonlisp", "D");
        result = result.Replace("lisp", "4");
        result = result.Replace("standardml", "9");
        result = result.Replace("ocaml", "0");
        result = result.Replace("ml", "6");
        result = result.Replace("haskell", "1");
        result = result.Replace("scala", "2");
        result = result.Replace("f#", "3");
        result = result.Replace("rust", "5");
        result = result.Replace("clojure", "7");
        result = result.Replace("erlang", "8");
        result = result.Replace("racket", "A");
        result = result.Replace("elm", "B");
        result = result.Replace("mercury", "C");
        result = result.Replace("scheme", "E");
        result = result.Replace("curry", "F");
        return result;
    }
}
