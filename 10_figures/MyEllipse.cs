using System.Drawing;
using System.Drawing.Drawing2D;
using System;

namespace my_rect
{
    [Serializable]
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

            base.Draw(gr);
        }

        public override bool Touch(int xx, int yy) {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(x, y, width, height);
            return path.IsVisible(xx, yy);
        }

    }

}
