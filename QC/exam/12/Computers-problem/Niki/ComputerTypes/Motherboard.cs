namespace Computers.ComputerTypes
{
    using Computers.Contracts;

    public class Motherboard : IMotherboard
    {
        private Cpu cpu;
        private Ram ram;
        private VideoCard videoCard;

        public Motherboard(Cpu cpu, Ram ram, VideoCard videoCard)
        {
            this.cpu = cpu;
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
