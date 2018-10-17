using System;

namespace Task3
{

    class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle = new Triangle(3, 4, 5);

            GetPerimeter(triangle);
            GetSquare(triangle);

            Console.ReadKey();
        }

        public static void GetPerimeter(Triangle triangle)
        {
            Console.WriteLine($"Triangle perimeter is {triangle.Perimeter}");
        }

        public static void GetSquare(Triangle triangle)
        {
            Console.WriteLine($"Triangle square is {triangle.Square}");
        }
    }
}
