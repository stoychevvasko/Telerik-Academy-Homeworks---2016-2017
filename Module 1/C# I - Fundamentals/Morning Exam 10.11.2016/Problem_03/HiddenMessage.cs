/**
Task 3: Hidden Message
Description

Tzacky has a great idea to hide messages in subtitles of movies. But his friend, just started to code and has difficulty decoding the messages. He knows that to do so, he needs to take the numbers that come before each subtitle and use them to decode the message. The first number I is the index of the symbol he should start decoding (starting from 0) and the second number S is the number of symbols he needs to skip to get every other symbol. If the starting index is larger than the length of the line, this means that the line should be skipped.

example:

input	result	explanation
4
4
add carbon additive
end	cod


add carbon additive
start from c (4th symbol counting from 0), then take every 4th -> o and d

To make things easy, when the subtitles finish Tzacky always adds end instead of the starting index I (see sample tests).

Sometimes Tzacky wants to be extra sure his message will be hidden, so he decided to add additional complexity.

If S is negative your program should look for the next symbol to the left of the starting index (go backwards).
If I is negative your program should take the symbol counting from the end of the line as starting index
example 1: for I = -1
line of code: "some random text that makes no sence"
example 2: for I = -6
line of code: "some random text that makes no_sence" (the space)
Input

On the first line you can read the index of the first symbol i, if instead of a number you read end your program should print the hidden message so far and stop.
On the second line you will get a number, that is the number of symbols to skip to reach the next symbol for the hidden message.
On the third line you will get a line of text on witch you have to use the previously read numbers.
Output

The output should consist of a single line containing the full hidden message.
Constraints

The starting symbol index I will be a valid integer number between -100 and 100 inclusive.
The number of skipped symbols S will be a valid integer number between -100 and 100 inclusive, excluding 0.
The length of each line of text will be between 1 and 100 inclusive.
The text will contain only Latin letters and the symbols: , (comma), . (dot), ! (exclamation mark) and white space (space)
[',', '.', '!', ' '].
The input will always be valid and in the described format. There is no need to check it explicitly.
Memory limit: 32 MB
Time limit: 0.10 sec
Sample tests

input	output
28
4
To molten steel you can add carbon additive.
100
1
Carbon additive includes calcined petroleum coke, graphite petroleum coke,
0
8
natural graphite etc.
21
4
For the steel-making industry the

3
50
sulfur in calcined petroleum coke
7
11
is a crucial element
end	coding is fun

Explanation:
To molten steel you can add carbon additive.
Carbon additive includes calcined petroleum coke, graphite petroleum coke,
natural graphite_etc.
For the steel-making industry_the
sulfur in calcined petroleum coke
is a crucial element

input	output
0
1
oh no!
end
1
some other text that should be ignored	oh no!


input	output
-4
1
What is this
4
-1
saw something!
-4
-1
ysae tog
end	this was easy
**/

using System;
using System.Text;

class HiddenMessage
{
    static void Main()
    {
        string firstLine = "", secondLine, thirdLine;
        StringBuilder result = new StringBuilder();
        while (true)
        {
            firstLine = Console.ReadLine();
            if (firstLine == "end")
            {
                break;
            }
            else
            {
                secondLine = Console.ReadLine();
                thirdLine = Console.ReadLine();
                int i = int.Parse(firstLine);
                if (i < 0)
                {
                    // set index at end-of-line if negative index
                    i = thirdLine.Length - 1 - (i + 1);
                }
                if (i > thirdLine.Length)
                {
                    // skip a line
                    continue;
                }
                int s = int.Parse(secondLine);
                int j = i;
                while (j >= 0 && j < thirdLine.Length)
                {
                    result.Append(thirdLine[j]);
                    j += s;
                }
            }
        }
        Console.WriteLine(result);
    }
}