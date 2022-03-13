using System;

namespace Vsota_II
{
    class VsotaII
    {
        public static string Sestej(string[] tabela)
        {
            string rez = "";
            foreach (string en_niz in tabela)
            {
                rez += en_niz;
            }

            return rez;
        }

        public static int Sestej(int[] tabela)
        {
            int vsota = 0;
            foreach (int en_el in tabela)
            {
                vsota += en_el;
            }

            return vsota;
        }
        static void Main(string[] args)
        {

            int[] tabela = new int[] { 1, 4, 5, 2, 1, 9 };
            string[] tabela_nizov = new string[] { "lala", "lele", "lili" };
            Console.WriteLine(Sestej(tabela));
            Console.WriteLine(Sestej(tabela_nizov));
        }
    }
}
