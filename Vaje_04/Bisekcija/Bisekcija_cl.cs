using System;
using System.Collections.Generic;

namespace Bisekcija
{
    class Bisekcija_cl
    {
        /// <summary>
        /// Genericna bisekcija, ki poisce in vrne na katerem indeksu je element. Če tega ni vrne -1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela"></param>
        /// <param name="iskan"></param>
        /// <returns></returns>
        public static int Bisekcija<T>(T[] tabela, T iskan) where T : IComparable
        {
            int min = 0;
            int max = tabela.Length;

            while (min < max)
            {
                int sredina = (min + max) / 2;
                if (tabela[sredina].CompareTo(iskan) == 0)
                {
                    return sredina;
                }

                else if (tabela[sredina].CompareTo(iskan) < 0)
                {
                    min = ++sredina;
                }
                else
                {
                    max = --sredina;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] test = new int[] { 3, 5, 7, 9, 21, 45, 321, 450, 599, 640, 1002 };
            char[] test_char = new char[] { 'A', 'B', 'C', 'G', 'L', 'P', 'T' };
            string[] test_string = new string[] { "aac", "aal", "abe", "abz", "aku", "asn", "aua", "auv" };

            Console.WriteLine(Bisekcija(test, 8));
            Console.WriteLine(Bisekcija(test, 1002));
            Console.WriteLine(Bisekcija(test_char, 'G'));
            Console.WriteLine(Bisekcija(test_char, 'M'));
            Console.WriteLine(Bisekcija(test_string, "aua"));
            Console.WriteLine(Bisekcija(test_string, "nop"));
        }
    }
}
