using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstString = null;
            string[] StringArray = null;
            float AverageValue = 0f;

            FirstString = GetString();
            FirstString = DeleteSpaces(FirstString);

            if (FirstString == null)
            {
                throw new Exception("String is null");
            }
            else
            {
                StringArray = Split(FirstString, StringArray);
                AverageValue = GetAverageValue(StringArray, AverageValue);
                PrintResult(AverageValue);
            }

            Console.WriteLine("\nPress any key to close the program");
            Console.ReadKey();
        }

        private static string DeleteSpaces(string str)
        {
            do
            {
                str = str.Replace("  ", " ");
            }
            while (str.Contains("  "));

            if (str[0] == ' ')
            {
                str = str.Remove(0, 1);
            }

            if (str[str.Length - 1] == ' ')
            {
                str = str.Remove(str.Length - 1, 1);
            }

            return str;
        }

        private static string GetString()
        {
            Console.WriteLine("Enter String:");
            return Console.ReadLine();
        }

        public static void PrintResult(float averageValue)
        {
            Console.WriteLine($"Average number of letters in a word is {averageValue}");
        }

        public static float GetAverageValue(string[] StringArray, float AverageValue)
        {
            for (int i = 0; i < StringArray.Length; i++)
            {
                AverageValue = AverageValue + StringArray[i].Length;
                Console.WriteLine(i + ") " +StringArray[i]);
            }

            if (StringArray.Length == 0)
            {
                throw new DivideByZeroException("DivideByZeroException");
            }
            else
            {
            return (AverageValue / StringArray.Length) ;
            }
        }

        public static string[] Split(string str, string[] StringArray)
        {

            StringArray = str.Split(' ');

            return StringArray; 
        }


    }
}
