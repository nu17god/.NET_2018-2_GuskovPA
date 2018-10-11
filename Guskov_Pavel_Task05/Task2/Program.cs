using System;

namespace Task2
{
    class Round
    {
        public bool correct;

        private int r;

        public int X { get; set; }

        public int Y { get; set; }

        public int Radius
        {
            get
            {
                return r;
            }
            set
            {
                if (value > 0)
                {
                    r = value;
                }
                else
                {
                    this.correct = false;

                    Console.WriteLine("Uncorrect radius");
                }

            }
        }

        public Round(int x, int y, int r)
        {
            this.X = x;
            this.Y = y;
            this.Radius = r;
            this.correct = true;
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
                Console.WriteLine("Uncorrect x coordinate");
            }

            if (int.TryParse(y, out intTemp))
            {
                this.Y = intTemp;
            }
            else
            {
                this.correct = false;
                Console.WriteLine("Uncorrect y coordinate");
            }

            if (int.TryParse(r, out intTemp))
            {
                this.Radius = intTemp;
            }
            else
            {
                this.correct = false;
                Console.WriteLine("Uncorrect radius");
            }

        }

        private double GetCircleLength()
        {
            return (2 * Math.PI * r);
        }

        private double GetCircleSquare()
        {
            return (Math.PI * Math.Pow(r, 2));
        }

        public void PrintCircleLength()
        {
            Console.WriteLine($"Circle lenght is {GetCircleLength()}");
        }

        public void PrintCircleSquare()
        {
            Console.WriteLine($"Circle square is {GetCircleSquare()}");
        }

        public void PrintCircleCoords()
        {
            Console.WriteLine($"Circle coordinate is ({this.X},{this.Y})");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string tempX = null;
            string tempY = null;
            string tempZ = null;

            Round circle = new Round(0, 0, 1);

            do
            {
                Console.WriteLine("Enter x coordinate");
                tempX = Console.ReadLine();

                Console.WriteLine("Enter y coordinate");
                tempY = Console.ReadLine();

                Console.WriteLine("Enter radius");
                tempZ = Console.ReadLine();

                Console.Clear();

                circle.SetCircle(tempX, tempY, tempZ);

            } while (!circle.correct);

            circle.PrintCircleCoords();
            circle.PrintCircleLength();
            circle.PrintCircleSquare();

            Console.ReadKey();
        }
    }
}
