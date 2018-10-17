using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Round round = new Round(5, 5, 10);

            GetCoords(round);
            GetLength(round);
            GetSquare(round);

            Console.ReadKey();
        }

        public static void GetLength(Round round)
        {
            Console.WriteLine($"Circle lenght is {round.Length}");
        }

        public static void GetSquare(Round round)
        {
            Console.WriteLine($"Circle square is {round.Square}");
        }

        public static void GetCoords(Round round)
        {
            Console.WriteLine($"Coordinate is ({round.X},{round.Y})");
        }
    }
}
