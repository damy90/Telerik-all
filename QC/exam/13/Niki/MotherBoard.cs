namespace ComputersProgram
{
    internal class MotherBoard : IMotherboard
    {
        private readonly RAMMemory ram;
        private readonly IVideoCard videoCard;
        private Cpu cpu;

        public MotherBoard(Cpu cpu, RAMMemory ram, IVideoCard videoCard)
        {
            this.cpu = cpu;
            this.ram = ram;
            this.videoCard = videoCard;
        }

        public void SaveRamValue(int newValue)
        {
            this.ram.SaveValue(newValue);
        }

        public int LoadRamValue()
        {
            return this.ram.LoadValue();
        }

        public void DrawOnVideoCard(string text)
        {
            this.videoCard.Draw(text);
        }
    }
}
