/**
Description

Look at the back of the hall. On the first 3 glass windows(right-to-left) you have the solution of the first task. Grab a pen and paper as fast as you can and go take it.

Okay, done playing games?
Fine.

You probably didn't find any solutions but you might have saw that the weather outside is pretty warm and sunny. Imagine that you weren't having an exam at this moment, and you were taking a walk in your favorite park. A lot of trees surround you. You hear a bird singing. This is the most miraculous song you have ever heard! You look up and you see tons of birds sitting on the branches, whistling. We all know you are weird as hell, the lights are on but nobody is home, so you start counting the birds in the park. You're obsessed with this task, and for your surprise - at the end of the park, you notice a sign that actually shows the total number of feathers of all birds in the park (what? how did they count that). You see another sign, which says - "The person who guesses what is the average feathers count per bird will win a prize of (continuing his education at the Academy)". Wow, ain't that a day? You've got all the data required to do an accurate calculation and win the prize.
**/

using System;

class Feathers
{
    static void Main()
    {
        ulong b = ulong.Parse(Console.ReadLine());
        ulong f = ulong.Parse(Console.ReadLine());
        decimal result = 0;
        if (b != 0 && f != 0)
        {
            result = (decimal)f / (decimal)b;
            if (b % 2 == 0)
            {
                result = result * 123123123123;
            }
            else
            {
                result = result / 317;
            }
        }

        Console.WriteLine("{0:0.0000}", result);
    }
}