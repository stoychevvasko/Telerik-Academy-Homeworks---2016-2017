using System;

class Sequence
{
	static void Main()
	{
		for (int num = 2; num < 11; num++)
        {
            Console.WriteLine(num);
            num++;
            Console.WriteLine(num * -1);
        }
	}
}