using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Jordan = new Human("Michael", "Jordan", "Jeffrey", new DateTime(1963, 2, 17));
            Console.WriteLine(Jordan);

            Employee Bryant = new Employee("Kobe", "Bryant", "Bean", new DateTime(1978, 8, 23), "Pro basketball player", 20);
            Console.WriteLine(Bryant);

            Console.ReadKey();
        }
    }
}
