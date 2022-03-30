using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ellipse
{
    class MyEllipse
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private Color cColor;
        private Color bColor;

        public int X
        {
            get { return x; }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
            }
        }
        public int Width
        {
            get { return width; }
            set
            {
                if (value < 10)
                    width = 10;
                else
                    width = value;
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value < 10)
                    height = 10;
                else
                    height = value;
            }
        }
        public MyEllipse()
        {
            x = y = 0;
            width = height = 50;
            cColor = Color.Black;
            bColor = Color.White;
        }

        public MyEllipse(int xx, int yy, int ww, int hh, Color cc, Color bc)
        {
            x = xx;
            y = yy;
            width = ww;
            height = hh;
            cColor = cc;
            bColor = bc;
        }
        public void Draw(Graphics gr)
        {
            Pen pn = new Pen(cColor, 2);
            Brush br = new SolidBrush(bColor);

            gr.FillEllipse(br, x, y, width, height);
            gr.DrawEllipse(pn, x, y, width, height);
        }
    }
}
