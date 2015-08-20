namespace Computers.StorageDevices
{
    using System.Collections.Generic;
    using Computers.Contracts;

    public class HardDrive : IStorageDevice
    {
        private Dictionary<int, string> data;

        public HardDrive(int capacity)
        {
            this.Capacity = capacity;
            this.data = new Dictionary<int, string>();
        }

        public int Capacity { get; private set; }

        public void SaveData(int addr, string newData)
        {
            this.data[addr] = newData;
        }

        public string LoadData(int address)
        {
            return this.data[address];
        }
    }
}
