namespace Computers.DrawerStrategy
{
    using System;

    public class ColorfulDrawer : Drawer
    {
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
