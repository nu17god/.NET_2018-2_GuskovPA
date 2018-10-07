using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            do
            {
                Console.Write("Введите целое число: ");
                var input = Console.ReadLine();
                Int32.TryParse(input, out N);

                if (N <= 0)
                {
                    Console.WriteLine("Введены некорректные значения!\n");
                }

            }
            while (N <= 0);

            Console.WriteLine();

            for (int i=0; i<N; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
