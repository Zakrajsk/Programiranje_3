using System;

namespace Vsote
{
    class Vsote
    {
        /// <summary>
        /// Izracuna seznam vsot strnjenih podseznamov dolzine k
        /// </summary>
        /// <param name="seznam">Seznam stevil</param>
        /// <param name="dolzina">dolzina strnjenih podseznamov</param>
        /// <returns>return int[]</returns>
        public static int[] VsotaPodseznamov(int[] seznam, int dolzina)
        {
            int dol_seznama = seznam.Length;

            if (dolzina > dol_seznama)
            {
                throw new ArgumentException("Dolzina podana je daljsa kot seznam");
            }

            int[] vsote = new int[dol_seznama - dolzina + 1];
            for (int zacetek = 0; zacetek < dol_seznama - dolzina + 1; zacetek++)
            {
                //Izracunamo vsoto enega podseznama
                int ena_vsota = 0;
                for (int j = 0; j < dolzina; j++)
                {
                    ena_vsota += seznam[zacetek + j];
                }

                vsote[zacetek] = ena_vsota;
            }

            return vsote;

        }
        static void Main(string[] args)
        {
            int[] testna = { 2, 3, 5, 1, 3, 2, 1 };
            int[] rezultat = VsotaPodseznamov(testna, 3);
            for (int i = 0; i < rezultat.Length; i++)
            {
                Console.Write(rezultat[i] + " ");
            }

        }
    }
}
