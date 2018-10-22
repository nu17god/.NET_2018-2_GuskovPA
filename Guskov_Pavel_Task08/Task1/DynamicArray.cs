using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class DynamicArray<T>
    {
        T[] MyDynamicArray = new T[8];

        public int count;
        public int size;

        public DynamicArray()
        {
            MyDynamicArray = new T[8];
            count = 0;
            size = 7;
        }

        public DynamicArray(int count)
        {
            MyDynamicArray = new T[count];
            this.count = 0;
            size = count-1;
        }

        public DynamicArray(T[] array )
        {
            MyDynamicArray = array;
            size = array.Length-1;
            count = array.Length-1;
        }

        public T[] Add(T add)
        {
            if (count == size)
            {
                size = MyDynamicArray.Length * 2;

                T[] tempArray = new T[size];
                 for(int i = 0; i< MyDynamicArray.Length; i++)
                {
                    tempArray[i] = MyDynamicArray[i];
                }

                count++;
                tempArray[count] = add;
                MyDynamicArray = tempArray;
            }
            else if (count < size)
            {

            }
            return MyDynamicArray;
        }

        
    }
}
