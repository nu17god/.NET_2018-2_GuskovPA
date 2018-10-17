using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Round round = new Round(5, 5, 10);

            PrintCoords(round);
            PrintLength(round);
            PrintSquare(round);

            Console.WriteLine();

            Ring ring = new Ring(5, 5, 10, 5);

            PrintCoords(ring);
            PrintLength(ring);
            PrintSquare(ring);

            Console.ReadKey();
        }



        public static void PrintLength(Round round)
        {
            Console.WriteLine($"Circle lenght is {round.Length}");
        }

        public static void PrintSquare(Round round)
        {
            Console.WriteLine($"Circle square is {round.Square}");
        }

        public static void PrintCoords(Round round)
        {
            Console.WriteLine($"Coordinate is ({round.X},{round.Y})");
        }

        public static void PrintLength(Ring ring)
        {
            Console.WriteLine($"Ring lenght is {ring.Length}");
        }

        public static void PrintSquare(Ring ring)
        {
            Console.WriteLine($"Ring square is {ring.Square}");
        }
    }
}