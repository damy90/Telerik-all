namespace Computers.ComputerParts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class SingleHardDrive : HardDrive
    {
        private readonly Dictionary<int, string> dataContainer;

        public SingleHardDrive(int capacity)
        {
            this.Capacity = capacity;
            this.dataContainer = new Dictionary<int, string>();
        }

        public override void SaveDataToAddress(string data, int address)
        {
            if (this.dataContainer[address] != null)
            {
                this.dataContainer[address] = data;
            }
            else
            {
                throw new ArgumentException("This address is already taken!");
            }
        }

        public override string LoadDataFromAddress(int address)
        {
            if (this.dataContainer[address] != null)
            {
                return this.dataContainer[address];
            }
            else
            {
                throw new ArgumentException("There is no such address!");
            }
        }

        public override void Add(HardDrive hardDrive)
        {
            throw new ArgumentException("Cannot add hard drive to hard drive!");
        }
    }
}