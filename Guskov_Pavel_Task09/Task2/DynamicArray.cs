using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class DynamicArray<T> : IIndexable<T>, IEnumerable<T>, IEnumerable
    {
        private T[] myDynamicArray = new T[8];

        public int count;

        public int Lenght
        {
            get => count;
        }

        public int Capacity
        {
            get => myDynamicArray.Length;
        }

        public T this[int index]
        {
            get
            {
                return myDynamicArray[index];
            }
            set
            {
                if (index < 0)
                {
                    throw new ArgumentException("ArgumentException");
                }

                if (index > count)
                {
                    throw new IndexOutOfRangeException("IndexOutOfRangeException");
                }

                myDynamicArray[index] = value;
            }
        }

        public DynamicArray()
        {
            myDynamicArray = new T[8];
            count = 0;
        }

        public DynamicArray(int Capacity)
        {
            if (Capacity <= 0)
            {
                throw new ArgumentException();
            }

            myDynamicArray = new T[Capacity];
            this.count = 0;
        }

        public DynamicArray(T[] array)
        {
            myDynamicArray = array;
            count = array.Length;
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            //ICollection<T> collection = iEnumerable as ICollection<T>;

            if (collection == null)
            {
                throw new Exception();
            }

            int i = 0;

            myDynamicArray = new T[Capacity];


            foreach (var a in collection)
            {
                myDynamicArray[i] = a;
                i++;
            }

            count = myDynamicArray.Length;
        }

        public void Add(T add)
        {
            if (CheckCount())
            {
                T[] tempArray = new T[Capacity * 2];

                for (int i = 0; i < myDynamicArray.Length; i++)
                {
                    tempArray[i] = myDynamicArray[i];
                }

                tempArray[count] = add;
                count++;

                myDynamicArray = tempArray;
            }
            else if (count < Capacity)
            {
                myDynamicArray[count] = add;
                count++;
            }
            else if (count > Capacity)
            {
                throw new IndexOutOfRangeException("IndexOutOfRangeException");
            }
        }

        public void AddRange(T[] addRange)
        {
            T[] tempArray = new T[this.count + addRange.Length];

            for (int i = 0; i < count; i++)
            {
                tempArray[i] = myDynamicArray[i];
            }

            for (int i = count; i < Capacity; i++)
            {
                tempArray[i] = addRange[i - count];
            }

            count += addRange.Length;
            myDynamicArray = tempArray;
        }

        public bool Remove(T remove)
        {
            bool result = false;

            for (int i = 0; i < count; i++)
            {
                if (myDynamicArray[i].Equals(remove))
                {
                    count--;

                    for (int k = i; k < count; k++)
                    {
                        myDynamicArray[k] = myDynamicArray[k + 1];
                    }

                    myDynamicArray[count] = default(T);

                    result = true;

                }
            }

            return result;
        }

        public void Insert(int index, T insert)
        {
            if (index <= count)
            {
                if (CheckCount())
                {
                    T[] tempArray = new T[Capacity * 2];

                    myDynamicArray = InsertT(tempArray, insert, index);

                }
                else
                {
                    myDynamicArray = InsertT(myDynamicArray, insert, index);
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
                str = str + Convert.ToString(myDynamicArray[i]);
            }

            return str;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return myDynamicArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return myDynamicArray.GetEnumerator();
        }

        public bool CheckCount()
        {
            return count == Capacity;
        }

        public T[] InsertT(T[] array, T insert, int index)
        {
            count++;

            for (int i = 0; i < count; i++)
            {
                if (i == index)
                {
                    array[i] = insert;
                }
                else if (i < index)
                {
                    array[i] = myDynamicArray[i];
                }
                else if (i > index)
                {
                    array[i] = myDynamicArray[i - 1];
                }
            }

            return array;
        }

    }

}