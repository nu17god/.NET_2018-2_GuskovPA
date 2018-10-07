using System;

namespace Task4
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

            for (int i = 0; i < N; i++)
            {
                for (int k = 0; k <= i; k++)
                {

                    space(N-k);
                    star(2*k+1);
                    Console.WriteLine();

                }

            }
        }

        static void space(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write(" ");
            }
        }

        static void star(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }
        }

    }

}
