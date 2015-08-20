using System;
using System.Linq;

class Program
{
    //static int heigth = 0;
    //static int width = 0;
    static bool[][] playfield;

    static void Main()
    {
        int[] dimencions = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        char[] redPlayerMoves = Console.ReadLine().ToCharArray();
        char[] bluePlayerMoves = Console.ReadLine().ToCharArray();


        int heigth = dimencions[0] + 1;
        int width = 2 * (dimencions[1] + dimencions[2] + 2);
        playfield = new bool[heigth][];

        for (int i = 0; i < heigth; i++)
        {
            playfield[i] = new bool[width];
            //Console.Write(playfield[i][1]);
        }

        var direction = new Direction();
        direction.X = 1;
        direction.Y = 0;
        var redPlayerStartX = dimencions[1] / 2;
        var redPlayerStartY = dimencions[0] / 2;
        var redPlayer = new Player(redPlayerStartX, redPlayerStartY, direction);
        direction.X = -1;
        var bluePlayerStartX = dimencions[1] + dimencions[2] + dimencions[1] / 2;
        var bluePlayerStartY = dimencions[0] / 2;
        var bluePlayer = new Player(bluePlayerStartX, bluePlayerStartY, direction);

        int counterRed = 0;
        int counterBlue = 0;
        //int redMovesCount = 0;
        bool isGameOver = false;
        bool redCrashed = false;
        bool blueCrashed = false;

        playfield[redPlayer.Y][redPlayer.X] = true;
        playfield[bluePlayer.Y][bluePlayer.X] = true;
        int gameMoves = Math.Min(redPlayerMoves.Length, bluePlayerMoves.Length);
        //todo move forward
        while (counterRed < gameMoves || counterBlue < gameMoves)
        {
            //int a = redPlayerMoves.Length;
            //char redCommand = redPlayerMoves[counterRed];
            //char blueCommand = bluePlayerMoves[counterRed];
            if (counterRed < gameMoves)
                isGameOver = (redCrashed = Commands(redPlayerMoves, redPlayer, redCrashed, ref counterRed));
            if (counterBlue < gameMoves)
                isGameOver = (blueCrashed = Commands(redPlayerMoves, bluePlayer, blueCrashed, ref counterBlue));

            //headon crash
            if (redPlayer.X == bluePlayer.X && redPlayer.Y == bluePlayer.Y)
            {
                isGameOver = true;
                redCrashed = true;
                blueCrashed = true;
            }

            counterRed++;
            counterBlue++;
        }

        //if (blueCrashed)
        //{
        //    Commands('M', redPlayer, redCrashed);
        //}
        while (!isGameOver)
        //{
        //    isGameOver = (redCrashed = Commands('M', redPlayer, redCrashed));
        //    isGameOver = (blueCrashed = Commands('M', bluePlayer, blueCrashed));
        //}

        if (redCrashed == blueCrashed)
        {
            Console.WriteLine("DRAW");
        }
        else if (redCrashed)
        {
            Console.WriteLine("BLUE");
        }
        else
        {
            Console.WriteLine("RED");
        }

        int redDistanceX = Math.Abs(redPlayerStartX - redPlayer.X);
        int redDistanceXCircle = Math.Abs(redPlayerStartX + width - redPlayer.X);
        int minDistance = Math.Min(redDistanceX, redDistanceXCircle) + Math.Abs(redPlayerStartY - redPlayer.Y);
        Console.WriteLine(minDistance);
        //Console.WriteLine(counter);
        foreach (bool[] row in playfield)
        {
            foreach (bool cell in row)
            {
                if (cell)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('T');
                    Console.ResetColor();
                }
                else
                {
                    Console.Write('F');
                }
                //Console.Write("{0} ", cell ? "T" : "F");
            }
            Console.WriteLine();
        }
    }

    private static bool Commands(char[] playerMoves, Player player, bool playerCrashed, ref int playerCounter)
    {
        if (playerMoves[playerCounter] == 'R')
        {
            player.TurnRight();
            playerCounter++;
        }
        else if (playerMoves[playerCounter] == 'L')
        {
            player.TurnLeft();
            playerCounter++;
        }
        if (playerMoves[playerCounter] == 'M')
        {
            //var previousPositionX = player.X;
            var previousPositionY = player.Y;
            if (!playerCrashed)
                player.Move();

            //exited playfield
            if (player.Y >= playfield.GetLength(0) || player.Y < 0)
            {
                player.Y = previousPositionY;
                return true;
            }
            //spin
            if (player.X >= playfield[player.Y].GetLength(0))
            {
                player.X = 0;
            }
            if (player.X < 0)
            {
                player.X = playfield[player.Y].GetLength(0) - 1;
            }
            //crash into trail
            if (playfield[player.Y][player.X])
            {
                return true;
            }

            playfield[player.Y][player.X] = true;
            return false;
        }
        return false;
    }
}

public class Player
{
    public int X;
    public int Y;
    public Direction Dir;

    public Player(int x, int y, Direction dir)
    {
        this.X = x;
        this.Y = y;
        this.Dir = dir;
    }

    public void Move()
    {
        this.X += this.Dir.X;
        this.Y += this.Dir.Y;
    }

    public void TurnRight()
    {
        int temp = this.Dir.Y;
        this.Dir.Y = this.Dir.X;
        this.Dir.X = -temp;
    }

    public void TurnLeft()
    {
        int temp = this.Dir.Y;
        this.Dir.Y = -this.Dir.X;
        this.Dir.X = temp;
    }
}

public struct Direction
{
    public int X;
    public int Y;
}
