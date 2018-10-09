using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            UTF8Encoding eEncoding = new UTF8Encoding();
            string Text = new string("");
            Regex regex = new Regex(@"</*\w*>");

            Text = GetText(Text);
            Text = ReplaceText(Text, regex);
            PrintText(Text);

            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }

        private static void PrintText(string Text)
        {
            Console.WriteLine($"Replaced Text\n {Text}");
        }

        private static string ReplaceText(string Text, Regex regex)
        {
            return regex.Replace(Text, "_");
        }

        private static string GetText(string Text)
        {
            Console.WriteLine("Select file location:\n");
            Text = File.ReadAllText("C:/.NET_2018-2_GuskovPA/Guskov_Pavel_Task04/Task5/example.html");
            //Text = File.ReadAllText(Console.ReadLine());

            return Text;
        }
    }
}
