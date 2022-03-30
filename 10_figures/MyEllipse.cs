using System.Drawing;

namespace my_rect
{
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

    }

}