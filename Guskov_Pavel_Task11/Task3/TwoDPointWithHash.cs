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
            int hashBase = 13;
            hashBase = (hashBase * 7) + x;
            hashBase = (hashBase * 7) + y;

            return hashBase;
        }
    }
}
