using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[2];

            myArr[0] = 5;
            myArr[1] = 8;

            DynamicArray<int> dynamicArray = new DynamicArray<int>(myArr);

            int[] myArray = new int[8];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }

            Console.WriteLine(dynamicArray);

            dynamicArray.Insert(2, 3);

            //dynamicArray.Add(2);

            //dynamicArray.Remove(5);

            //dynamicArray.AddRange(myArray);

            Console.WriteLine(dynamicArray);
            Console.WriteLine(dynamicArray[2]);



            Console.ReadKey();
        }
    }
}
