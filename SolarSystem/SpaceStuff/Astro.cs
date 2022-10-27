using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystem.SpaceStuff
{
    abstract class Astro
    {
        protected static int R;
        protected int x, y;
        protected static Color drawingColor;
        static Astro()
        {
            R = 30;
        }
        public Astro(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        abstract public void Draw(Graphics g);
    }
}
