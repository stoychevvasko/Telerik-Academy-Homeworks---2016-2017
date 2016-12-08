/*

*/

using System;

class Problem03
{
    static void Main()
    {
        string[] dimensions = Console.ReadLine().Split('x');
        int maxDepthR = int.Parse(dimensions[0]);
        int maxWidthC = int.Parse(dimensions[1]);

        char[,] den = new char[maxDepthR, maxWidthC];
        for (int row = 0; row < maxDepthR; row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < maxWidthC; col++)
            {
                den[row, col] = line[col];
            }
        }

        string[] commands = Console.ReadLine().Split(',');

        int startingRow = 0;
        int startingColumn = 0;

        int snakeLength = 3;

        for (int col = 0; col < maxWidthC; col++)
        {
            if (den[0, col] == 's')
            {
                startingColumn = col;
                break;
            }
        }

        int currentRow = startingRow;
        int currentColumn = startingColumn;
        int moveIndex = 0;

        for (int i = 0; i < commands.Length; i++)
        {
            try
            {
                Execute(ref currentRow, ref currentColumn, ref moveIndex, commands[i], ref den, ref snakeLength, ref startingColumn);
            }
            catch (Exception)
            {
                goto EndOfExe;
            }
        }

    EndOfExe:;
    }

    private static void Execute(ref int currentRow, ref int currentColumn, ref int moveindex, string command, ref char[,] den,
        ref int snakeLength, ref int startingCol)
    {
        int nextX = GetNextRow(currentRow, ref den, command);
        int nextY = GetNextCol(currentColumn, ref den, command);
        if (nextX == 0 && nextY == startingCol)
        {
            Console.WriteLine("Snacky will get out with length {0}", snakeLength);
            throw new Exception("successful exit");
        }
        if (currentRow > den.GetLength(1))
        {
            Console.WriteLine("Snacky will be lost into the depths with length {0}", snakeLength);
            throw new Exception("is this Adelle?");
        }
        if (snakeLength <= 0)
        {
            Console.WriteLine("Snacky will starve at[{0},{1}]", currentRow, currentColumn);
            throw new Exception("starved to death");
        }
        if (den[nextX, nextY] == '*')
        {
            snakeLength += 1;
            den[nextX, nextY] = '.';
        }
        if (den[nextX, nextY] == '#')
        {
            Console.WriteLine("Snacky will hit a rock at [{0},{1}]", nextX, nextY);
            throw new Exception("hit a rock");
        }

        MoveTo(ref currentRow, ref currentColumn, nextX, nextY, ref snakeLength, ref moveindex);
        moveindex = moveindex + 1;
    }

    private static int GetNextCol(int currentColumn, ref char[,] den, string command)
    {
        if (command == "l")
        {
            int index = currentColumn - 1;
            if (index < 0)
            {
                index = den.GetLength(1) - 1;
            }

            return index;
        }
        else if (command == "r")
        {
            int index = currentColumn + 1;
            if (index > den.GetLength(1) - 1)
            {
                index = 0;
            }

            return index;
        }
        else
        {
            return currentColumn;
        }
    }

    private static int GetNextRow(int currentRow, ref char[,] den, string command)
    {
        if (command == "u")
        {
            return currentRow - 1;
        }
        if (command == "d")
        {
            return currentRow + 1;
        }
        else
        {
            return currentRow;
        }
    }

    private static void MoveTo(ref int currentRow, ref int currentCol, int newRow, int newCol, 
        ref int snakeLength, ref int moveIndex)
    {
        currentRow = newRow;
        currentCol = newCol;
        moveIndex = moveIndex + 1;
        if (moveIndex%5==0)
        {
            snakeLength = snakeLength - 1;
        }
    }
}