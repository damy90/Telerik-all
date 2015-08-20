namespace WarMachines
{
    using WarMachines.Engine;

    public class WarMachinesProgram
    {
        public static void Main()
        {
            //StreamWriter sw = new StreamWriter(new FileStream("Log2.txt", FileMode.Create));
            //Console.SetOut(sw);
            WarMachineEngine.Instance.Start();
            //sw.Close();
        }
    }
}