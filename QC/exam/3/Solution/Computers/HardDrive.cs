namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HardDrive
    {
        // SortedDictionary<int, string> info;
        private bool isInRaid;
        private int hardDrivesInRaid;
        private IList<HardDrive> raid;
        private int capacity;
        private Dictionary<int, string> data;

        public HardDrive()
        {
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
            : this(capacity, isInRaid, hardDrivesInRaid, new List<HardDrive>())
        {
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid, IList<HardDrive> hardDrives)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
            this.raid = hardDrives;
        }

        private int Capacity
        {
            get
            {
                if (this.isInRaid)
                {
                    if (!this.raid.Any())
                    {
                        return 0;
                    }

                    return this.raid.First().Capacity;
                }
                else
                {
                    return this.capacity;
                }
            }
        }

        public void SaveData(int address, string newData)
        {
            if (this.isInRaid)
            {
                foreach (var hardDrive in this.raid)
                {
                    hardDrive.SaveData(address, newData);
                }
            }
            else
            {
                this.data[address] = newData;
            }
        }

        public string LoadData(int address)
        {
            if (this.isInRaid)
            {
                if (!this.raid.Any())
                {
                    throw new InvalidOperationException("No hard drive in the RAID array!");
                }

                return this.raid.First().LoadData(address);
            }
            else
            {
                return this.data[address];
            }
        }
    }
}
