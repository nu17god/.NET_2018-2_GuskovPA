using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = new DateTime(1963, 2, 17);
            Human Jordan = new Human("Michael", "Jordan", "Jeffrey", birthday);
            Console.WriteLine(Jordan);

            Employee Bryant = new Employee("Kobe", "Bryant", "Bean", new DateTime(1963, 2, 17), "Pro basketball player", 20);
            Console.WriteLine(Bryant);
            Console.ReadKey();
        }
    }
}
