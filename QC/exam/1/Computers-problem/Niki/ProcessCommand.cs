namespace ComputerBuildingSystem
{
    public class ProcessCommand : ICommand
    {
        private Server server;

        public ProcessCommand(Server server)
        {
            this.server = server;
        }

        public void Execute(int commandArgument)
        {
            this.server.Process(commandArgument);
        }
    }
}
