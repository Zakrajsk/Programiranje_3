using System;
using System.Collections.Generic;

namespace Stevke_so_delitelji
{
    class Program
    {
        /// <summary>
        /// Vrne true ce vse stevke od stevila st delijo stevilo k
        /// </summary>
        /// <param name="k"></param>
        /// <param name="st"></param>
        /// <returns>return bool</returns>
        public static bool Delijo_vse_stevke(int k, int st)
        {
            while(st > 0)
            {
                int stevka = st % 10;
                if(stevka != 0 && k % stevka != 0)
                {
                    return false;
                }
                st /= 10;
            }
            return true;
        }

        /// <summary>
        /// Vrne list st od intervala [a, b], kjer vse stevke delijo stevilo k
        /// </summary>
        /// <param name="k"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>return List<int></returns>
        public static List<int> Posebni_delitelji(int k, int a, int b)
        {
            List<int> vsi_ustrezni = new List<int>();
            for (int i = a; i <= b; i++)
            {
                if(Delijo_vse_stevke(k, i))
                {
                    vsi_ustrezni.Add(i);
                }
            }
            return vsi_ustrezni;

        }
        static void Main(string[] args)
        {
            Console.Write("Vnesi a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Vnesi b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Vnesi k: ");
            int k = int.Parse(Console.ReadLine());

            List<int> resitev = Posebni_delitelji(k, a, b);
            if(resitev.Count == 0)
            {
                Console.WriteLine($"V intervalu [{a}, {b}] ni celih števil, v katerih vsaka neničelna števka deli {k}.");
            }
            else
            {
                Console.Write($"Cela števila iz intervala [{a}, {b}], v katerih vsaka neničelna števka deli {k}, so: ");
                for (int i = 0; i < resitev.Count; i++)
                {
                    Console.Write(resitev[i] + (i != resitev.Count - 1? ", " : "."));
                }
            }

        }
    }
}
