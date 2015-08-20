namespace Computers.DrawerStrategy
{
    using System;

    public class MonochromeDrawer : Drawer
    {
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
