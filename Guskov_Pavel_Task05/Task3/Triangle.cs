using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;

        public int A
        {
            get => a;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect first side");
                }

                a = value;
            }
        }

        public int B
        {
            get => b;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect second side");
                }

                b = value;
            }
        }

        public int C
        {
            get => c;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect third side");
                }

                c = value;
            }
        }

        public Triangle(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public int Perimeter
        {
            get => (this.a + this.b + this.c);
        }

        public double Square
        {
            get => (Math.Pow((Perimeter/2 * (Perimeter/2 - this.a) * (Perimeter/2 - this.b) * (Perimeter/2 - this.c)), 0.5));
        }
    }
}
