using System;

namespace Hisne_stevilke
{
    class Program
    {
        /// <summary>
        /// Vrne tabelo kjer tab[i] predstavlja kolikokrat se stevilka i pojavi med stevkami med stevili od prva do zadnja
        /// </summary>
        /// <param name="prva"></param>
        /// <param name="zadnja"></param>
        /// <returns>return int[]</returns>
        public static int[] Koliko_potrebujemo(int prva, int zadnja)
        {
            int[] potrebe_posameznih = new int[10];

            for(int i=prva; i <= zadnja; i++)
            {
                int stevilka = i;
                while(stevilka > 0)
                {
                    int stevka = stevilka % 10;
                    potrebe_posameznih[stevka]++;
                    stevilka /= 10;
                }
            }

            return potrebe_posameznih;
        }
        static void Main(string[] args)
        {
            Console.Write("Vnesi prvo stevilko: ");
            int prva = int.Parse(Console.ReadLine());
            Console.Write("Vnesi zadnjo stevilko: ");
            int zadnja = int.Parse(Console.ReadLine());

            int[] potrebe = Koliko_potrebujemo(prva, zadnja);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}: {potrebe[i]}x");
            }
        }
    }
}
