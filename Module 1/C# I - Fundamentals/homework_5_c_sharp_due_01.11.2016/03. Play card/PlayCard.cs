/**
Play card
Description

Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.
Input

    On the only line you will receive a single string.

Output

    Output "yes CONTENT_OF_STRING" if the string is a card sign, otherwise print "no CONTENT_OF_STRING".

Constraints

    String length will always be between 1 and 5
    Time limit: 0.1s
    Memory limit: 16MB

Sample tests
Input 	Output
5 	yes 5
1 	no 1
Q 	yes Q
q 	no q
P 	no P
10 	yes 10
500 	no 500
**/

using System;

class PlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = "no";
        if (input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9" || input == "10" || input == "J" || input == "Q" || input == "K" || input == "A")
        {
            result = "yes";
        }

        Console.WriteLine("{0} {1}", result, input);
    }
}