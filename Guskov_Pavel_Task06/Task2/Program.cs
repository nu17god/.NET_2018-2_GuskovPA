using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempX = null;
            string tempY = null;
            string tempRadius = null;
            string tempSmallRadius = null;

            Ring ring = new Ring(0, 0, 2, 1);

            do
            {
                Console.WriteLine("Enter x coordinate");
                tempX = Console.ReadLine();

                Console.WriteLine("Enter y coordinate");
                tempY = Console.ReadLine();

                Console.WriteLine("Enter external radius");
                tempRadius = Console.ReadLine();

                Console.WriteLine("Enter internal radius");
                tempSmallRadius = Console.ReadLine();

                ring.SetRing(tempX, tempY, tempRadius, tempSmallRadius);

            } while (!ring.correct);

            ring.PrintCoords();
            ring.PrintLength();
            ring.PrintSquare();

            Console.ReadKey();
        }
    }
}