using System;

namespace Task1
{
    class Program
    {

        const int ArrayCount = 10;

        static void Main(string[] args)
        {
            int[] Array = CreateArray();

            Console.WriteLine("Исходный массив:");
            PrintArray(Array);
            SortArray(Array);

            Console.WriteLine("\nОтсортированный массив:");
            PrintArray(Array);

            //FindMin(Array);
            //FindMax(Array);

            Console.WriteLine($"\nМинимальное значение массива : {Array[0]}");
            Console.WriteLine($"Максимальное значение массива : {Array[ArrayCount-1]}");
            Console.WriteLine("\nДля выхода из программы введите любой символ");
            Console.ReadKey();

        }

        public static int[] CreateArray () 
        {
            int[] Array = new int[ArrayCount];
            Random rnd = new Random();

            for (int i = 0; i < ArrayCount; i++)
            {
                Array[i] = rnd.Next(-99, 999);
            }

            return Array;
        }

        public static void SortArray(int[] Array)
        {
            int left = 0,
                right = Array.Length - 1,
                count = 0;

            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (Array[i] > Array[i + 1])
                        Swap(Array, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (Array[i - 1] > Array[i])
                        Swap(Array, i - 1, i);
                }
                left++;
            }
        }

        public static void Swap(int[] Array, int a, int b)
        {
            int temp = Array[a];
            Array[a] = Array[b];
            Array[b] = temp;
        }

        public static void PrintArray(int[] Array)
        {
            for (int i = 0; i<ArrayCount; i++)
            {
                Console.Write(Array[i] + " ");
            }

            Console.WriteLine();
        }

        /*public static void FindMax(int[] Array)
         {
             int max = Array[0];

             for (int i = 0; i < ArrayCount; i++)
             {
                 if (Array[i] > max)
                 {
                     max = Array[i];
                 }

             }

             Console.WriteLine($"Максимальное значение массива -- {max}");

         }*/

        /*public static void FindMin(int[] array)
        {
            int min = array[0];

            for (int i = 0; i < ArrayCount; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

            }

            Console.WriteLine($"Минимальное значение массива -- {min}");

        }*/

    }
}
