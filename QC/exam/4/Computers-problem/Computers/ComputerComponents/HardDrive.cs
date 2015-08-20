namespace Computers.ComputerComponents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HardDrive
    {
        private bool isInRaid;

        private int hardDrivesInRaid;

        private IEnumerable<HardDrive> hds;

        private int capacity;

        private IDictionary<int, string> data;

        public HardDrive()
        {
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid, IEnumerable<HardDrive> hardDrives)
            : this(capacity, isInRaid, hardDrivesInRaid)
        {
            this.hds = hardDrives;
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
            this.hds = new List<HardDrive>();
        }

        public int Capacity
        {
            get
            {
                if (this.isInRaid)
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
            if (this.isInRaid)
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
            if (this.isInRaid)
            {
                if (!this.hds.Any())
                {
                    throw new OutOfMemoryException("No hard drive in the RAID array!");
                }

                return this.hds.First().LoadData(address);
            }

            return this.data[address];
        }
    }
}
