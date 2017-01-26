using System;

class LongSequence
{
    static void Main()
    {
        for (int num = 2; num < 1001; num++)
        {
            Console.WriteLine(num);
            num++;
            Console.WriteLine(num * -1);
        }
    }
}