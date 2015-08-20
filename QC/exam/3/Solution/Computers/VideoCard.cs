namespace Computers
{
    using System;
    using Interfaces;

    public abstract class VideoCard : IVideoCard
    {
        public VideoCard()
        {
        }        

        public VideoCard(bool isMonochrome)
        {
            this.IsMonochrome = isMonochrome;
        }

        public bool IsMonochrome { get;  set; }

        public void Draw(string text)
        {
            this.SetupConsole();
            Console.WriteLine(text);
            Console.ResetColor();
        }

        protected abstract void SetupConsole();
    }
}
