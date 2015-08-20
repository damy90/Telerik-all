namespace ComputerBuildingSystem
{
    using System;

    public class Cpu64 : CpuStrategy
    {
        public override int SquareNumber(int value)
        {
            int result = 0;
            if (value < 0)
            {
                result = -2;
            }
            else if (value > 1000)
            {
                result = -1;
            }
            else
            {
                result = value * value;
            }

            return result;
        }
    }
}