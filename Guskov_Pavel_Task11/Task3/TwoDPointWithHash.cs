using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        {

        }

        public override int GetHashCode()
        {
            return Math.Abs(x) + Math.Abs(y) + ((y * x * x + 579) + (y * y * x + 975)) + (x * 753) + (y * 135);
        }
    }
}

