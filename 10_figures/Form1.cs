using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_rect
{
    public partial class Form1 : Form
    {
        Picture pic;
        public Form1()
        {
            InitializeComponent();

            pic = new Picture(panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pic.Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            int w = rnd.Next(35, Math.Min(panel1.Width, panel1.Height) / 2);
            int h = rnd.Next(35, Math.Min(panel1.Width, panel1.Height) / 2);
            Color color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

            MyFigure elip = new MyEllipse(rnd.Next(panel1.Width - w), rnd.Next(panel1.Height - h), w, h, Color.White, color);
            pic.Add(elip);

            MyFigure rect = new MyRect(rnd.Next(panel1.Width - w), rnd.Next(panel1.Height - h), w, h, Color.White, color);
            pic.Add(rect);

            /* int x1 = rnd.Next(0, panel1.Width); */
            /* int x2 = rnd.Next(0, panel1.Width); */
            /* int y1 = rnd.Next(0, panel1.Height); */
            /* int y2 = rnd.Next(0, panel1.Height); */
            /* int width = 5; */
            /* MyLine line = new MyLine(x1, y1, x2, y2, width, color); */
            /* pic.Add(line); */

            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pic.Clear();
            panel1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e) {
            pic.GreenifyAll();

            panel1.Invalidate();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            pic.Select(e.X, e.Y);

            panel1.Invalidate();
        }
    }
}
