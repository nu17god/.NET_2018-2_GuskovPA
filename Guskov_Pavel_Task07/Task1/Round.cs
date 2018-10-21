using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Round : Circle
    {
        public Round(int x, int y, int radius) : base (x, y, radius)
        {

        }

        public override void Draw()
        {
            Console.WriteLine($"Round ({X},{Y}) radius is {Radius}");
        }
    }
}
