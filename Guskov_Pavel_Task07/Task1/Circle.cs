using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Circle : Figure
    {
        private int x;
        private int y;
        private int radius;

        public int X
        {
            get => x;

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get => y;

            set
            {
                y = value;
            }
        }

        public int Radius
        {
            get => radius;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("ArgumentException");
                }

                radius = value;
            }
        }

        public Circle(int x, int y, int radius)
        {
            Radius = radius;
            X = x;
            Y = y;
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle ({X},{Y}) radius is {Radius}");
        }
    }
}
