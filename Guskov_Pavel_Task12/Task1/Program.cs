using System;
using System.IO;
using System.Text;

namespace Task1
{
    class Program
    {
        const string path = @"C:\Projects\.NET_2018-2_GuskovPA\Guskov_Pavel_Task12\disposable_task_file.txt";

        static void Main(string[] args)
        {
            string[] readNumbers = ReadFile(path);
            double[] modifyNumbers = Pow(readNumbers);

            readNumbers = ToStr(modifyNumbers);
            SetFile(path, readNumbers);

            Console.WriteLine("Modification was completed!");
            Console.ReadKey();
        }

        public static string[] ReadFile(string path)
        {
            if (File.Exists(path))
            {
                var arr = File.ReadAllLines(path);
                return arr;
            }
            else
            {
                throw new FileNotFoundException("File not found!");
            }

        }

        public static double[] Pow(string[] arr)
        {
            double[] newArr = new double[arr.Length];
            for (int i = 1; i < arr.Length; i++)
            {
                double num;
                if (double.TryParse(arr[i], out num))
                {
                    newArr[i] = Math.Pow(num,2);
                }
            }

            return newArr;
        }

        public static string[] ToStr(double[] arr)
        {
            string[] newArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i].ToString();
            }
            return newArr;
        }

        public static void SetFile(string path, string[] arr)
        {
            File.WriteAllLines(path, arr);
        }
    }
}
