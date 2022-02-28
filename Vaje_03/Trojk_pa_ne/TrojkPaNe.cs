using System;

namespace Trojk_pa_ne
{
    class TrojkPaNe
    {
        /// <summary>
        /// tabelo podano kot parameter spremeni tako, da iz nje odstrani vse trojke celotno število ali pa tudi samo števko tri v nekem drugem številu
        /// </summary>
        /// <param name="t"></param>
        static void Krajsaj(ref int[] t)
        {
            int prazni = 0;
            for (int i = 0; i < t.Length; i++)// gremo skozi vsa števila v tabeli 
            {
                int novo = 0;
                int j = 0;
                int st = t[i];
                while (st != 0) // preveri število in odstrani trojke
                {
                    int stevka = st % 10;
                    if (stevka != 3 && stevka != -3)
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

        static void Main(string[] args)
        {
            int[] tab1 = new int[] { 5, 33, -5123, 22, 3, 433 };
            Krajsaj(ref tab1);

            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write($"{tab1[i]} ");
            }
        }
    }
}
