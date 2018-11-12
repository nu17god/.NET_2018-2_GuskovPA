using System;

namespace Task1
{
    class Program
    {
        delegate string[] sort(string[] arr, int i, int j);

        static void Main(string[] args)
        {
            string[] Arr = { "aras", "ass" ,"aac","aab", "ass"  };
            sort _sort;

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = i+1; j < Arr.Length; j++)
                {
                    if (Arr[i].Length == Arr[j].Length)
                    {
                        _sort = SecondSort;
                        _sort(Arr, i, j);

                    }

                    if (Arr[i].Length > Arr[j].Length)
                    {
                        _sort = FirstSort;
                        _sort(Arr, i, j);
                    }
                }
            }


            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }

            Console.ReadKey();
        }

        public static string[] SecondSort(string[] arr, int i, int j)
        {
            if (arr[i].CompareTo(arr[j]) == 1)
            {
                Swap(arr, i, j);
            }

            return arr;
        }

        public static string[] FirstSort(string[] arr, int i, int j)
        {
            if (arr[i].Length > arr[j].Length)
            {
                Swap(arr, i, j);
            }

            return arr;
        }

        public static string[] Swap(string[] arr, int i, int j)
        {
            string temp;

            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            return arr;
        }
    }
}
