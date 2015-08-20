namespace Computers
{
    using System;

    public class ColorVideoCard : VideoCard
    {
        public ColorVideoCard()
            : base(false)
        {
        }

        protected override void SetupConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
