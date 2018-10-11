using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstString = null;
            string SecondString = null;

            FirstString = GetString(FirstString, "First");
            SecondString = GetString(SecondString, "Second");

            FirstString = DoubleSigns(FirstString, SecondString);

            PrintResult(FirstString);

            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }

        private static string GetString(string str, string i)
        {
            Console.WriteLine($"Enter {i} string:");
            str = Console.ReadLine();

            return str.ToLower();
        }


        private static string DoubleSigns(string firstString, string secondString)
        {
            string resultString = new string("");

            foreach (char ch in firstString)
            {
                if (!secondString.Contains(ch))
                    resultString += ch;
                else
                {
                    resultString += ch;
                    resultString += ch;
                }
            }
            // удалить все повторяющиеся в second
            // в цикле по second делать first = first.Replace(c, c + c);

            return resultString;
        }

        private static void PrintResult(string str)
        {
            Console.WriteLine($"The result is: \n{str}");
        }
    }
}
