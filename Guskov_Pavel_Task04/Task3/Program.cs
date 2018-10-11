using System;
using System.Globalization;
using System.Threading;

namespace Task3
{
    class Program
    {
        public static DateTime date1 = new DateTime(2018, 10, 9, 9, 20, 43);
        const float number = 1000.121f;

        static void Main(string[] args)
        {
            Console.WriteLine("           Name                            Date Format           Number Format\n");

            PrintCulturalInfo(CultureInfo.InvariantCulture);
            PrintCulturalInfo(CultureInfo.CreateSpecificCulture("en-US"));
            PrintCulturalInfo(CultureInfo.CreateSpecificCulture("ru-RU"));


            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }

        private static void PrintCulturalInfo(CultureInfo culture)
        {
            Console.WriteLine($"{culture,-40} {date1.ToString(culture),-25} {number.ToString("n", culture), -20}");
        }
    }
}
