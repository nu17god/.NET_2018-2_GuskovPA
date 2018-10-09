using System;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string Text = new string("");
            Regex regex = new Regex(@"\W+[0-2]*[0-9]:[0-5][0-9]");

            Text = GetText(Text);
            count = GetCount(Text, regex, count);
            PrintCount(count);

            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();

        }

        public static string GetText(string Text)
        {
            Console.WriteLine("Select file location:\n");
            Text = File.ReadAllText("C:/.NET_2018-2_GuskovPA/Guskov_Pavel_Task04/Task7/example.txt");
            //Text = File.ReadAllText(Console.ReadLine());


            return Text;
        }

        public static int GetCount(string Text, Regex regex, int count)
        {
            foreach (Match match in regex.Matches(Text))
            {
                count++;
            }

            return count;
        }

        public static void PrintCount(int count)
        {
            Console.WriteLine($"In this file time occurs {count} times");  
        }
    }
}
