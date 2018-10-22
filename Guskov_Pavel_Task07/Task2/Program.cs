using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricProgression geometricProgression = new GeometricProgression(2, 2);

            PrintSeries(geometricProgression, 10);

            Console.ReadKey();
        }

        public static void PrintSeries(GeometricProgression geometricProgression, int index)
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"{geometricProgression.GetCurrent()}");

                geometricProgression.MoveNext();
            }
        }
    }
}
