using Computers.DrawerStrategy;
using Computers.Interfaces;

namespace Computers.ComputerParts
{
    using System;

    public class VideoCard : ComputerPart, IDrawable
    {
        public VideoCard()
            : this(new ColorfulDrawer())
        {
        }

        public VideoCard(Drawer drawer)
            : base(ComputerPartType.VideoCard)
        {
            this.Drawer = drawer;
        }

        public Drawer Drawer
        {
            get;
            private set;
        }

        public void Draw(string data)
        {
            this.Drawer.Draw();
            Console.WriteLine(data);
        }
    }
}
