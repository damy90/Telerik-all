namespace ComputerBuildingSystem
{
    public class Motherboard : IMotherboard
    {
        private RAM ram;

        private IDrawable videoCard;

        public Motherboard(RAM ram, IDrawable videoCard)
        {
            this.ram = ram;
            this.videoCard = videoCard;
        }

        public int LoadRAMValue()
        {
            return this.ram.LoadValue();
        }

        public void SaveRAMValue(int value)
        {
            this.ram.SaveValue(value);
        }

        public void DrawOnVideoCard(string data)
        {
            this.videoCard.Draw(data);
        }
    }
}
