using System.CodeDom;
using _03_ellipse;
using System;
using System.Collections.Generic;
using System.Drawing;


namespace _05_look
{
    class Eye
    {
        MyEllipse ball;
        MyEllipse pupil;

        // pupil
        int r;
        // ball
        int R;

        // coords of center
        int cx;
        int cy;

        public Eye(int x, int y, int _R, Color clr)
        {
            R = _R;

            ball = new MyEllipse(x, y, R, R, Color.Black, Color.White);

            r = R / 3;
            cx = x + r;
            cy = y + r;
            pupil = new MyEllipse(cx, cy, r, r, Color.White, clr);
        }

        public void Draw(Graphics gr)
        {
            ball.Draw(gr);
            pupil.Draw(gr);
        }

        public void LookAt(int x, int y)
        {
            int dy = y - pupil.Y;
            int dx = x - pupil.X;
            double gipotenyza = Math.Sqrt(dy * dy + dx * dx);
            double ky = dy / gipotenyza;
            double kx = dx / gipotenyza;

            double ddy = ky * r;
            double ddx = kx * r;
            if (gipotenyza < R / 2)
            {
                pupil.X = cx;
                pupil.Y = cy;
            }
            else
            {
                pupil.X = cx + (int)(ddx);
                pupil.Y = cy + (int)(ddy);
            }

        }

    }
    public class Eyes
    {
        private int x;
        private int y;
        private int r;

        Eye leye;
        Eye reye;
        private int gap;

        public Eyes(int X, int Y, int R = 10, int Gap = 0)
        {
            x = X;
            y = Y;
            r = R;

            leye = new Eye(x, y, r, Color.Red);
            reye = new Eye(x + r, y, r, Color.Blue);
        }

        public void Draw(Graphics gr)
        {
            leye.Draw(gr);
            reye.Draw(gr);
        }

        public void LookAt(int x, int y)
        {
            leye.LookAt(x, y);
            reye.LookAt(x, y);
        }
    }
}
