namespace Computers.Api
{
    using System;
    using System.Linq;

    public class VideoCard
    {
        public bool IsMonochrome { get; set; }

        public void Draw(string message)
        {
            if (this.IsMonochrome)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(message);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
    }
}