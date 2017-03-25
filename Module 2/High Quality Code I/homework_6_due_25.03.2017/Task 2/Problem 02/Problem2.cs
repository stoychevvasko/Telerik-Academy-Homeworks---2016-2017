//// <copyright file="Problem2.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
using System;
using System.Text;

/// <summary>Contains solutions to the problem 2.</summary>
internal class Problem2
{
    /// <summary>Represents the standard full-deck <see cref="ulong"/> bit representation for handy calculations.</summary>
    private const ulong FullDeck = 4503599627370495U;

    /// <summary>String representations of the standard playing cards in a deck.</summary>
    private static string[] cards =
    {
        "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac",
        "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad",
        "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah",
        "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As"
    };

    /// <summary>Main program executable starts here.</summary>
    public static void Main()
    {
        int numberOfHands = int.Parse(Console.ReadLine());
        ulong[] hands = new ulong[numberOfHands];
        ulong compositeDeck = 0U;
        ulong cardAppearancesCounted = FullDeck;
        for (int i = 0; i < numberOfHands; i++)
        {
            hands[i] = ulong.Parse(Console.ReadLine());
            compositeDeck |= hands[i];
            cardAppearancesCounted ^= hands[i];
        }

        if ((compositeDeck & FullDeck) == FullDeck)
        {
            Console.WriteLine("Full deck");
        }
        else
        {
            Console.WriteLine("Wa wa!");
        }

        Console.WriteLine(GetCards(cardAppearancesCounted));
    }

    /// <summary>Creates a new hand of cards in string form.</summary><param name="hand">The <see cref="ulong"/> key of the hand of cards.</param><returns>A string containing characters representing cards at positions.</returns>
    public static string GetCards(ulong hand)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < 52; i++)
        {
            if ((hand >> i & 1) == 1)
            {
                builder.Append(cards[i]);
                builder.Append(" ");
            }
        }

        return builder.ToString().Trim();
    }
}