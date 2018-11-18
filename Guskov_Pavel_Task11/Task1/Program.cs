using System;
using Class_Library;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial:");
            Console.WriteLine($"0! = {ClassLibrary.Factorial(0)}");
            Console.WriteLine($"1! = {ClassLibrary.Factorial(1)}");
            Console.WriteLine($"3! = {ClassLibrary.Factorial(3)}");
            Console.WriteLine($"5! = {ClassLibrary.Factorial(5)}");


            Console.WriteLine("\nPow:");
            Console.WriteLine($"2^0 = {ClassLibrary.Pow(2, 0)}");
            Console.WriteLine($"2^2 = {ClassLibrary.Pow(2, 2)}");
            Console.WriteLine($"2^5 = {ClassLibrary.Pow(2, 5)}");
            Console.WriteLine($"3^2 = {ClassLibrary.Pow(3, 2)}");
            Console.WriteLine($"5^5 = {ClassLibrary.Pow(5, 5)}");


            Console.ReadKey();
        }
    }
}
