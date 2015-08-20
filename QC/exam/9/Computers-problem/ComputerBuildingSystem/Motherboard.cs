namespace ComputerBuildingSystem
{
    using System;

    public class Motherboard : IMotherboard
    {
        private Ram ram;
        private VideoCard videoCard;

        public Motherboard(Ram ram, VideoCard videoCard)
        {
            this.Ram = ram;
            this.VideoCard = videoCard;
        }

        public VideoCard VideoCard
        {
            get { return this.videoCard; }
            set { this.videoCard = value; }
        }

        public Ram Ram
        {
            get { return this.ram; }
            set { this.ram = value; }
        }

        public int LoadRamValue()
        {
            return this.Ram.LoadValue();
        }

        public void SaveRamValue(int value)
        {
            this.Ram.SaveValue(value);
        }

        public void DrawOnVideoCard(string data)
        {
            this.videoCard.Draw(data);
        }
    }
}
