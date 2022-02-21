using System;
using System.Linq;

namespace Piton_na_obisku
{
    class PitonNaObisku
    {

        /// <summary>
        /// vrne niz črk iz t-ja, ki so najbolj pogoste v s
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
            string koncni_niz = "";
            for (int i = 0; i < t.Length; i++)
            {
                if (tabela_ponovitev[i] == najvecja)
                {
                    koncni_niz += t[i];
                }
            }
            return koncni_niz;
        }
        static void Main(string[] args)
        {
            Console.Write("Vnesi niz s: ");
            string niz_s = Console.ReadLine();
            Console.Write("Vnesi niz t: ");
            string niz_t = Console.ReadLine();

            Console.WriteLine(Prestej(niz_s, niz_t));
        }
    }
}
