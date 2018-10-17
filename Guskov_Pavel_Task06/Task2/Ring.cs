using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Ring : Round
    {
        private int smallRadius;

        protected int SmallRadius
        {
            get => smallRadius;

            set
            {
                if (value > 0)
                {
                    if (value < radius)
                    {
                        smallRadius = value;
                    }
                    else
                    {
                        throw new ArgumentException("Incorrect internal radius");
                    }
                }
                else 
                {
                    throw new ArgumentException("Incorrect internal radius");
                }
            }
        }

        public new double Length
        {
            get => (2 * Math.PI * radius) + (2 * Math.PI * smallRadius);
        }

        public new double Square
        {
            get => (Math.PI * Math.Pow(radius, 2)) - (Math.PI * Math.Pow(smallRadius, 2));
        }

        public Ring(int x, int y, int Radius, int smallRadius) : base(x, y, Radius)
        {
            SmallRadius = smallRadius;

        }
    }
}
