using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDPointWithHash twoDPointWithHash1 = new TwoDPointWithHash(5, 5);
            TwoDPointWithHash twoDPointWithHash2 = new TwoDPointWithHash(5, 5);

            TwoDPointWithHash twoDPointWithHash3 = new TwoDPointWithHash(5, 10);
            TwoDPointWithHash twoDPointWithHash4 = new TwoDPointWithHash(10, 5);

            Console.WriteLine(twoDPointWithHash1.GetHashCode());
            Console.WriteLine(twoDPointWithHash2.GetHashCode());
            Console.WriteLine(twoDPointWithHash3.GetHashCode());
            Console.WriteLine(twoDPointWithHash4.GetHashCode());

            Console.ReadKey();

        }
    }
}
