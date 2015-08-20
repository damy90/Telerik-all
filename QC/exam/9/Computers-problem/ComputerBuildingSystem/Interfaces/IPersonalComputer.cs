namespace ComputerBuildingSystem.Interfaces
{
    using System;
    using System.Linq;

    public interface IPersonalComputer : IComputer
    {
        void Play(int guessNumber);
    }
}
