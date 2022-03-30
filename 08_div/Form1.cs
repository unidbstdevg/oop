using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_div
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;
            try {
                int a, b, c;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                c = a / b;

                result = c.ToString();
            } catch (FormatException ex) {
                result = "textbox 1 or 2 is SHIt!";
            } catch (DivideByZeroException ex) {
                result = "you CAN't divide by zero";
            }

            MessageBox.Show(result);
        }
    }
}
