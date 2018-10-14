using System;

namespace Task4
{


    class MyString
    {
        const int MyStringSize = 25;
        private char[] myString = new char[MyStringSize];

        public MyString(string str)
        {
            if (str.Length < myString.Length)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    myString[i] = str[i];
                }
            }
            else
            {
                for (int i = 0; i < myString.Length; i++)
                {
                    myString[i] = str[i];
                }
            }
        }

        public MyString()
        {
            for (int i = 0; i < myString.Length; i++)
            {
                myString[i] = ' ';
            }
        }


        public void GetMyString()
        {
            for (int i = 0; i < myString.Length; i++)
            {
                Console.Write(myString[i]);
            }
            Console.WriteLine();
        }

        public static MyString operator +(string str1, string str2)
        {
            string resultString = str1;

            for(int i = MyStringSize; i < MyStringSize*2; i++)
            {
                resultString = str1 + str2;
            }

            return 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyString myString = new MyString("Hey guys it's me");

            myString.GetMyString();

            Console.ReadKey();
        }
    }
}
