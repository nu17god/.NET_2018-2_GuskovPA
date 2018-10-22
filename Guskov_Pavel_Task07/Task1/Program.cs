using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures =
                {
                new Line(5, 5, 10, 10),
                new Rectangle(5, 5, 10, 10),
                new Circle(5, 5, 5),
                new Round(5, 5, 10),
                new Ring(5, 5, 10, 5),
            };

            var consoleDriver = new ConsoleDriver();

            for (int i = 0; i < figures.Length; i++)
            {
                figures[i].Draw(consoleDriver);
            }

            Console.ReadKey();
        }
    }
}
