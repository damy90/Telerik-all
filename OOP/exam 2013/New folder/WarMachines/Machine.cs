using System;
using System.Collections.Generic;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;

        public IList<string> Targets { get; private set; }

        public Machine(string name, double attack, double defense)
        {
            this.Name = name;
            this.attackPoints = attack;
            this.defensePoints = defense;
            this.Targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.name = value;
                else
                    throw new ArgumentNullException("Machine name cannot be null");
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot ;
            }
            set
            {
                if (!(value == null))//TODO check if b***it
                    this.pilot = value;
                else
                    throw new ArgumentNullException("Machine Pilot name cannot be null");
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (!(value == null))
                    this.healthPoints = value;
                else
                    throw new ArgumentNullException("Healh cannot be null");
            }
        }

        public double AttackPoints//TODO {get;}
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            set
            {
                this.defensePoints = value;
            }
        }

        public void Attack(string target)
        {
            Targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("\n- {0}\n *Type: {1}\n", this.Name, GetType().Name);//TODO This class or child class
            output.AppendFormat(" *Health: {0}\n *Attack: {1}\n *Defense: {2}\n *Targets: ",
                HealthPoints, AttackPoints, DefensePoints);
            output.AppendFormat("{0}", Targets.Count > 0 ? string.Join(", ", Targets) : "None");
            
            return output.ToString();
        }
    }
}