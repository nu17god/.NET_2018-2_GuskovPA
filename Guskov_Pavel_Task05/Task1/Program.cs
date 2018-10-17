using System;
using System.Globalization;

namespace Task1
{

    class Program
    {
        static void Main(string[] args)
        {
            Human Jordan = new Human("Michael", "Jordan", "Jeffrey", new DateTime(1963, 2, 17));
            Console.WriteLine(Jordan);

            Console.ReadKey();
        }
    }
}
