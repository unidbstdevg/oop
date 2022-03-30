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
        List<MyFigure> rects;
        public Form1()
        {
            InitializeComponent();

            rects = new List<MyFigure>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (MyFigure r in rects)
                r.Draw(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            int w = rnd.Next(35, Math.Min(panel1.Width, panel1.Height) / 2);
            int h = rnd.Next(35, Math.Min(panel1.Width, panel1.Height) / 2);
            MyFigure r = new MyEllipse(rnd.Next(panel1.Width - w), rnd.Next(panel1.Height - h), w, h, Color.White, Color.Black);
            rects.Add(r);

            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rects.Clear();
            panel1.Invalidate();
        }
    }
}
