using System;

namespace Lovljenje_napak_I
{
    class Program
    {
        public static int f(int i)
        {
            return 100 / (i % 3);
        }

        public static int[] tabeliraj(int n)
        {
            int[] rezultat = new int[n];

            for (int i = 0; i < n; i++)
            {
                try
                {
                    rezultat[i] = f(i);
                }
                catch
                {
                    rezultat[i] = 0;
                }
            }
            return rezultat;
        }

        static void Main(string[] args)
        {
            int[] test = tabeliraj(10);
            foreach (int st in test)
            {
                Console.Write(st + " ");
            }
        }
    }
}
