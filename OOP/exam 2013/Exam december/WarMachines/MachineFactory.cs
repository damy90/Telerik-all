namespace WarMachines.Engine
{
    using System;
    using System.Collections.Generic;
    using WarMachines.Interfaces;
    using WarMachines.Machines;

    public class MachineFactory : IMachineFactory
    {
        private static List<Pilot> pilots = new List<Pilot>();
        
        private static List<Machine> machines = new List<Machine>();

        public IPilot HirePilot(string name)
        { //май забива
            IsNameInUse(name);

            Pilot pilot = new Pilot(name);
            pilots.Add(pilot);
            return pilot;
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            IsNameInUse(name);

            Tank tank = new Tank(name, attackPoints, defensePoints);
            machines.Add(tank);
            return tank;
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            IsNameInUse(name);

            Fighter fighter = new Fighter(name, attackPoints, defensePoints, stealthMode);
            machines.Add(fighter);
            return fighter;
        }

        private void IsNameInUse(string name)
        {
            //if (pilots!=null)
            foreach (IPilot someone in pilots)
                if (someone.Name == name)
                    throw new ApplicationException("Name in use");
            //if (machines != null)
            foreach (IMachine machine in machines)
                if (machine.Name == name)
                    throw new ApplicationException("Name in use");
        }
    }
}