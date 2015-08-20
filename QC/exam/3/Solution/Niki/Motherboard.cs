namespace Computers
{
    using System;
    using System.Linq;
    using Interfaces;

    public class Motherboard : IMotherboard
    {
        private Ram ram;
        private IVideoCard videoCard;

        public Motherboard(Ram ram, IVideoCard videoCard)
        {
            // TODO: validate
            this.ram = ram;
            this.videoCard = videoCard;
        }

        public int LoadRamValue()
        {
            int result = this.ram.LoadValue();
            return result;
        }

        public void SaveRamValue(int value)
        {
            this.ram.SaveValue(value);
        }

        public void DrawOnVideoCard(string data)
        {
            this.videoCard.Draw(data);
        }
    }
}
