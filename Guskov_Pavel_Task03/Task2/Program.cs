using System;

namespace Task2
{
    class Program
    {
        const int ArrayCount = 3;

        static void Main(string[] args)
        {

            int[,,] Array = CreateArray();

            Console.WriteLine("Исходный массив:");
            PrintArray(Array);
            SwapArray(Array);
            Console.WriteLine("Массив после замены:");
            PrintArray(Array);
            Console.WriteLine("Для выхода из программы введите любой символ");
            Console.ReadKey();

        }

        public static int[,,] CreateArray()
        {
            int[,,] Array = new int[ArrayCount,ArrayCount,ArrayCount];
            Random rnd = new Random();

            for (int i = 0; i < ArrayCount; i++)
            {
                for (int j = 0; j < ArrayCount; j++)
                {
                    for (int k = 0; k < ArrayCount; k++)
                    {
                        Array[i,j,k] = rnd.Next(-99, 999);
                    }
                }    
            }

            return Array;
        }

        public static void PrintArray(int[,,] Array)
        {
            for (int i = 0; i < ArrayCount; i++)
            {
                for (int j = 0; j < ArrayCount; j++)
                {
                    for (int k = 0; k < ArrayCount; k++)
                    {
                        Console.Write(Array[i, j, k] + "\t");
                        
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void SwapArray(int[,,] Array)
        {
            for (int i = 0; i < ArrayCount; i++)
            {
                for (int j = 0; j < ArrayCount; j++)
                {
                    for (int k = 0; k < ArrayCount; k++)
                    {
                        if (Array[i, j, k] > 0)
                        {
                            Array[i, j, k] = 0;
                        }

                    }
                }
            }
        }

    }
}
