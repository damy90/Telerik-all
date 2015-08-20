namespace Computers.Contracts
{
    public interface IStorageDevice
    {
        int Capacity { get; }
        
        void SaveData(int addr, string newData);
        
        string LoadData(int address);
    }
}
