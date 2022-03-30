using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_rect
{
    public class MyLine : IDrawableC
    {
        protected int x1, y1, x2, y2, width;
        protected Color cColor;
        protected string name = "line";

        public int X1 { get { return x1; } set { x1 = value; } }
        public int Y1 { get { return y1; } set { y1 = value; } }
        public int X2 { get { return x2; } set { x2 = value; } }
        public int Y2 { get { return y2; } set { y2 = value; } }
        public Color Color { get { return cColor; } set { cColor = value; } }
        public MyLine()
        {
            x1 = 10;
            y1 = 10;
            x2 = 50;
            y2 = 50;
            width = 5;

            cColor = Color.White;
        }

        public MyLine(int X1, int Y1, int X2, int Y2,int Width, Color CC)
        {
            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
            width = Width;

            cColor = CC;
        }

        public void Draw(Graphics gr)
        {
            Pen pn = new Pen(cColor, width);

            /* gr.FillRectangle(br, x, y, width, height); */
            gr.DrawLine(pn, new PointF(x1, y1), new PointF(x2, y2));
        }
    }
}


