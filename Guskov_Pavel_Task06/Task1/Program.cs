using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Jordan = new Human("Michael", "Jordan", "Jeffrey", "17", "2", "1963");
            Jordan.GetInfo();

            Employee Bryant = new Employee("Kobe", "Bryant", "Bean", "23", "8", "1978", "Pro basketball player", "20");
            Bryant.GetInfo();

            Console.ReadKey();
        }
    }
}
