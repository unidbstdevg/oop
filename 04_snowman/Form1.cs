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

namespace _04_snowman
{
    public partial class Form1 : Form
    {
        Snowman man;
        Graphics gr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gr = panel1.CreateGraphics();
            man = new Snowman(40, 40, 120);

            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (man != null)
                man.Draw(gr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (man != null)
            {
                man.X -= 10;
                panel1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (man != null)
            {
                man.X += 10;
                panel1.Refresh();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (man != null)
            {
                man.Y -= 10;
                panel1.Refresh();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (man != null)
            {
                man.Y += 10;
                panel1.Refresh();
            }
        }
    }
}
