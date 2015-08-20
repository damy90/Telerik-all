namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HardDriver
    {
        private int capacity;

        private bool isInRaid;

        private List<HardDriver> hardDrivers;

        private Dictionary<int, string> data;

        public HardDriver(List<HardDriver> hardDrives)
        {
            this.isInRaid = true;
            foreach (var hardDrive in hardDrives)
            {
                this.capacity += hardDrive.Capacity;
            }

            this.data = new Dictionary<int, string>(this.capacity);
            this.hardDrivers = hardDrives;
        }

        public HardDriver(int capacity)
        {
            this.isInRaid = false;

            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);       
        }

        public int Capacity
        {
            get
            {
                if (this.isInRaid)
                {
                    if (!this.hardDrivers.Any())
                    {
                        return 0;
                    }

                    return this.hardDrivers.First().Capacity;
                }
                else
                {
                    return this.capacity;
                }
            }
        }

        public void SaveData(int addr, string newData)
        {
            if (this.isInRaid)
            {
                foreach (var hardDrive in this.hardDrivers)
                {
                    hardDrive.SaveData(addr, newData);
                }
            }
            else
            {
                this.data[addr] = newData;
            }
        }

        public string LoadData(int address)
        {
            if (this.isInRaid)
            {
                if (!this.hardDrivers.Any())
                {
                    throw new OutOfMemoryException("No hard drive in the RAID array!");
                }

                return this.hardDrivers.First().LoadData(address);
            }
            else if (true)
            {
                return this.data[address];
            }
        }      
    }
}
