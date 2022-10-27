using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystem.SpaceStuff
{
    class Mars:Astro
    {
        public Mars(int x, int y) : base(x, y)
        {
        }
        override public void Draw(Graphics g)
        {
            R = R - 5;
            SolidBrush mysolidBrush = new SolidBrush(Color.Red);
            g.FillEllipse(mysolidBrush, x - R, y - R, R * 2, R * 2);
        }
    }
}
