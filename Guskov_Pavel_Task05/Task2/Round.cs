using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Round
    {
        protected int radius;

        public int X { get; set; }

        public int Y { get; set; }

        public int Radius
        {
            get => radius;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect radius");
                }

                radius = value;
            }
        }

        public double Length
        {
            get => 2 * Math.PI * radius;

        }

        public double Square
        {
            get => Math.PI * Math.Pow(radius, 2);

        }

        public Round(int x, int y, int r)
        {
            this.X = x;
            this.Y = y;
            this.Radius = r;
        }
    }
}
