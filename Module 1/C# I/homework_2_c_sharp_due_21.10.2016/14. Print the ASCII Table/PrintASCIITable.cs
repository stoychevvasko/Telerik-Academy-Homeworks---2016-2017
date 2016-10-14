using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 33; i < 127; i++)
        {
            builder.Append((char)i);
        }

        Console.WriteLine(builder.ToString());
    }
}