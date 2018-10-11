using System;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex regex = new Regex("-?[0-9][,.][0-9][0-9][Ee]-?[0-9]+");
            string Input = new string("");
            bool result = false;
            int again = 0;

            do
            {
                Console.Clear();

                Input = GetInput(Input);
                result = CompareInput(Input, regex);
                PrintResult(result);

                Console.WriteLine("\nPress 1 to try again, or any other key to close the program\n");
                Int32.TryParse(Console.ReadLine(), out again);
            }
            while (again == 1);
        }

        public static string GetInput(string Input)
        {
            Console.WriteLine("Enter a number in scientific form");

            return Input = Console.ReadLine();
        }

        public static bool CompareInput(string Input, Regex regex)
        {
            return regex.IsMatch(Input);
        }

        public static void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("There is number in scientific form");
            }
            else
            {
                Console.WriteLine("There is NOT number in scientific form");
            }
        }

    }
}
