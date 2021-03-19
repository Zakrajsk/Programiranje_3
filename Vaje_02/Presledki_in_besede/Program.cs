using System;

namespace Presledki_in_besede
{
    class Program
    {
        /// <summary>
        /// Vrne niz, ki je enak nizu brez vseh presledkov
        /// </summary>
        /// <param name="niz"></param>
        /// <returns>return string</returns>
        public static string Brez_presledkov(string niz)
        {
            return niz.Replace("_", "");
        }

        /// <summary>
        /// Odstrani vse zaporedne presledke in jih nadomesti z enim
        /// </summary>
        /// <param name="niz"></param>
        /// <returns>return string</returns>
        public static string Brez_zaporednih_presledkov(string niz)
        {
            string nov_niz = "";
            Boolean prej_presledek = false;
            foreach(char znak in niz)
            {
                if(znak == '_' && prej_presledek)
                {
                    continue;
                }
                else
                {
                    nov_niz += znak;
                    prej_presledek = znak == '_';
                }
            }
            return nov_niz;

        }

        /// <summary>
        /// Odstrani vse zunanje presledke v nizu ki ima samo enojne presledke
        /// </summary>
        /// <param name="niz"></param>
        /// <returns>return string</returns>
        public static string Brez_zunanjih_presledkov(string niz)
        {
            if(niz[0] == '_')
            {
                niz = niz.Remove(0, 1);
            }
            if(niz[niz.Length - 1] == '_')
            {
                niz = niz.Remove(niz.Length - 1);
            }
            return niz;
        }
        static void Main(string[] args)
        {
            Console.Write("Vnesi niz:");
            string zacetni_niz = Console.ReadLine();

            Console.WriteLine("Niz brez presledkov: " + Brez_presledkov(zacetni_niz));
            string nov_brez_zaporednih = Brez_zaporednih_presledkov(zacetni_niz);
            Console.WriteLine("Niz brez zaporednih presledkov: " + nov_brez_zaporednih);
            string brez_zunanjih = Brez_zunanjih_presledkov(nov_brez_zaporednih);
            Console.WriteLine("Niz brez začetnih, končnih in zaporednih presledkov: " + brez_zunanjih);

            int stevec = 1;
            string najdaljsa = "", najkrajsa = brez_zunanjih;
            foreach (string beseda in brez_zunanjih.Split("_"))
            {
                Console.WriteLine($"{stevec}. beseda: {beseda}");
                if (beseda.Length > najdaljsa.Length)
                {
                    najdaljsa = beseda;
                }
                if(beseda.Length < najkrajsa.Length)
                {
                    najkrajsa = beseda;
                }
                stevec++;
            }
            Console.WriteLine($"Najdaljsa beseda: {najdaljsa} \nSt. ckr: {najdaljsa.Length}");
            Console.WriteLine($"Najkrajsa beseda: {najkrajsa} \nSt. ckr: {najkrajsa.Length}");
        }
    }
}
