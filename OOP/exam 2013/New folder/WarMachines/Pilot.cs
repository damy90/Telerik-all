using System;
using System.Collections.Generic;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Pilot : Interfaces.IPilot
    {
        private string name;

        public List<IMachine> Machines { get; private set; }

        public Pilot(string name)
        {
            this.Name = name;
            this.Machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!(value == null))
                    this.name = value;
                else
                    throw new ArgumentNullException("Pilot name cannot be null");
            }
        }

        public void AddMachine(IMachine machine)
        {
            Machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder(Name);
            output.AppendFormat(" - {0} {1}", Machines.Count > 0 ? Machines.Count.ToString() : "no", Machines.Count != 1 ? "machines" : "machine");
            foreach (var machine in Machines)
                output.Append(machine.ToString());
            return output.ToString();
        }
    }
}