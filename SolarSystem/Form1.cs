using System;
using SolarSystem.SpaceStuff;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystem
{
    public partial class Form1 : Form
    {
        Astro[] shapes = new Astro[7] { new Sun(400, 250), new Moon(200, 250), new Serp(200, 250), new Saturn(400, 100), new Mars(400, 350), new Europe(500, 250), new Comet(500, 150) };
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (sunToolStripMenuItem.Checked) shapes[0].Draw(g);
            if (moonToolStripMenuItem.Checked) shapes[1].Draw(g);
            if (serpToolStripMenuItem.Checked) shapes[2].Draw(g);
            if (saturnToolStripMenuItem.Checked) shapes[3].Draw(g);
            if (marsToolStripMenuItem.Checked) shapes[4].Draw(g);
            if (europeToolStripMenuItem.Checked) shapes[5].Draw(g);
            if (cometToolStripMenuItem.Checked) shapes[6].Draw(g);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void moonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void serpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void saturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void marsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void europeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void cometToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
