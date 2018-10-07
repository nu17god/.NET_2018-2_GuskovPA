using System;

namespace Task3
{
    class Program
    {

        const int ArrayCount = 10;

        static void Main(string[] args)
        {
            int[] Array = CreateArray();
            int sum = 0;

            Console.WriteLine("Исходный массив:");
            PrintArray(Array);

            sum = FindSum(Array, sum);

            Console.WriteLine($"\nСумма неотрицательных элементов в исходном массиве равна: {sum}");
            Console.WriteLine("\nДля выхода из программы введите любой символ");
            Console.ReadKey();
        }

        public static int[] CreateArray()
        {
            int[] Array = new int[ArrayCount];
            Random rnd = new Random();

            for (int i = 0; i < ArrayCount; i++)
            {
                Array[i] = rnd.Next(-99, 999);
            }

            return Array;
        }

        public static void PrintArray(int[] Array)
        {
            for (int i = 0; i < ArrayCount; i++)
            {
                Console.Write(Array[i] + " ");
            }

            Console.WriteLine();
        }

        public static int FindSum(int[] Array, int sum)
        {
            for (int i = 0; i < ArrayCount; i++)
            {
                if (Array[i] >= 0)
                {
                    sum = sum + Array[i];
                }
            }

            return sum;
        }
    }
}
