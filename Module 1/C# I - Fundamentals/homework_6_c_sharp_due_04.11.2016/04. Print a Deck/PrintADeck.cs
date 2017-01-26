/**
Print a Deck

Description

Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).

The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
Input

On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.
Output

The output should follow the format bellow(assume our input is 5):  2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds 3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds ... 5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds 
Constraints

The input character will always be a valid card sign.
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
5	2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
...
5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds
**/

using System;

class PrintADeck
{
    static void Main()
    {
        string input = Console.ReadLine();
        int index = IndexCard(input);
        for (int i = 0; i <= index; i++)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", NameCard(i));
        }
    }

    private static int IndexCard(string input)
    {
        switch (input)
        {
            case "2": return 0;
            case "3": return 1;
            case "4": return 2;
            case "5": return 3;
            case "6": return 4;
            case "7": return 5;
            case "8": return 6;
            case "9": return 7;
            case "10": return 8;
            case "J": return 9;
            case "Q": return 10;
            case "K": return 11;
            case "A": return 12;
            default: return -1;
        }
    }

    private static string NameCard(int input)
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        return cards[input];
    }
}