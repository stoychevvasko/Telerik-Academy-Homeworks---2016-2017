/*

*/

using System;
using System.Text;

class Problem02
{
    const ulong FULL_DECK = 4503599627370495U;

    static string[] cards = {
        "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac",
        "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad",
        "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah",
        "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As"
    };

    static void Main()
    {
        int numberOfHands = int.Parse(Console.ReadLine());
        ulong[] hands = new ulong[numberOfHands];
        ulong compositeDeck = 0U;
        ulong cardAppearancesCounted = FULL_DECK;
        for (int i = 0; i < numberOfHands; i++)
        {
            hands[i] = ulong.Parse(Console.ReadLine());
            compositeDeck |= hands[i];
            cardAppearancesCounted ^= hands[i];
        }

        if ((compositeDeck & FULL_DECK) == FULL_DECK)
        {
            Console.WriteLine("Full deck");
        }
        else
        {
            Console.WriteLine("Wa wa!");
        }

        Console.WriteLine(GetCards(cardAppearancesCounted));
    }

    static string GetCards(ulong hand)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 52; i++)
        {
            if ((hand >> i & 1) == 1)
            {
                sb.Append(cards[i]);
                sb.Append(" ");
            }
        }
        return sb.ToString().Trim();
    }
}