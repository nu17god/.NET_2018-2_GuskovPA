using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class ConsoleDriver : IDrawer
    {
        public void DrawLine(int x1, int y1, int x2, int y2, string type)
        {
            Console.WriteLine($"{type}({x1},{y1})({x2},{y2})");
        }

        public void DrawCircle(int x, int y, int radius, string type)
        {
            Console.WriteLine($"{type} ({x},{y} radius is {radius}");
        }

        public void DrawRing(int x, int y, int radius, int smallRadius, string type)
        {
            Console.WriteLine($"{type} ({x},{y}) External radius is {radius}, Internal radius is {smallRadius}");
        }
    }
}
