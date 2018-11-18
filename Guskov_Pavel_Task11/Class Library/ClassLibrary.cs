using System;

namespace Class_Library
{
    public class ClassLibrary
    {
        static public long Factorial(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        static public double Pow(int ground, int value)
        {
            if (value == 0)
            {
                return 1;
            }

            double result = ground;

            for (int i = 1; i < value; i++)
            {
                result *= ground;
            }

            return result;
        }
    }
}
