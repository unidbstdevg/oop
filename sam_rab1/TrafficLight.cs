using _03_ellipse;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sam_rab1
{
    class TrafficLight
    {
        int X, Y, Height;
        int Mode;
        List<MyEllipse> lights;

        enum StateColor { BLACK, RED, GREEN, YELLOW };
        StateColor state;
        // this is for mode = 1
        StateColor prev_state;

        public int mode
        {
            get { return mode; }
            set
            {
                Mode = value;
                state = StateColor.BLACK;
            }
        }

        TrafficLight()
        {

        }

        public TrafficLight(int x, int y, int height, int mode)
        {
            if(mode < 0 || mode > 2)
            {
                Console.WriteLine("Wrong mode number. Setting by default to 0");
                mode = 0;
            }
            X = x;
            Y = y;
            Height = height;
            Mode = mode;

            lights = new List<MyEllipse>();

            lights.Add(new MyEllipse(x, y, height, height, Color.Blue, Color.Black));
            lights.Add(new MyEllipse(x, y - height, height, height, Color.Blue, Color.Black));
            lights.Add(new MyEllipse(x, y - 2 * height, height, height, Color.Blue, Color.Black));

            state = StateColor.RED;
            prev_state = StateColor.RED;
        }

        public void Draw(Graphics gr)
        {
            foreach (MyEllipse light in lights)
            {
                light.Draw(gr);
            }
        }

        public void Next()
        {
            if (Mode == 0)
            {
                switch (state)
                {
                    case StateColor.RED:
                        state = StateColor.GREEN;
                        break;
                    case StateColor.GREEN:
                        state = StateColor.YELLOW;
                        break;
                    case StateColor.YELLOW:
                        state = StateColor.RED;
                        break;

                    default:
                        state = StateColor.RED;
                        break;
                }
            }
            else if (Mode == 1)
            {
                if (state == StateColor.YELLOW)
                {
                    switch (prev_state) {
                        case StateColor.RED:
                            state = StateColor.GREEN;
                            break;
                        case StateColor.GREEN:
                            state = StateColor.RED;
                            break;

                        default:
                            state = StateColor.RED;
                            break;
                    }
                } else {
                    prev_state = state;
                    state = StateColor.YELLOW;
                }
            }
            else if (Mode == 2)
            {
                switch (state)
                {
                    case StateColor.YELLOW:
                        state = StateColor.BLACK;
                        break;
                    case StateColor.BLACK:
                        state = StateColor.YELLOW;
                        break;

                    default:
                        state = StateColor.YELLOW;
                        break;
                }
            }
            else
            {
                Console.WriteLine("This is unreachable code in Next() method in TrafficLight class");
            }

            UpdateCircleColors();
        }

        public override String ToString()
        {
            return "TrafficLight with curent state " + state;
        }

        void UpdateCircleColors()
        {
            foreach(MyEllipse light in lights)
            {
                light.CColor = Color.Black;
            }
            switch(state)
            {
                case StateColor.RED:
                    lights[2].CColor = Color.Red;
                    break;
                case StateColor.GREEN:
                    lights[0].CColor = Color.Green;
                    break;
                case StateColor.YELLOW:
                    lights[1].CColor = Color.Yellow;
                    break;
                case StateColor.BLACK:
                    break;
            }
        }
    }
}
