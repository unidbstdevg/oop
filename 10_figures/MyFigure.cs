using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_rect
{
    public class MyFigure : IDrawableC
    {
        protected int x, y, height, width;
        protected Color cColor, bColor;
        protected string name = "figure";

        public Color CColor { get { return cColor; } set { cColor = value; } }

        private bool selected = true;
        public bool Selected {
            get { return selected; }
            set { selected = value; }
        }

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
            Pen pn = new Pen(Color.Black, 1);
            pn.DashStyle = DashStyle.Dash;
            pn.DashPattern = new float[2] { 6, 3 };

            int gap = 20;

            Point p1 = new Point(x - gap, y - gap);
            Point p2 = new Point(x - gap, y + height + gap);
            Point pgap = new Point(x + width + gap, y + height + gap);
            Point p4 = new Point(x + width + gap, y - gap);
            gr.DrawLine(pn, p1, p2);
            gr.DrawLine(pn, p2, pgap);
            gr.DrawLine(pn, pgap, p4);
            gr.DrawLine(pn, p4, p1);

            int pad = 5;
            int pad_size = 10;
            gr.DrawRectangle(pn, x - gap - pad, y - gap - pad, pad_size, pad_size);
            gr.DrawRectangle(pn, x - gap - pad, y + height + gap, pad_size, pad_size);
            gr.DrawRectangle(pn, x + width + gap, y + height + gap, pad_size, pad_size);
            gr.DrawRectangle(pn, x + width + gap, y - gap - pad, pad_size, pad_size);
        }

        public virtual bool Touch(int xx, int yy) {
            return false;
        }
    }
}
