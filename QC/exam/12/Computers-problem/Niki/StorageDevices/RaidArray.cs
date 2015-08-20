namespace Computers.StorageDevices
{
    using System;
    using System.Collections.Generic;
    using Computers.Contracts;

    public class RaidArray : IStorageDevice
    {
        private List<HardDrive> drives;

        public RaidArray(int numberOfDrives, int capacity)
        {
            this.drives = new List<HardDrive>();
            for (int i = 0; i < numberOfDrives; i++)
            {
                var newDrive = new HardDrive(capacity);
                this.drives.Add(newDrive);
            }
        }

        public int Capacity
        {
            get
            {
                this.CheckForDrives();
                return this.drives[0].Capacity;
            }
        }

        public void SaveData(int addr, string newData)
        {
            this.CheckForDrives();
            for (int i = 0; i < this.drives.Count; i++)
            {
                this.drives[i].SaveData(addr, newData);
            }
        }

        public string LoadData(int address)
        {
            this.CheckForDrives();
            return this.drives[0].LoadData(address);
        }

        private void CheckForDrives()
        {
            if (this.drives.Count == 0)
            {
                throw new InvalidOperationException("No hard drive in the RAID array!");
            }
        }
    }
}
