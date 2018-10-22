using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Rectangle : Line
    {
        public Rectangle(int x1, int y1, int x2, int y2) : base (x1, y1, x2, y2)
        {
            Type = "Rectangle";
        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawLine(X1, Y1, X2, Y2, Type);
        }
    }
}
