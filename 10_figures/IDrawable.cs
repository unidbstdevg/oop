using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_rect
{
    interface IDrawable
    {
        void Draw(Graphics gr);
    }
    interface IDrawableC : IDrawable
    {
        Color Color {
            get;
            set;
        }
    }
}


