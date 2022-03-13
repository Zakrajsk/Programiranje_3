using System;
using System.Linq;
using System.Collections.Generic;

namespace Prozenje_napak_II
{
    class ProzenjeNapakII
    {
        public static List<int> IndeksiNajmanjsih<T>(T[] seznam) where T : IComparable
        {
            if(seznam.Length == 0)
            {
                throw new Exception("Tabela je prazna");
            }

            T najmanjsi;
            try
            {
                najmanjsi = seznam.Min();
            }
            catch
            {
                throw new Exception("Najmanjšega elementa se ne da izračunati!");
            }


            List<int> index_najmanjsih = new List<int>();
            for (int i = 0; i < seznam.Length; i++)
            {
                if(seznam[i].CompareTo(najmanjsi) == 0)
                {
                    index_najmanjsih.Add(i);
                }
            }

            return index_najmanjsih;
        }
        static void Main(string[] args)
        {
            try
            {
                int[] testna_prazna = new int[0];
                int[] testna_int = new int[] { 2, 3, 5, 1, 6, 8, 2, 1, 5 };
                string[] testna_string = new string[] { "aaa", "abc", "abg", "alc", "aui", "aaa", "kla", "ops", "uss" };
                List<int> resitev = IndeksiNajmanjsih(testna_prazna);
                foreach (int element in resitev)
                {
                    Console.Write(element + " ");

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Napaka je bila: " + e);
            }
        }
    }
}
