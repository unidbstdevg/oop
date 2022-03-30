using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_rect
{
    public class MyFigure
    {
        protected int x, y, height, width;
        protected Color cColor, bColor;
        protected string name = "figure";

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

        public virtual void Draw(Graphics gr)
        {
            Pen pn = new Pen(cColor, 2);

            gr.DrawEllipse(pn, x, y, 5, 5);
        }

        public override string ToString()
        {
            return name + " : x = " + x + ", y = " + y + ", w = " + width + ", h = " + height;
        }
    }


    public class MyEllipse : MyFigure
    {
        public MyEllipse()
        {

        }

        public MyEllipse(int X, int Y, int H, int W, Color CC, Color BC)
            : base(X, Y, H, W, CC, BC)
        {
            name = "ellipse";
        }

        public override void Draw(Graphics gr)
        {
            Pen pn = new Pen(cColor, 2);
            Brush br = new SolidBrush(bColor);

            gr.FillEllipse(br, x, y, width, height);
            gr.DrawEllipse(pn, x, y, width, height);
        }

    }

}