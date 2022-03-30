using _03_ellipse;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_snowman
{
    class Snowman
    {
        private int x;
        private int y;
        private int height;
        MyEllipse head;
        MyEllipse body;
        MyEllipse down;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                head.X = value;
                body.X = value;
                down.X = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;

                int d = height / 3;
                head.Y = value;
                body.Y = value + d;
                down.Y = value + d * 2;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >= 10)
                    height = value;
                else
                    height = 10;
            }
        }

        public Snowman(int xx, int yy, int hh)
        {
            x = xx;
            y = yy;
            Height = hh;

            int d = height / 3;
            head = new MyEllipse(x, y, d, d, Color.Black, Color.White);
            body = new MyEllipse(x, y + d, d, d, Color.Black, Color.White);
            down = new MyEllipse(x, y + 2*d, d, d, Color.Black, Color.White);
        }

        public void Draw(Graphics gr)
        {
            head.Draw(gr);
            body.Draw(gr);
            down.Draw(gr);
        }
    }
}
