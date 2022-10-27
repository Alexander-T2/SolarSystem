using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystem.SpaceStuff
{
    class Sun : Astro
    {
        public Sun(int x, int y) : base(x, y)
        {
        }
        override public void Draw(Graphics g)
        {
            R = R * 2;
            SolidBrush mysolidBrush = new SolidBrush(Color.Yellow);
            g.FillEllipse(mysolidBrush, x - R, y - R, R * 2, R * 2);
        }
    }
}
