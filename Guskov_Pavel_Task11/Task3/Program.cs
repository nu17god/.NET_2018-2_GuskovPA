using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDPointWithHash twoDPointWithHash = new TwoDPointWithHash(5, 5);
            List<int> hashlist = new List<int>();
            bool identity;
            int hashcode;
            int count = 0;

            for (int i = -50; i < 50; i++)
            {
                for (int j = -50; j < 50; j++)
                {
                    count++;
                    identity = true;
                    twoDPointWithHash = new TwoDPointWithHash(i, j);
                    hashcode = twoDPointWithHash.GetHashCode();

                    foreach(int k in hashlist)
                    {
                        if (k == hashcode)
                        {
                            identity = false;
                        }
                    }

                    if (identity)
                    {
                        hashlist.Add(hashcode);
                    }

                }
            }
            double uniqueness = hashlist.Count * 100 / count ;

            Console.WriteLine($"Uniqueness is " + uniqueness+ "%");
            Console.ReadKey();

        }
    }
}
