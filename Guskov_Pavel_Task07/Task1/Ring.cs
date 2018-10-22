using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Ring : Circle
    {
        private int smallRadius;

        public int SmallRadius
        {
            get => smallRadius;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("ArgumentException");
                }

                if (Radius < value)
                {
                    throw new ArgumentException("ArgumentException");
                }

                smallRadius = value;
            }
        }


        public Ring(int x, int y, int radius, int smallRadius) : base(x, y, radius)
        {
            SmallRadius = smallRadius;
            Type = "Ring";
        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawRing(X, Y, Radius, SmallRadius, Type);
        }
    }
}
