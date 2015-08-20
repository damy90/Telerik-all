namespace Computers
{
    using System;

    public class MonochromeVideoCard : VideoCard
    {
        public MonochromeVideoCard()
            : base(true)
        {
        }

        protected override void SetupConsole()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
