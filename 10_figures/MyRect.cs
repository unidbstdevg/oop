using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_rect
{
    public class MyRect : MyFigure
    {
        public MyRect()
        {

        }

        public MyRect(int X, int Y, int H, int W, Color CC, Color BC)
            : base(X, Y, H, W, CC, BC)
        {
            name = "rect";
        }

        public override void Draw(Graphics gr)
        {
            Pen pn = new Pen(cColor, 2);
            Brush br = new SolidBrush(bColor);

            gr.FillRectangle(br, x, y, width, height);
            gr.DrawRectangle(pn, x, y, width, height);
        }

    }


    class MyIndependentRect
    {
        private int x, y, height, width;
        private Color cColor, bColor;

        public MyIndependentRect(int X, int Y, int H, int W)
        {
            x = X;
            y = Y;
            height = H;
            width = W;

            cColor = Color.White;
            bColor = Color.Black;
        }

        public void Draw(Graphics gr)
        {
            Pen pn = new Pen(cColor, 2);
            Brush br = new SolidBrush(bColor);

            gr.FillRectangle(br, x, y, width, height);
            gr.DrawRectangle(pn, x, y, width, height);
        }
    }
}


