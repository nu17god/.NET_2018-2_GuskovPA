using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Round : Circle
    {
        public string Type;

        public Round(int x, int y, int radius) : base (x, y, radius)
        {
            Type = "Round";
        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawCircle(X, Y, Radius, Type);
        }
    }
}
