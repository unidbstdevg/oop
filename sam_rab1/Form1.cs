using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sam_rab1
{
    public partial class Form1 : Form
    {
        TrafficLight tf;
        Graphics gr;
        public Form1()
        {
            InitializeComponent();

            tf = new TrafficLight(100, 200, 50, 0);
            gr = panel1.CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select from listbox");
                return;
            }
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex > 2)
            {
                MessageBox.Show("Unreachable code in button click switch mode");
                return;
            }
            tf.mode = listBox1.SelectedIndex;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            tf.Draw(gr);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tf.Next();
            panel1.Refresh();
        }
    }
}
