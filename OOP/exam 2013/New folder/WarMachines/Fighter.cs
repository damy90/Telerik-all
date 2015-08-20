using System.Text;

namespace WarMachines.Machines
{
    class Fighter : Machine, Interfaces.IFighter
    {
        public bool StealthMode { get; private set; }

        public Fighter(string name, double attack, double defense, bool stealth) : base(name, attack, defense)
        {
            this.HealthPoints = 200;
            this.StealthMode = stealth;
        }

        public void ToggleStealthMode()
        {
            StealthMode = !StealthMode;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.AppendFormat("\n *Stealth: {0}", StealthMode ? "ON" : "OFF");
            return output.ToString();
        }
    }
}