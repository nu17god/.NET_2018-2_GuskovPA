using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Jordan = new Human("Michael", "Jordan", "Jeffrey", new DateTime(1963, 2, 17));
            Console.WriteLine(Jordan);

            Employee Bryant = new Employee("Kobe", "Bryant", "Bean", new DateTime(1978, 8, 23), "Pro basketball player", 20);
            Console.WriteLine(Bryant);

            Employee BryantEqual = new Employee("Kobe", "Bryant", "Bean", new DateTime(1978, 8, 23), "Pro basketball player", 20);
            Employee BryantName = new Employee("Kobea", "Bryant", "Bean", new DateTime(1978, 8, 23), "Pro basketball player", 20);
            Employee BryantSecondName = new Employee("Kobe", "Bryanta", "Bean", new DateTime(1978, 8, 23), "Pro basketball player", 20);
            Employee BryantSurName = new Employee("Kobe", "Bryant", "Beana", new DateTime(1978, 8, 23), "Pro basketball player", 20);
            Employee BryantAge = new Employee("Kobe", "Bryant", "Beana", new DateTime(1977, 8, 23), "Pro basketball player", 20);
            Employee BryantPosition = new Employee("Kobe", "Bryant", "Beana", new DateTime(1978, 8, 23), "Pro", 20);
            Employee BryantExperience = new Employee("Kobe", "Bryant", "Beana", new DateTime(1978, 8, 23), "Pro basketball player", 25);

            Console.WriteLine(Bryant.Equals(BryantEqual));
            Console.WriteLine(Bryant.Equals(BryantName));
            Console.WriteLine(Bryant.Equals(BryantSecondName));
            Console.WriteLine(Bryant.Equals(BryantSurName));
            Console.WriteLine(Bryant.Equals(BryantAge));
            Console.WriteLine(Bryant.Equals(BryantPosition));
            Console.WriteLine(Bryant.Equals(BryantExperience));



            Console.ReadKey();
        }
    }
}
