using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystem.SpaceStuff
{
    class Serp:Astro
    {
        public Serp(int x, int y) : base(x, y)
        {
        }
        override public void Draw(Graphics g)
        {
            R = R / 3;
            Brush b = new SolidBrush(Color.Purple);
            Pen p = new Pen(b, 3);
            g.DrawArc(p, x - R, y - R, R * 2, R * 2, 30, 180);
            g.DrawArc(p, x - R, y - R + 12, R * 2, R * 2, 30, 180);
        }
    }
}
