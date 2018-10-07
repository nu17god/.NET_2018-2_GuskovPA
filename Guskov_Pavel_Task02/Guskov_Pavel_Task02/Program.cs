using System;

namespace Guskov_Pavel_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            do
            {
                Console.WriteLine("Введите длину прямоугольника");
                var input = Console.ReadLine();
                Int32.TryParse(input, out x);

                Console.WriteLine("Введите ширину прямоугольника");
                input = Console.ReadLine();
                Int32.TryParse(input, out y);

                if ((x <= 0) || (y <= 0))
                {
                    Console.WriteLine("Введены некорректные значения!\n");
                }
                    
            }
            while ((x <= 0) || (y <= 0));

            Console.WriteLine($"Площадь прямоугольника со сторонами {x} и {y} равна: {x * y}" );
        }
    }
}
