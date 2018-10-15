using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Round
    {
        public bool correct;

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
                    this.correct = false;

                    Console.WriteLine("Incorrect radius");
                }

            }
        }

        public Round(int x, int y, int r)
        {
            this.correct = true;
            this.X = x;
            this.Y = y;
            this.Radius = r;
        }

        public void SetCircle(string x, string y, string r)
        {
            int intTemp;

            this.correct = true;

            if (int.TryParse(x, out intTemp))
            {
                this.X = intTemp;
            }
            else
            {
                this.correct = false;
                Console.WriteLine("Incorrect x coordinate");
            }

            if (int.TryParse(y, out intTemp))
            {
                this.Y = intTemp;
            }
            else
            {
                this.correct = false;
                Console.WriteLine("Incorrect y coordinate");
            }

            if (int.TryParse(r, out intTemp))
            {
                this.Radius = intTemp;
            }
            else
            {
                this.correct = false;
                Console.WriteLine("Incorrect radius");
            }

        }

        protected virtual double GetLength()
        {
            return (2 * Math.PI * radius);
        }

        protected virtual double GetSquare()
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        public virtual void PrintLength()
        {
            Console.WriteLine($"Circle lenght is {GetLength()}");
        }

        public virtual void PrintSquare()
        {
            Console.WriteLine($"Circle square is {GetSquare()}");
        }

        public void PrintCoords()
        {
            Console.WriteLine($"Circle coordinate is ({this.X},{this.Y})");
        }

    }
}
