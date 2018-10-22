using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class DynamicArray<T> : IIndexable<T>
    {
        public T[] MyDynamicArray = new T[8];

        public int count;
        public int capacity;

        public int Lenght
        {
            get => count;
        }

        public int Capacity
        {
            get => capacity;
        }

        public T this[int index] => MyDynamicArray[index];

        public DynamicArray()
        {
            MyDynamicArray = new T[8];
            count = 0;
            capacity = 8;
        }

        public DynamicArray(int Capacity)
        {
            MyDynamicArray = new T[Capacity];
            this.count = 0;
            this.capacity = Capacity;
        }

        public DynamicArray(T[] array)
        {
            MyDynamicArray = array;
            capacity = array.Length;
            count = array.Length;
        }

        public void Add(T add)
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] tempArray = new T[capacity];

                for (int i = 0; i < MyDynamicArray.Length; i++)
                {
                    tempArray[i] = MyDynamicArray[i];
                }

                tempArray[count] = add;
                count++;

                MyDynamicArray = tempArray;
            }
            else if (count < capacity)
            {
                MyDynamicArray[count] = add;
                count++;
            }
            else if (count > capacity)
            {
                throw new IndexOutOfRangeException("IndexOutOfRangeException");
            }
        }

        public void AddRange(T[] addRange)
        {

            capacity = this.count + addRange.Length;
            T[] tempArray = new T[capacity];

            for (int i = 0; i < count ; i++)
            {
                tempArray[i] = MyDynamicArray[i];
            }

            for (int i = count; i < capacity; i++)
            {
                tempArray[i] = addRange[i - count];
            }

            count += addRange.Length;
            MyDynamicArray = tempArray;
        }

        public bool Remove(T remove)
        {
            for (int i = 0; i < count; i++)
            {
                if (MyDynamicArray[i].Equals(remove))
                {
                    count--;

                    for (int k = i; k < count; k++)
                    {
                        MyDynamicArray[k] = MyDynamicArray[k + 1];
                    }

                    MyDynamicArray[count] = default(T);

                    return true;
                }
            }

            return false;
        }

        public void Insert(int index, T insert)
        {
            if (index <= count)
            {
                if (count == capacity)
                {
                    count++;
                    capacity++;
                    T[] tempArray = new T[capacity];

                    for (int i = 0; i < count; i++)
                    {
                        if (i == index)
                        {
                            tempArray[i] = insert;
                        }
                        else if (i < index)
                        {
                            tempArray[i] = MyDynamicArray[i];
                        }
                        else if (i > index)
                        {
                            tempArray[i] = MyDynamicArray[i - 1];
                        }
                    }

                    MyDynamicArray = tempArray;
                }
                else
                {
                    count++;

                    for (int i = 0; i < count; i++)
                    {
                        if (i == index)
                        {
                            MyDynamicArray[i] = insert;
                        }
                        else if (i < index)
                        {
                            MyDynamicArray[i] = MyDynamicArray[i];
                        }
                        else if (i > index)
                        {
                            MyDynamicArray[i] = MyDynamicArray[i + 1];
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Argument Out Of Range Exception");
            }
        }

        

        public override string ToString()
        {
            string str = null;

            for (int i = 0; i < count; i++)
            {
                str = str + Convert.ToString(MyDynamicArray[i]);
            }

            return str;
        }
    }
}
