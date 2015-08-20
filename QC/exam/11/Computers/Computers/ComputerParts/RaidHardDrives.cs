namespace Computers.ComputerParts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RaidHardDrives : HardDrive
    {
        private readonly ICollection<HardDrive> hardDrives;

        public RaidHardDrives()
        {
            this.hardDrives = new List<HardDrive>();
        }

        public override int Capacity
        {
            get
            {
                if (this.hardDrives.Any())
                {
                    return this.hardDrives.First().Capacity;
                }

                throw new ArgumentNullException("There are no hard drives in this raid!");
            }
        }

        public override void Add(HardDrive hardDrive)
        {
            this.hardDrives.Add(hardDrive);
        }

        public override string LoadDataFromAddress(int address)
        {
            if (this.hardDrives.Any())
            {
                return this.hardDrives.First().LoadDataFromAddress(address);
            }
            else
            {
                throw new ArgumentException("No hard drive in the RAID array!");
            }
        }

        public override void SaveDataToAddress(string data, int address)
        {
            foreach (var hardDrive in this.hardDrives)
            {
                hardDrive.SaveDataToAddress(data, address);
            }
        }
    }
}
