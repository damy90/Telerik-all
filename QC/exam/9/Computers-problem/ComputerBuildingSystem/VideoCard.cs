namespace ComputerBuildingSystem
{
    using System;
    using System.Linq;

    public class VideoCard
    {
        public VideoCard()
            : this(true)
        {
        }

        public VideoCard(bool isMonochrome)
        {
            this.IsMonochrome = isMonochrome;
        }

        public bool IsMonochrome { get; set; }

        public void Draw(string outputText)
        {
            if (this.IsMonochrome)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(outputText);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(outputText);
                Console.ResetColor();
            }
        }
    }
}
