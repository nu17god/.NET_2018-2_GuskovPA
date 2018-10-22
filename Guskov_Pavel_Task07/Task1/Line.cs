using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Line : Figure
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public string Type;

        public int X1
        {
            get => x1;

            set
            {
                x1 = value;
            }
        }

        public int Y1
        {
            get => y1;

            set
            {
                y1 = value;
            }
        }

        public int X2
        {
            get => x2;

            set
            {
                x2 = value;
            }
        }

        public int Y2
        {
            get => y2;

            set
            {
                y2 = value;
            }
        }

        public Line(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Type = "Line";
        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawLine(X1,Y1,X1,Y2, Type);
        }
    }



}
