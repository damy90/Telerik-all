namespace ComputerBuildingSystem
{
    public class ChargeCommand : ICommand
    {
        private Laptop laptop;

        public ChargeCommand(Laptop laptop)
        {
            this.laptop = laptop;
        }

        public void Execute(int commandArgument)
        {
            this.laptop.ChargeBattery(commandArgument);
        }
    }
}
