using System;

namespace Lovljenje_napak_I
{
    class LovljenjeNapakI
    {
        /// <summary>
        /// Metoda, ki jo uporabi metoda tabeliraj in na elementi opravi neko operacijo
        /// </summary>
        /// <param name="i">Stevilo</param>
        /// <returns>return racun z danim stevilom i</returns>
        public static int f(int i)
        {
            return 100 / (i % 3);
        }

        /// <summary>
        /// Za stevila od 0 do n opravi izracun zapisan v metodi f in jih zapise v tabelo. V primeru da se f ne da izracunati zapise 0 na ustrezno mesto
        /// </summary>
        /// <param name="n">Stevilo elementov v tabeli</param>
        /// <returns>int[]</returns>
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
            Console.WriteLine(string.Join(" ", test));
        }
    }
}
