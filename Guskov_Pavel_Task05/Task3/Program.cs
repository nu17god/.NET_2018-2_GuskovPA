using System;

namespace Task3
{
    class Triangle
    {
        public bool Correct;

        private int a;
        private int b;
        private int c;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    this.Correct = false;

                    Console.WriteLine("Uncorrect first side");
                }
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    this.Correct = false;

                    Console.WriteLine("Uncorrect second side");
                }
            }
        }

        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    this.Correct = false;

                    Console.WriteLine("Uncorrect third side");
                }
            }
        }

        public Triangle( string a, string b, string c)
        {
            int intTemp;

            this.Correct = true;

            if (int.TryParse(a, out intTemp))
            {
                this.A = intTemp;
            }
            else
            {
                this.Correct = false;
                Console.WriteLine("Uncorrect first side");
            }

            if (int.TryParse(b, out intTemp))
            {
                this.B = intTemp;
            }
            else
            {
                this.Correct = false;
                Console.WriteLine("Uncorrect second side");
            }

            if (int.TryParse(c, out intTemp))
            {
                this.C = intTemp;
            }
            else
            {
                this.Correct = false;
                Console.WriteLine("Uncorrect third side");
            }

            if ((this.a + this.b) < this.c)
            {
                this.Correct = false;
                Console.WriteLine("Uncorrect input");
            }


            if ((this.a + this.c) < this.b)
            {
                this.Correct = false;
                Console.WriteLine("Uncorrect input");
            }

            if ((this.b + this.c) < this.a)
            {
                this.Correct = false;
                Console.WriteLine("Uncorrect input");
            }
        }

        public int GetPerimeter()
        {
            return (this.A + this.B + this.C);
        }

        public double GetSquare()
        {
            return (Math.Pow((GetPerimeter()*(GetPerimeter()- this.A) * (GetPerimeter() - this.B) * (GetPerimeter() - this.C)), 0.5));
        }

        public void PrintPerimeter()
        {
            Console.WriteLine($"Triangle perimeter is {GetPerimeter()}");
        }

        public void PrintSquare()
        {
            Console.WriteLine($"Triangle square is {GetSquare()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string a = null;
            string b = null;
            string c = null;

            Console.WriteLine("Enter first side");
            a = Console.ReadLine();

            Console.WriteLine("Enter second side");
            b = Console.ReadLine();

            Console.WriteLine("Enter third side");
            c = Console.ReadLine();

            Triangle triangle = new Triangle(a, b, c);

            if (triangle.Correct)
            {
                triangle.PrintPerimeter();
                triangle.PrintSquare();
            }

            Console.ReadKey();
        }
    }
}
