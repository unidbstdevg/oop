using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_ellipse
{
    public partial class Form1 : Form
    {
        MyEllipse me1 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            me1 = new MyEllipse(150, 100, 90, 50, Color.Green, Color.Yellow);
            Graphics gr = panel1.CreateGraphics();
            me1.Draw(gr);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(me1 != null)
            {
                Graphics gr = panel1.CreateGraphics();
                me1.Draw(gr);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(me1 != null)
            {
                me1.X -= 10;
                panel1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (me1 != null)
            {
                me1.X += 10;
                panel1.Refresh();
            }
        }
    }
}
