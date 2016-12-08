/*

*/

using System;
using System.Text;

class Problem01
{
    static void Main()
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

    static public ulong SimplePow(ulong num, ulong pow)
    {
        ulong result = 1;

        for (ulong i = 0; i < pow; i++)
        {
            result *= num;
        }

        return result;
    }

    static public ulong ConvertHexToDec(string str)
    {
        string hexDigits = "0123456789ABCDEF";
        StringBuilder num = new StringBuilder(str);
        ulong result = 0;
        ulong pow = 0;

        while (num.Length != 0)
        {
            result += ((ulong)hexDigits.IndexOf(num[num.Length - 1])) * SimplePow(16, pow);
            num = num.Remove(num.Length - 1, 1);
            pow++;
        }

        return result;
    }

    static public string ReplaceFunctionalDigits(string functionalNumber)
    {
        string result = functionalNumber.Replace("commonlisp", "D");
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
