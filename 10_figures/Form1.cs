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
        int oldX = 0;
        int oldY = 0;

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
            if(pic.Figure == null) {
                MessageBox.Show("Firstly select figure");
                return;
            }

            if (colorDialog1.ShowDialog() != DialogResult.Cancel) {
                pic.Figure.BColor = colorDialog1.Color;
            }

            panel1.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e) {
            if(pic.Figure == null) {
                MessageBox.Show("Firstly select figure");
                return;
            }

            if (colorDialog1.ShowDialog() != DialogResult.Cancel) {
                pic.Figure.CColor = colorDialog1.Color;
            }

            panel1.Invalidate();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            oldX = e.X;
            oldY = e.Y;

            if(rb_select.Checked) {
                if (pic.Figure != null) {
                    if (pic.Figure.Shot(e.X, e.Y))
                        return;
                }
                MyFigure fsel = pic.Select(e.X, e.Y);
                if(fsel != null) {
                    pic.Figure.Shot(e.X, e.Y);
                }
            } else if(rb_create.Checked) {
                MyFigure f;
                switch(list_figures.Text) {
                    case "Ellipse":
                        f = new MyEllipse(e.X, e.Y, 1, 1, Color.White, Color.Yellow);
                        break;
                    case "Rectangle":
                        f = new MyRect(e.X, e.Y, 1, 1, Color.White, Color.Yellow);
                        break;

                    default:
                        MessageBox.Show("Firstly choose figure type");
                        return;
                }

                pic.Add(f);
            }

            panel1.Invalidate();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if (pic.Figure == null)
                return;
            if (e.Button != MouseButtons.Left)
                return;

            pic.Figure.Drag(e.X - oldX, e.Y - oldY);
            oldX = e.X;
            oldY = e.Y;

            panel1.Invalidate();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) {
            if(!rb_select.Checked) {
                pic.Deselect();
                panel1.Invalidate();
            }
        }


        private void mode_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
