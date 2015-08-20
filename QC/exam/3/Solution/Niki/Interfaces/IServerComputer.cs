namespace Computers.Interfaces
{
    using System;

    public interface IServerComputer : IComputer
    {
        void Process(int data);
    }
}
