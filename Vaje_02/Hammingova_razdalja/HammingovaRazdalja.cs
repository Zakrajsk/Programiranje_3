using System;

namespace Hammingova_razdalja
{
    class HammingovaRazdalja
    {
        /// <summary>
        /// Vrne mediano binarnih nizov, ki jo naredi tako, da na vsakem mestu pogleda kateri znak se pojavi na tem mestu veckar in to je medianski znak za to mesto.
        /// </summary>
        /// <param name="nizi">tabela nizov</param>
        /// <returns>returns string</returns>
        public static string Mediana(string[] nizi)
        {
            if (nizi.Length == 0)
            {
                throw new ArgumentException("Tabela nizov je prazna");
            }

            string mediana = "";

            for (int i = 0; i < nizi[0].Length; i++)
            {
                int st_nic = 0;
                int st_enk = 0;
                
                for (int j = 0; j < nizi.Length; j++)
                {
                    if (nizi[j][i] == '0')
                    {
                        st_nic++;
                    }
                    else
                    {
                        st_enk++;
                    }
                }

                mediana += st_nic > st_enk ? '0' : '1';
            }

            return mediana;
        }

        /// <summary>
        /// Vrne true ali false, ce je seznam nizov medianski (mediana je vsebovana v seznamu nizov)
        /// </summary>
        /// <param name="nizi">tabela nizov</param>
        public static bool Je_medianska(string[] nizi)
        {
            //najdemo mediano
            string mediana = Mediana(nizi);

            return Array.IndexOf(nizi, mediana) > -1;
 
        }
        static void Main(string[] args)
        {
            string[] testni_nizi = { "0000", "1100", "1010" };
            Console.WriteLine(Mediana(testni_nizi));

            string[] testni_nizi2 = { "10101", "11010", "00011" };
            Console.WriteLine(Mediana(testni_nizi2));

            string[] je_mediana_test = { "111", "110", "100", "000" };
            Console.WriteLine(Je_medianska(je_mediana_test));

            string[] je_mediana_test2 = { "010", "100","001" };
            Console.WriteLine(Je_medianska(je_mediana_test2));
        }
    }
}
