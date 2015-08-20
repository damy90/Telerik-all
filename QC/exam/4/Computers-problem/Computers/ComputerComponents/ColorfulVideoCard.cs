namespace Computers.ComputerComponents
{
    using System;
    using Interfaces;

    public class ColorfulVideoCard : IVideoCard
    {
        public ColorfulVideoCard()
        {
        }

        public void Draw(string textToDraw)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(textToDraw);
            Console.ResetColor();
        }
    }
}
