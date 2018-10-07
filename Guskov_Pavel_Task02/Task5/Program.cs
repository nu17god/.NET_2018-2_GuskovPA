using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                sum = sum + Sum(i);
            }

            Console.WriteLine($"Сумма всех чисел меньше 1000, кратных 3, или 5 равна: {sum}");
        }

        public static int Sum(int i)
        {
            if ((i % 3 == 0) || (i % 5 == 0))
            {
                return i;
            }
            else
            {
                return 0;
            }
        }
    }
}
