using System;
using System.Globalization;
using System.Threading;

namespace Task3
{
    class Program
    {
        public static DateTime date1 = new DateTime(2018, 10, 9);
        const float number = 1000.121f;

        static void Main(string[] args)
        {
            Console.WriteLine("           Name                            Date Format           Number Format\n");

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            PrintCulturalInfo();

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            PrintCulturalInfo();

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");
            PrintCulturalInfo();


            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }

        private static void PrintCulturalInfo()
        {
            Console.WriteLine($"{CultureInfo.CurrentCulture.NativeName,-40} {date1,-25} {number.ToString("n"), -20}");
        }
    }
}
