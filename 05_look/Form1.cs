using _03_ellipse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_look
{
    public partial class Form1 : Form
    {
        List<Eyes> eyes;
        Graphics gr;
        public Form1()
        {
            InitializeComponent();

            gr = panel1.CreateGraphics();
            eyes = new List<Eyes>();;

            eyes.Add(new Eyes(250, 250, 50));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            int r = rnd.Next(35, Math.Min(panel1.Width, panel1.Height) / 3);
            Eyes es = new Eyes(rnd.Next(panel1.Width - 2 * r), rnd.Next(panel1.Height - r), r);
            eyes.Add(es);

            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Eyes es in eyes)
                es.Draw(gr);
        }

        private void panel1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            foreach(Eyes es in eyes)
                es.LookAt(e.X, e.Y);

            panel1.Refresh();
        }

    }
}
