using System.Text;

namespace WarMachines.Machines
{
    public class Tank : Machine, Interfaces.ITank
    {
        public bool DefenseMode { get; private set; }

        public Tank(string name, double attack, double defense) : base(name, attack, defense)
        {
            this.HealthPoints = 100;
            this.DefenseMode = false;
            ToggleDefenseMode();
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefenseMode = false;
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
            else
            {
                this.DefenseMode = true;
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.AppendFormat("\n *Defense: {0}", DefenseMode ? "ON" : "OFF");
            return output.ToString();
        }
    }
}