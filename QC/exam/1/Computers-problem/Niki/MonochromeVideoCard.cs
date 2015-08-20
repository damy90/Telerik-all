namespace ComputerBuildingSystem
{
    using System;

    public class MonochromeVideoCard : IDrawable
    {
        public MonochromeVideoCard()
        {          
        }

        public void Draw(string textData)
        {
            if (Console.ForegroundColor != ConsoleColor.Gray)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine(textData);
            Console.ResetColor();
        }
    }
}
