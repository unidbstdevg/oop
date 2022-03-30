using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_rect
{
    [Serializable]
    public class MyFigure : IDrawableC
    {
        protected int x, y, height, width;
        protected Color cColor, bColor;
        protected string name = "figure";

        private int activePoint = 3;

        public Color CColor { get { return cColor; } set { cColor = value; } }
        public Color BColor { get { return bColor; } set { bColor = value; } }
        public int Width { get { return width; } set { width = value; } }
        public int Height { get { return height; } set { height = value; } }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        private bool selected = true;
        public bool Selected {
            get { return selected; }
            set { selected = value; }
        }

        int gap = 20;
        int pad = 30;

        public MyFigure()
        {
            x = 10;
            y = 10;
            height = 50;
            width = 50;

            cColor = Color.White;
            bColor = Color.Black;
        }
        public MyFigure(int X, int Y, int H, int W, Color CC, Color BC)
        {
            x = X;
            y = Y;
            height = H > 0 ? H : 50;
            width = W > 0 ? W : 50;

            cColor = CC;
            bColor = BC;
        }

        public override string ToString()
        {
            return name + " : x = " + x + ", y = " + y + ", w = " + width + ", h = " + height;
        }

        public virtual void Draw(Graphics gr) {
            if (Selected)
                DrawFrame(gr);
        }
        public void DrawFrame(Graphics gr) {
            int nx = x;
            int nwidth = width;
            int ny = y;
            int nheight = height;

            if(nwidth < 0) {
                nwidth = width * -1;
                nx -= nwidth;
            }
            if(nheight < 0) {
                nheight = height * -1;
                ny -= nheight;
            }

            Pen pn = new Pen(Color.Black, 1);
            pn.DashStyle = DashStyle.Dash;
            pn.DashPattern = new float[2] { 6, 3 };

            Point p1 = new Point(nx - gap, ny - gap);
            Point p2 = new Point(nx - gap, ny + nheight + gap);
            Point p3 = new Point(nx + nwidth + gap, ny + nheight + gap);
            Point p4 = new Point(nx + nwidth + gap, ny - gap);
            gr.DrawLine(pn, p1, p2);
            gr.DrawLine(pn, p2, p3);
            gr.DrawLine(pn, p3, p4);
            gr.DrawLine(pn, p4, p1);

            int pad_size = pad;
            gr.DrawRectangle(pn, nx - gap - pad, ny - gap - pad, pad_size, pad_size);
            gr.DrawRectangle(pn, nx - gap - pad, ny + nheight + gap, pad_size, pad_size);
            gr.DrawRectangle(pn, nx + nwidth + gap, ny + nheight + gap, pad_size, pad_size);
            gr.DrawRectangle(pn, nx + nwidth + gap, ny - gap - pad, pad_size, pad_size);
        }

        public virtual bool Touch(int xx, int yy) {
            return false;
        }

        public void Drag(int dx, int dy) {
            if(activePoint == 0) {
                x += dx;
                y += dy;
            } else if(activePoint == 1) {
                Width -= dx;
                Height -= dy;
                x += dx;
                y += dy;
            } else if(activePoint == 2) {
                Width += dx;
                Height -= dy;
                y += dy;
            } else if(activePoint == 3) {
                Width += dx;
                Height += dy;
            } else if(activePoint == 4) {
                Width -= dx;
                Height += dy;
                x += dx;
            }
        }

        public bool Shot(int xx, int yy)
        {
            activePoint = -1;
            if(xx > x-gap && xx < x + width + gap && yy > y - gap && yy < y + height + gap) {
                activePoint = 0;
            } else if (xx > x - (gap+pad) && xx < x && yy > y - (gap+pad) && yy < y) {
                activePoint = 1;
            } else if (xx > x + width + gap && xx < x + width + (gap+pad) && yy > y - (gap+pad) && yy < y) {
                activePoint = 2;
            } else if (xx > x + width + gap && xx < x + width + (gap+pad) && yy > y + height + gap && yy < y + height + (gap+pad)) {
                activePoint = 3;
            } else if (xx > x - (gap+pad) && xx < x && yy > y + height + gap && yy < y + height + (gap+pad)) {
                activePoint = 4;
            }

            if (activePoint == -1)
                return false;
            else
                return true;
        }

        public void FixCoordinates() {
            if(width < 0) {
                width *= -1;
                x -= width;
            }
            if(height < 0) {
                height *= -1;
                y -= height;
            }
        }
    }
}
