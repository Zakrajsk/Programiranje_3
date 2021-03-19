using System;
using System.Collections.Generic;


namespace Izpis_tabele
{

    class Program
    {
        /// <summary>
        /// Iz tabele izpise tabelo, kjer bo v vsaki vrsti n znakov locenih z nizom vmes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tab"></param>
        /// <param name="n"></param>
        /// <param name="vmes"></param>
        public static void IzpisTabele<T>(T[] tab, int n, string vmes)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (i % n == 0)
                {
                    if (i != 0)
                    {
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.Write(vmes);
                }
                Console.Write(tab[i]);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int[] test = new int[] { 12, 5, 6, 78, 3, 5, 6, 21, 434, 56, 42, 7 };
            char[] test_char = new char[] { 'A', 'B', 'C', 'L', 'G', 'P' };
            bool[] test_bool = new bool[] { true, false, true, true, false, false, false, true, true };
            IzpisTabele(test, 5, " : ");
            IzpisTabele(test_char, 3, " : ");
            IzpisTabele(test_bool, 4, " : ");
        }
    }
}


