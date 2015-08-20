namespace Computers.UI.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HardDrive
    {
        private bool isInRaid;
        private int hardDrivesInRaid;
        private IList<HardDrive> hardDrives;
        private SortedDictionary<int, string> info;
        private int capacity;
        private Dictionary<int, string> data;

        internal HardDrive(int capacity, bool isInRaid)
        {
            this.isInRaid = isInRaid;
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
        }

        internal HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
            : this(capacity, isInRaid)
        {
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.hardDrives = new List<HardDrive>();
        }

        internal HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid, List<HardDrive> hardDrives)
            : this(capacity, isInRaid, hardDrivesInRaid)
        {
            this.hardDrives = hardDrives;
        }

        public int Capacity
        {
            get
            {
                if (isInRaid)
                {
                    if (!this.hardDrives.Any())
                    {
                        return 0;
                    }
                    return this.hardDrives.First().Capacity;
                }
                else
                {
                    return capacity;
                }
            }
        }

        public void SaveData(int addr, string newData)
        {
            if (isInRaid)
            {
                foreach (var hardDrive in this.hardDrives)
                {
                    hardDrive.SaveData(addr, newData);
                }
            }
            else this.data[addr] = newData;
        }

        public string LoadData(int address)
        {
            if (isInRaid)
            {
                if (!this.hardDrives.Any())
                {
                    throw new OutOfMemoryException("No hard drive in the RAID array!");
                }

                return this.hardDrives.First().LoadData(address);
            }
            else if (true)
            {
                return this.data[address];
            }
        }
    }
}
