namespace ComputerBuildingSystem
{
    public class Server : Computer
    {
        public Server(CPU cpu, RAM ram,  HardDriver hardDriver, IDrawable videoCard)
            : base(cpu, ram, hardDriver, videoCard)
        {
        }

        public void Process(int data)
        {
            RAM.SaveValue(data);

            // TODO: Fix it
            CPU.SquareNumber();
        }
    }
}
