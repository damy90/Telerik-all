namespace ComputerBuildingSystem
{
    public class PlayCommand : ICommand
    {
        private PC pc;

        public PlayCommand(PC pc)
        {
            this.pc = pc;
        }

        public void Execute(int commandArgument)
        {
            this.pc.Play(commandArgument);
        }
    }
}
