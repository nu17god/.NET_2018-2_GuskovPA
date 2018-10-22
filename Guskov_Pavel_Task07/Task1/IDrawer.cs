using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    interface IDrawer
    {
        void DrawLine(int x1, int y1, int x2, int y2, string type);
        void DrawCircle(int x1, int y1, int r, string type);
        void DrawRing(int x, int y, int radius, int smallRadius, string type);
    }
}
