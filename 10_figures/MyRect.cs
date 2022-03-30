using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace my_rect
{
    [Serializable]
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

            gr.FillRectangle(br, nx, ny, nwidth, nheight);
            gr.DrawRectangle(pn, nx, ny, nwidth, nheight);

            base.Draw(gr);
        }

        public override bool Touch(int xx, int yy) {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(x, y, width, height));
            return path.IsVisible(xx, yy);
        }
    }
}

