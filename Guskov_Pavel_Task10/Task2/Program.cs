using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office();
            Employee p1 = new Employee("Ivan", office);
            Employee p2 = new Employee("Vova", office);
            Employee p3 = new Employee("Lena", office);

            p1.GoToOffice(9);
            p2.GoToOffice(15);
            p3.GoToOffice(23);

            p1.GoHome();
            p2.GoHome();
            p3.GoHome();

            Console.ReadKey();
        }
    }
}
