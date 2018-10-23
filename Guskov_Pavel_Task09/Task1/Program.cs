using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            LinkedList<int> linkedList = new LinkedList<int>();

            int count = SetCount();

            list = SetList(list, count) as List<int>;
            linkedList = SetList(linkedList, count) as LinkedList<int>;

            list = RemoveEachSecondItem(list) as List<int>;
            linkedList = RemoveEachSecondItem(linkedList) as LinkedList<int>;

            

            GetList(list);
            GetList(linkedList);

            Console.ReadKey();
        }

        private static void GetList(ICollection<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static int SetCount()
        {
            int temp;

            Console.WriteLine("Input count");

            if (!Int32.TryParse(Console.ReadLine(), out temp))
            {
                throw new ArgumentException();
            }

            return temp;
        }

        public static ICollection<int> SetList(ICollection<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(i);
            }

            return list;
        }

        public static ICollection<int> RemoveEachSecondItem(ICollection<int> list)
        {
            var first = 0;
            var last = list.Count - 1;
            var second = 2;
            var current = -1;
            var step = 2;

            while (list.Count != 1)
            {
                current += step;
                list.Remove(current);

                if (current == last)
                {
                    last = current - step / 2;
                    step *= 2;
                    current = second - step;
                    first = current + (step / 2);
                    second = first + step;
                }
                if (current > last)
                {
                    last = current - step / 2;
                    step *= 2;
                    current = first - step;
                    first = current + step + (step / 2);
                    second = first + step;
                }

            }

            return list;
        }

    }
}
