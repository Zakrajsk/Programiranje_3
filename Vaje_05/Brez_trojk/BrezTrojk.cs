using System;

namespace Brez_trojk
{
    public class BrezTrojk
    {
        /// <summary>
        /// tabelo podano kot parameter spremeni tako, da iz nje odstrani vse trojke celotno število ali pa tudi samo števko v nekem drugem številu
        /// </summary>
        /// <param name="t"></param>
        public static void Krajsaj(ref int[] t)
        {
            int prazni = 0;
            for (int i = 0; i < t.Length; i++)// gremo skozi vsa števila v tabeli 
            {
                int novo = 0;
                int j = 0;
                int st = t[i];
                while (st > 0) // preveri število in odstrani trojke
                {
                    int stevka = st % 10;
                    if (stevka != 3)
                    {
                        novo += stevka * (int)Math.Pow(10, j);// ustvarja novo število ko ga ustavimo na mesto
                        j++;
                    }

                    st /= 10;
                }
                if (novo == 0)
                {
                    prazni++;
                }
                t[i] = novo;

            }
            int[] nova = new int[t.Length - prazni];
            int stevec = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == 0)
                {
                    stevec++;
                    continue;
                }
                nova[i - stevec] = t[i];
            }
            t = nova;
        }

        /// <summary>
        /// Metoda za primerjanje dveh tabel, če so podatki v njih isti
        /// </summary>
        /// <param name="resitev"></param>
        /// <param name="primerjalec"></param>
        /// <returns>return bool</returns>
        public static bool Testiraj(int[] resitev, int[] primerjalec)
        {
            if(resitev.Length != primerjalec.Length)
            {
                return false;
            }
            for (int i = 0; i < resitev.Length; i++)
            {
                if(resitev[i] != primerjalec[i])
                {
                    return false;
                }
            }
            return true;
        }


        static void Main(string[] args)
        {
        }
    }
}
