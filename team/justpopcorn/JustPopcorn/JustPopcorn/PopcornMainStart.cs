namespace JustPopcorn
{
    using System;
    using System.IO;
    using System.Threading;

    public class PopcornMainStart
    {
        public static int ballX;
        public static int ballY;

        public static int[] horizontalDirection;
        public static int[] verticalDirection;
        public static int currentDirectionX;
        public static int currentDirectionY;

        static int padX;
        static readonly int padY = Console.WindowHeight - 1;
        static int padLength;

        static int[,] fieldOfBricks;
        static int bricksOnField;

        static int highScore;
        static int liveCounter;

        static void Setting()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Just Popcorn";
            Console.SetWindowSize(59, 39);
            Console.SetBufferSize(60, 40);
            Console.CursorVisible = false;

            ballX = Console.WindowWidth / 2;
            ballY = Console.WindowHeight - 5;

            currentDirectionX = 0;
            currentDirectionY = 0;

            horizontalDirection = new int[2] { -1, 1 };
            verticalDirection = new int[2] { -1, 1 };

            padX = Console.WindowWidth / 2 - 4;
            padLength = 9;

            fieldOfBricks = new int[Console.WindowWidth + 1, Console.WindowHeight + 1];
            bricksOnField = 0;

            highScore = 0;
            liveCounter = 1; // TODO: Return normal lives
        }

        static void InitialBricks()
        {
            for (int i = 5; i < 15; i++)
            {
                for (int j = 5; j < Console.WindowWidth - 5; j++)
                {
                    fieldOfBricks[j, i] = 1;
                }
            }
        }

        static void RenderBricks()
        {
            for (int i = 0; i < fieldOfBricks.GetLength(0); i++)
            {
                for (int j = 0; j < fieldOfBricks.GetLength(1); j++)
                {
                    if (fieldOfBricks[i, j] != 0)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write('*');
                        bricksOnField++;
                    }
                }
            }
        }

        static void RenderHighScore()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("Score: {0}", highScore);
        }

        static void RenderLives()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(52, 0);
            Console.Write("Lives: {0}", liveCounter);

            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void ExecuteKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                if (padX > 1)
                {
                    padX--;
                    Console.SetCursorPosition(padX + padLength, padY);
                    Console.Write(' ');
                    RenderPad();
                }
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                if (padX + padLength < Console.WindowWidth)
                {
                    padX++;
                    Console.SetCursorPosition(padX - 1, padY);
                    Console.Write(' ');
                    RenderPad();
                }
            }
            if (key.Key == ConsoleKey.Spacebar)
            {
                Console.ReadLine();
            }
            if (key.Key == ConsoleKey.H)
            {

                try
                {
                    StreamReader reader = new StreamReader("score.jcn");

                    string nick;
                    int score;

                    using (reader)
                    {
                        string[] lineFromFile = reader.ReadLine().Split(' ');
                        nick = lineFromFile[0].Substring(0, 7);
                        score = int.Parse(lineFromFile[lineFromFile.Length - 1]);
                    }

                    Console.SetCursorPosition(20, 0);
                    Console.Write("Top player: " + nick + " - " + score);
                }
                catch
                {
                    Console.SetCursorPosition(25, 0);
                    Console.Write("No top player");
                }
            }
            if (key.Key == ConsoleKey.S)
            {
                SaveGameIncomplete();
            }
            if (key.Key == ConsoleKey.L)
            {
                LoadGameIncomplete();
            }
        }

        static void SaveGameIncomplete()
        {
            StreamWriter writer = new StreamWriter("savedgame.jcn");

            using (writer)
            {
                writer.WriteLine(ballX + " " + ballY);
                writer.WriteLine(highScore);

                for (int i = 0; i < fieldOfBricks.GetLength(0); i++)
                {
                    for (int j = 0; j < fieldOfBricks.GetLength(1); j++)
                    {
                        writer.Write(fieldOfBricks[i, j] + " ");
                    }

                    writer.WriteLine();
                }
            }
        }

        static void LoadGameIncomplete()
        {
            try
            {
                StreamReader reader = new StreamReader("savedgame.jcn");

                using (reader)
                {
                    string[] ballCoordinates = reader.ReadLine().Split(' ');
                    ballX = int.Parse(ballCoordinates[0]);
                    ballY = int.Parse(ballCoordinates[1]);

                    highScore = int.Parse(reader.ReadLine());

                    for (int i = 0; i < fieldOfBricks.GetLength(0); i++)
                    {
                        string[] currentLine = reader.ReadLine().Split(' ');

                        for (int j = 0; j < fieldOfBricks.GetLength(1); j++)
                        {
                            fieldOfBricks[i, j] = int.Parse(currentLine[j]);
                        }
                    }
                }

                RenderHighScore();
                RenderBricks();
            }
            catch
            {

            }
        }

        static void RenderPad()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = padX; i < padX + padLength; i++)
            {
                Console.SetCursorPosition(i, padY);
                Console.Write('#');
            }

            Console.ResetColor();
        }

        static void CollisionWithWall()
        {
            if (ballX <= 0)
            {
                ChangeXDirection();
            }
            if (ballX >= Console.WindowWidth - 1)
            {
                ChangeXDirection();
            }
            if (ballY <= 1)
            {
                ChangeYDirection();
            }
            if (ballY >= Console.WindowHeight - 1)
            {
                throw new IndexOutOfRangeException();
            }
        }

        static void CollisionWithPad()
        {
            if (ballY + 1 == padY && ballX >= padX - 1 && ballX <= padX + padLength + 1)
            {
                ChangeYDirection();
            }
        }

        static void CollisionWithBrick()
        {
            if (ballY - 1 >= 0 && fieldOfBricks[ballX, ballY - 1] != 0)
            {
                fieldOfBricks[ballX, ballY - 1] = 0;
                Console.SetCursorPosition(ballX, ballY - 1);
                Console.Write(' ');
                ChangeYDirection();
                highScore += 10;
                RenderHighScore();
                bricksOnField--;
            }
            if (ballY + 1 < Console.WindowHeight - 2 && fieldOfBricks[ballX, ballY + 1] != 0)
            {
                fieldOfBricks[ballX, ballY + 1] = 0;
                Console.SetCursorPosition(ballX, ballY + 1);
                Console.Write(' ');
                ChangeYDirection();
                highScore += 10;
                RenderHighScore();
                bricksOnField--;
            }
            if (ballX + 1 < Console.WindowWidth - 2 && fieldOfBricks[ballX + 1, ballY] != 0)
            {
                fieldOfBricks[ballX + 1, ballY] = 0;
                Console.SetCursorPosition(ballX + 1, ballY);
                Console.Write(' ');
                ChangeXDirection();
                highScore += 10;
                RenderHighScore();
                bricksOnField--;
            }
            if (ballX - 1 >= 0 && fieldOfBricks[ballX - 1, ballY] != 0)
            {
                fieldOfBricks[ballX - 1, ballY] = 0;
                Console.SetCursorPosition(ballX - 1, ballY);
                Console.Write(' ');
                ChangeXDirection();
                highScore += 10;
                RenderHighScore();
                bricksOnField--;
            }
        }

        static void ChangeXDirection()
        {
            if (currentDirectionX == 0)
            {
                currentDirectionX = 1;
            }
            else
            {
                currentDirectionX = 0;
            }
        }

        static void ChangeYDirection()
        {
            if (currentDirectionY == 0)
            {
                currentDirectionY = 1;
            }
            else
            {
                currentDirectionY = 0;
            }
        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 3);
            Console.WriteLine("JUST POPCORN");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.WindowHeight / 2 - 1);
            Console.WriteLine("Commands");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2);
            Console.WriteLine("New game - start");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 1);
            Console.WriteLine("Exit - exit");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 3);
            Console.WriteLine("Enter command:");
            
            
            bool commandCorrect = false;

            while (!commandCorrect)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 + 4);
                string command = Console.ReadLine();

                switch (command)
                {
                    case "start": Console.Clear(); commandCorrect = true; break;
                    case "exit": Environment.Exit(0); commandCorrect = true; break;
                    case "load": Setting(); Console.Clear(); LoadGameIncomplete(); Engine(); break;
                    default:
                        break;
                }
            }
        }

        static void Engine()
        {
            InitialBricks();
            RenderBricks();
            RenderPad();
            RenderHighScore();
            RenderLives();

            int speed = 0;

            while (bricksOnField != 0)
            {
                if (speed % 2 == 0)
                {
                    try
                    {
                        CollisionWithWall();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        liveCounter--;

                        if (liveCounter == 0)
                        {
                            GameOver();
                            break;
                        }

                        RenderLives();

                        Console.SetCursorPosition(ballX, ballY);
                        Console.Write(' ');

                        ballX = Console.WindowWidth / 2;
                        ballY = Console.WindowHeight - 5;

                        currentDirectionX = 0;
                        currentDirectionY = 0;
                    }
                    
                    CollisionWithPad();
                    CollisionWithBrick();

                    Movement.MoveBall();
                }
                Movement.MovePad();
                Thread.Sleep(50);
                speed++;

                if (speed > 100)
                {
                    speed = 0;
                }
            }

            GameOver();
        }

        static void GameOver()
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 4,
                Console.WindowHeight / 2);
            Console.WriteLine("GAME OVER");

            Console.SetCursorPosition(20, 0);
            Console.CursorVisible = true;
            Console.Write("Enter your nickname: ");

            string nickname = Console.ReadLine();

            int maxHighScore;

            try
            {
                StreamReader reader = new StreamReader("score.jcn");

                using (reader)
                {
                    string[] lineFromFile = reader.ReadLine().Split(' ');
                    maxHighScore = int.Parse(lineFromFile[lineFromFile.Length - 1]);
                }
            }
            catch (Exception)
            {
                maxHighScore = int.MinValue;
            }

            if (highScore >= maxHighScore)
            {
                StreamWriter writer = new StreamWriter("score.jcn");

                using (writer)
                {
                    writer.WriteLine(nickname + " " + highScore);
                }
            }
        }

        static void Main()
        {
            Menu();
            Setting();
            Engine();
        }
    }
}