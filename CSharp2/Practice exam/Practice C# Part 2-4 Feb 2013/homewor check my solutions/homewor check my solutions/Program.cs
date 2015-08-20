using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string[] playField = new string[3];

        int countX = 0;
        int countO = 0;
        for (int i = 0; i < 3; i++)
        {
            playField[i] = Console.ReadLine();
            countX += playField[i].Count(f => f == 'X');
            countO += playField[i].Count(f => f == 'O');
        }

        int winX = 0;
        int draw = 0;
        int winO = 0;
        bool gameIsOver = (GameIsOver(playField, ref winX, ref draw, ref winO)) || ((countO + countX) == 9);

        if (!gameIsOver)
            PossibleScore(playField, countX, countO, ref winX, ref draw, ref winO);

        Console.WriteLine("{0}\n{1}\n{2}", winX, draw, winO);
    }

    static void PossibleScore(string[] playField, int countX, int countO, ref int winX, ref int draw, ref int winO)
    {
        int row = 0;
        int col = 0;
        var nextMoove = new StringBuilder(playField[row]);

        if ((countO + countX) > 9)
        {
            draw++;
            nextMoove.Remove(col, 1);
            nextMoove.Insert(col, '-');
            playField[row] = nextMoove.ToString();
            return;
        }

        char nextTurn='X';
        if (countX>countO)
            nextTurn='O';
        

        bool next = false;
        for (row = 0; row < 3; row++)
        {
            for (col = 0; col < 3; col++)
            {
                if (playField[row][col] == '-')
                {
                    nextMoove = new StringBuilder(playField[row]);
                    nextMoove.Remove(col, 1);
                    nextMoove.Insert(col, nextTurn);

                    playField[row] = nextMoove.ToString();
                    next = true;
                    if (nextTurn == 'X')
                        countX++;
                    else countO++;
                    if (!GameIsOver(playField, ref winX, ref draw, ref winO))
                    {
                        PossibleScore(playField, countX, countO, ref winX, ref draw, ref winO);
                    }
                    break;
                }
            }
            if (next) break;
        }
        nextMoove.Remove(col, 1);
        nextMoove.Insert(col, '-');
        playField[row] = nextMoove.ToString();
    }
    static bool GameIsOver(string[] playField, ref int winX, ref int draw, ref int winO)
    {
        foreach (string row in playField)
        {
            if (row.IndexOf("XXX") != -1)
            {
                winX++;
                return true;
            }
            else if (row.IndexOf("OOO") != -1)
            {
                winO++;
                return true;
            }
        }
        for (int col = 0; col < 3; col++)
        {
            if (playField[0][col] == 'X' && playField[1][col] == 'X' && playField[2][col] == 'X')
            {
                winX++;
                return true;
            }
            if (playField[0][col] == 'O' && playField[1][col] == 'O' && playField[2][col] == 'O')
            {
                winO++;
                return true;
            }
        }
        if ((playField[0][0] == 'X' && playField[1][1] == 'X' && playField[2][2] == 'X') || (playField[0][2] == 'X' && playField[1][1] == 'X' && playField[2][0] == 'X'))
        {
            winX++;
            return true;
        }
        if ((playField[0][0] == 'O' && playField[1][1] == 'O' && playField[2][2] == 'O') || (playField[0][2] == 'O' && playField[1][1] == 'O' && playField[2][0] == 'O'))
        {
            winO++;
            return true;
        }

        return false;
    }
}
