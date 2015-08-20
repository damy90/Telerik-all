namespace JustPopcorn
{
    using System;

    class Movement
    {
        public static void MovePad()
        {
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                while (Console.KeyAvailable)
                {
                    Console.ReadKey();
                }
                PopcornMainStart.ExecuteKey(key);
            }
        }

        public static void MoveBall()
        {

            Console.SetCursorPosition(PopcornMainStart.ballX, PopcornMainStart.ballY);
            Console.Write(' ');
            PopcornMainStart.ballX += PopcornMainStart.horizontalDirection[PopcornMainStart.currentDirectionX];
            PopcornMainStart.ballY += PopcornMainStart.verticalDirection[PopcornMainStart.currentDirectionY];
            Console.SetCursorPosition(PopcornMainStart.ballX, PopcornMainStart.ballY);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('@');
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
