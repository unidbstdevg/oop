using _03_ellipse;
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
        int tt1_green = 0;
        TrafficLight tf;
        MyEllipse car;

        Graphics gr;
        public Form1()
        {
            InitializeComponent();

            tf = new TrafficLight(100, 200, 50, 0);
            tf.GreenEvent += OnGreen;
            tf.NotGreenEvent += OnNotGreen;
            tf.Next();

            car = new MyEllipse(300, 500, 50, 50, Color.Blue, Color.Black);

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
            car.Draw(gr);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer2.Enabled) {
                if(tt1_green < 2) {
                    tt1_green += 1;
                    return;
                } else {
                    tt1_green = 0;
                }
            }

            tf.Next();
            panel1.Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            car.X += 4;
            if(car.X > panel1.Width)
                car.X = -30;

            panel1.Refresh();
        }

        private void OnGreen()
        {
            timer2.Start();
        }
        private void OnNotGreen()
        {
            timer2.Stop();
        }
    }
}
