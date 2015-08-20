namespace Computers.ComputerParts
{
    public abstract class HardDrive
    {
        public virtual int Capacity { get; protected set; }

        public abstract void Add(HardDrive hardDrive);

        public abstract string LoadDataFromAddress(int address);

        public abstract void SaveDataToAddress(string data, int address);
    }
}
