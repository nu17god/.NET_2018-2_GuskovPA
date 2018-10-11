using System;
using System.Diagnostics;
using System.Text;

namespace Task4
{
    class Program
    {
        const int N = 100;

        static void Main(string[] args)
        {
            string str = null;
            StringBuilder sb = new StringBuilder();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch = MeasureString(str, stopwatch);

            Console.WriteLine($"Run time of string is { stopwatch.ElapsedTicks} ticks");

            stopwatch.Reset();

            stopwatch = MeasureStringBuilder(sb, stopwatch);
            
            Console.WriteLine($"Run time of stringbuilder is { stopwatch.ElapsedTicks} ticks");

            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();

        }

        private static Stopwatch MeasureStringBuilder(StringBuilder sb, Stopwatch stopwatch)
        {
            stopwatch.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopwatch.Stop();

            return stopwatch;
        }

        private static Stopwatch MeasureString(string str, Stopwatch stopwatch)
        {
            stopwatch.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopwatch.Stop();

            return stopwatch;
        }
    }
}
