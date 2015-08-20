namespace Computers.ComputerComponents
{
    using Interfaces;

    class Motherboard : IMotherboard
    {
        private Ram ram;

        private IVideoCard videoCard;

        public Motherboard(Ram ram, IVideoCard videoCard)
        {
            this.ram = ram;
            this.videoCard = videoCard;
        }
        public int LoadRamValue()
        {
            return this.ram.LoadValue();
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
