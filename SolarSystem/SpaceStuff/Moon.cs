using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystem.SpaceStuff
{
    class Moon:Astro
    {
        public Moon(int x, int y) : base(x, y)
        {
        }
        override public void Draw(Graphics g)
        {
            R = R / 2;
            SolidBrush mysolidBrush = new SolidBrush(Color.Gray);
            g.FillEllipse(mysolidBrush, x - R, y - R, R * 2, R * 2);
            SolidBrush mysolidBrush2 = new SolidBrush(Color.DarkGray);
            R = R / 5;
            g.FillEllipse(mysolidBrush, x - R, y - R, R * 2, R * 2);
            g.FillEllipse(mysolidBrush, x - R + 5, y - R + 12, R * 2, R * 2);
            g.FillEllipse(mysolidBrush, x - R, y - R - 10, R * 2, R * 2);
        }
    }
}
