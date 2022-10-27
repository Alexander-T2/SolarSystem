using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystem.SpaceStuff
{
    class Comet: Astro
    {
        public Comet(int x, int y) : base(x, y)
        {
        }
        override public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.White);
            Pen p = new Pen(b, 3);
            R = R / 3;
            g.DrawLine(p, x - R, y - R, x + 2 * R, y - R);
            g.DrawLine(p, x - R, y - R, x + 2 * R, y + R);
            g.DrawLine(p, x - R, y - R, x + 2 * R, y - 2*R);
            SolidBrush mysolidBrush = new SolidBrush(Color.DarkCyan);
            g.FillEllipse(mysolidBrush, x - R, y - R, R * 2, R * 2);
            
        }
    }
}
