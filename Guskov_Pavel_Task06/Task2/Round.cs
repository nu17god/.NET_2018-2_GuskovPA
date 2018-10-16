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
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect radius");
                }

            }
        }

        public double Length
        {
            get => Length;

            set
            {
                Length = 2 * Math.PI * radius;
            }
        }

        public double Square
        {
            get => Square;

            set
            {
                Square = Math.PI * Math.Pow(radius, 2);
            }
        }

        public Round(int x, int y, int r)
        {
            this.X = x;
            this.Y = y;
            this.Radius = r;
        }
    }
}
