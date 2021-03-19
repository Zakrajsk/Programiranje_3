using System;
using System.Linq;

namespace Piton_na_obisku
{
    class Program
    {
        /// <summary>
        /// vrne niz črk iz t-ja, ki so najbolj pogoste v s
        /// za:
        ///     s  = "pekarna ",  t = "kam" 
        /// dobimo: "a"
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns> return string </returns>
        public static string Prestej(string s, string t)
        {
            int najvecja;
            int[] tabela_ponovitev = new int[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                tabela_ponovitev[i] = s.Split(t[i]).Length - 1;
            }
            najvecja = tabela_ponovitev.Max();
            string u = "";
            for (int i = 0; i < t.Length; i++)
            {
                if (tabela_ponovitev[i] == najvecja)
                {
                    u += t[i];
                }
            }
            return u;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string ukaz = Prestej("pekarna", "kam");
            string ukaz2 = Prestej("neznani tekst", "taei");

            Console.WriteLine(ukaz);
            Console.WriteLine(ukaz2);
        }
    }
}
