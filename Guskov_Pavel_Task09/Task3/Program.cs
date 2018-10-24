using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter location of file:");

            string text = File.ReadAllText(Console.ReadLine());

            KeyWordsSearcher ks = new KeyWordsSearcher(text);

            ks.SetKeyWords();
            ks.CountKeyWords();

            Console.WriteLine(ks);
            Console.ReadKey();
        }
    }
}
