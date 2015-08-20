namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ComputerHardDrive
    {
        private readonly bool isHardDriveAreRaid;
        private readonly List<ComputerHardDrive> computerHardDisks;
        private readonly int capacityHardDrive;
        private readonly Dictionary<int, string> data;
        private int hardDrivesInRaid;

        public ComputerHardDrive()
        {
        }

        public ComputerHardDrive(bool isMonochrome)
        {
            this.IsMonochrome = isMonochrome;
        }

        public ComputerHardDrive(int capacityHardDrive, bool isHardDriveAreRaid, int hardDrivesInRaid)
        {
            this.isHardDriveAreRaid = isHardDriveAreRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacityHardDrive = capacityHardDrive;
            this.data = new Dictionary<int, string>(capacityHardDrive);
            this.computerHardDisks = new List<ComputerHardDrive>();
        }

        public ComputerHardDrive(int capacityHardDrive, bool isHardDriveAreRaid, int hardDrivesInRaid, List<ComputerHardDrive> hardDrives)
        {
            this.isHardDriveAreRaid = isHardDriveAreRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacityHardDrive = capacityHardDrive;
            this.data = new Dictionary<int, string>(capacityHardDrive);
            this.computerHardDisks = new List<ComputerHardDrive>(); 
            this.computerHardDisks = hardDrives;
        }

        public bool IsMonochrome { get; set; }

        internal int CapacityHardDrive
        {
            get
            {
                if (this.isHardDriveAreRaid)
                {
                    if (!this.computerHardDisks.Any())
                    {
                        return 0;
                    }

                    return this.computerHardDisks.First().CapacityHardDrive;
                }

                return this.capacityHardDrive;
            }
        }

        public void Draw(string a)
        {
            if (this.IsMonochrome)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(a);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(a);
                Console.ResetColor();
            }
        }

        internal void SaveData(int addr, string newData)
        {
            if (this.isHardDriveAreRaid)
            {
                foreach (var hardDrive in this.computerHardDisks)
                {
                    hardDrive.SaveData(addr, newData);
                }
            }
            else
            {
                this.data[addr] = newData;
            }
        }

        internal string LoadData(int address)
        {
            if (this.isHardDriveAreRaid)
            {
                if (!this.computerHardDisks.Any())
                {
                    throw new ComputerBuildingSystemException("No hard drive in the RAID array!");
                }

                return this.computerHardDisks.First().LoadData(address);
            }

            return this.data[address];
        }
    }
}
