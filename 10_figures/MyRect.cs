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

            gr.FillRectangle(br, x, y, width, height);
            gr.DrawRectangle(pn, x, y, width, height);

            base.Draw(gr);
        }

        public override bool Touch(int xx, int yy) {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(x, y, width, height));
            return path.IsVisible(xx, yy);
        }
    }
}

