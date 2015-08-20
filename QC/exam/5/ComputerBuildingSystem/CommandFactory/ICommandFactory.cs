namespace ComputerBuildingSystem
{
    public interface ICommandFactory
    {
        void Execute(string command, int commandAtribute); 
    }
}