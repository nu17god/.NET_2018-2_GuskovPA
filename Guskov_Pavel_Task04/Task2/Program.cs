using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstString = new string("");
            string SecondString = new string("");

            FirstString = GetString(FirstString, "First");
            SecondString = GetString(SecondString, "Second");

            FirstString = DoubleSigns(FirstString, SecondString);

            PrintResult(FirstString);

            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }

        private static string GetString(string str, string i)
        {
            Console.WriteLine($"Enter {i} String:");
            str.Remove(0,str.Length);
            str = Console.ReadLine();

            return str.ToLower();
        }


        private static string DoubleSigns(string firstString, string secondString)
        {
            string resultString = new string("");

            foreach (char ch in firstString)
                if (!secondString.Contains(ch))
                    resultString  += ch;
                else
                {
                    resultString += ch;
                    resultString += ch;
                }

            return resultString;
        }

        private static void PrintResult(string str)
        {
            Console.WriteLine($"The result is: \n{str}");
        }
    }
}
