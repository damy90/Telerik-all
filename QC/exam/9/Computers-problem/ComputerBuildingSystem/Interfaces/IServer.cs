namespace ComputerBuildingSystem.Interfaces
{
    using System;
    using System.Linq;

    public interface IServer : IComputer
    {
        void Process(int data);
    }
}
