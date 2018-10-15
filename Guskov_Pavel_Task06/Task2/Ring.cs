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
                        this.correct = false;
                        Console.WriteLine("Incorrect internal radius");
                    }
                }
                else 
                {
                    this.correct = false;
                    Console.WriteLine("Incorrect internal radius");
                }
            }
        }

        public void SetRing(string x, string y, string radius, string smallRadius)
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

            if (int.TryParse(radius, out intTemp))
            {
                this.Radius = intTemp;
            }
            else
            {
                this.correct = false;
                Console.WriteLine("Incorrect external radius");
            }

            if (int.TryParse(smallRadius, out intTemp))
            {
                this.SmallRadius = intTemp;
            }
            else
            {
                this.correct = false;
                Console.WriteLine("Incorrect internal radius");
            }

        }

        public Ring(int x, int y, int Radius, int smallRadius) : base(x, y, Radius)
        {
            this.SmallRadius = smallRadius;

        }

        protected override double GetLength()
        {
            return ((2 * Math.PI * radius) + (2 * Math.PI * smallRadius));
        }

        protected override double GetSquare()
        {
            return ((Math.PI * Math.Pow(radius, 2)) - (Math.PI * Math.Pow(smallRadius, 2)));
        }

        public override void PrintLength()
        {
            Console.WriteLine($"Ring lenght is {GetLength()}");
        }

        public override void PrintSquare()
        {
            Console.WriteLine($"Ring square is {GetSquare()}");
        }

    }
}
