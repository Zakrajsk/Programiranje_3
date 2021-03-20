using System;

namespace Brez_trojk
{
    class Program
    {
        /// <summary>
        /// tabelo podano kot parameter spremeni tako, da iz nje odstrani vse trojke celotno število ali pa tudi samo števko v nekem drugem številu
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
            //Mesani primer
            int[] tab1 = new int[] { 5, 33, 5123, 22, 3, 433};
            Krajsaj(ref tab1);
            int[] resitev1 = new int[] { 5, 512, 22, 4 };
            Console.WriteLine("Preverjanje prvega testa:\t" + Testiraj(tab1, resitev1));

            //Prazna tabela
            int[] tab2 = new int[0];
            Krajsaj(ref tab2);
            int[] resitev2 = new int[0];
            Console.WriteLine("Preverjanje drugega testa:\t" + Testiraj(tab2, resitev2));

            //Brez trojk
            int[] tab3 = new int[] { 5, 6, 9, 22, 2 };
            Krajsaj(ref tab3);
            int[] resitev3 = new int[] { 5, 6, 9, 22, 2 };
            Console.WriteLine("Preverjanje tretjega testa:\t" + Testiraj(tab3, resitev3));

            //Vsi elementi samo trojke
            int[] tab4 = new int[] { 3, 33, 33, 3333, 3, 333 };
            Krajsaj(ref tab4);
            int[] resitev4 = new int[0];
            Console.WriteLine("Preverjanje prvega testa:\t" + Testiraj(tab4, resitev4));
        }
    }
}
