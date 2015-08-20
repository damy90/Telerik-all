namespace ComputerBuildingSystem
{
    using System;

    public class ColorfulVideoCard : IDrawable
    {
        public ColorfulVideoCard()
        {        
        }

        public void Draw(string textData)
        {
            if (Console.ForegroundColor != ConsoleColor.Green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(textData);
            Console.ResetColor();
        }
    }
}
