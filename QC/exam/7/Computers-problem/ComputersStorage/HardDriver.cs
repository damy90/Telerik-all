namespace Computers.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class HardDriver
    {
        private readonly int capacity;
        private readonly Dictionary<int, string> data;
        private readonly List<HardDriver> hds;
        private bool isInRaid;
        private int hardDrivesInRaid;

        internal HardDriver(int capacity, bool isInRaid, int hardDrivesInRaid, List<HardDriver> hardDrives)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
            this.hds = new List<HardDriver>();
            if (hardDrives != null)
            {
                this.hds = hardDrives;
            }
        }

        public bool IsInRaid
        {
            get
            {
                return this.isInRaid;
            }

            set
            {
                this.isInRaid = value;
            }
        }

        public int HardDrivesInRaid
        {
            get
            {
                return this.hardDrivesInRaid;
            }
            
            set
            {
                this.hardDrivesInRaid = value;
            }
        }

        public int Capacity
        {
            get
            {
                if (this.IsInRaid)
                {
                    if (!this.hds.Any())
                    {
                        return 0;
                    }

                    return this.hds.First().Capacity;
                }
                else
                {
                    return this.capacity;
                }
            }
        }

        public void SaveData(int addr, string newData)
        {
            if (this.IsInRaid)
            {
                foreach (var hardDrive in this.hds)
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
            if (this.IsInRaid)
            {
                if (!this.hds.Any())
                {
                    throw new OutOfMemoryException("No hard drive in the RAID array!");
                }

                return this.hds.First().LoadData(address);
            }
            else
            {
                return this.data[address];
            }
        }
    }
}