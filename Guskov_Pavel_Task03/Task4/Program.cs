using System;

namespace Тask4
{
    class Program
    {
        const int ArraySize = 5;

        static void Main(string[] args)
        {
            int[,] Array = CreateArray();

            Console.WriteLine("Исходный массив:");
            PrintArray(Array);

            Console.WriteLine($"Cуммa элементов массива, стоящих на чётных позициях равна: {SumArray(Array)}");

            Console.WriteLine("\nДля выхода из программы введите любой символ");
            Console.ReadKey();
        }

        public static int[,] CreateArray()
        {
            int[,] Array = new int[ArraySize, ArraySize];
            Random rnd = new Random();

            for (int i = 0; i < ArraySize; i++)
            {
                for (int j = 0; j < ArraySize; j++)
                {
                    Array[i, j] = rnd.Next(-9, 99);
                }
            }
            return Array;
        }

        public static void PrintArray(int[,] Array)
        {
            for (int i = 0; i < ArraySize; i++)
            {
                for (int j = 0; j < ArraySize; j++)
                {
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static int SumArray(int[,] Array)
        {
            int sum = 0;

            for (int i = 0; i < ArraySize; i++)
            {
                for (int j = 0; j < ArraySize; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum = sum + Array[i, j];
                    }
                }
            }

            return sum;
        }
    }
}
