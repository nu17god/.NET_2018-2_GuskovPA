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
            string Text = new string("29:00 23:11 00:17 0:61 7:61 7:05 00:31 0:01");
            string pattern = @"\b([01][0-9]|2[0-3]):[0-5][0-9]\b";

            Regex regex = new Regex(pattern);

            //Text = GetText(Text);
            count = GetCount(Text, regex, count);


            PrintCount(count);

            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();

        }

        //public static string GetText(string Text)
        /*{
            Console.WriteLine("Select file location:\n");
            Text = File.ReadAllText("C:/Projects/.NET_2018-2_GuskovPA/Guskov_Pavel_Task04/Task7/example.txt");
            //Text = File.ReadAllText(Console.ReadLine());

            return Text;
        }*/

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
