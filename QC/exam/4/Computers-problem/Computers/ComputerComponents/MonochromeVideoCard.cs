namespace Computers.ComputerComponents
{
    using System;
    using Interfaces;

    public class MonochromeVideoCard : IVideoCard
    {
        public MonochromeVideoCard()
        {
        }
        public void Draw(string textToDraw)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(textToDraw);
            Console.ResetColor();
        }
    }
}
