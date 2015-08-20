namespace Computers
{
    using System;

    public class VideoCard
    {
        public VideoCard(bool isMonoChrome)
        {
            this.IsMonochrome = isMonoChrome;
        }

        public bool IsMonochrome { get; private set; }

        public void Draw(string a)
        {
            if (this.IsMonochrome)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(a);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(a);
                Console.ResetColor();
            }
        }
    }
}
