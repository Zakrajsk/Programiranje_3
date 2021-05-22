using System;
using System.IO;

namespace N4
{
    class N4
    {
        public static string obrni_niz(string niz)
        {
            char[] tabela_znakov = niz.ToCharArray();
            Array.Reverse(tabela_znakov);
            return new string(tabela_znakov);
        }

        public static void Obrni(string imeVhod, string imeIzhod)
        {
            StreamReader branje;
            try
            {
                branje = File.OpenText(imeVhod);
            }
            catch //datoteka ne obstaja
            {
                StreamWriter napaka_pisanje = File.CreateText(imeIzhod);
                Console.WriteLine("ni datoteke");
                for(int i = 0; i < 42; i++)
                {
                    napaka_pisanje.WriteLine("Tudi pri težjih problemih smo že odpovedali!");
                }
                napaka_pisanje.Close();
                return;
            }

            StreamWriter pisanje = File.CreateText(imeIzhod);
            string vrstica;
            string obrnjena;
            while ((vrstica = branje.ReadLine()) != null)
            {
                string[] besede = vrstica.Split(" ", StringSplitOptions.RemoveEmptyEntries); //odstranimo prazne elemente
                foreach(string posamezna in besede)
                {
                    if(posamezna[0] == '-')
                    {
                        obrnjena = obrni_niz(posamezna);
                        obrnjena = obrnjena.Remove(obrnjena.Length - 1);
                        pisanje.Write(obrnjena);
                    }
                    else
                    {
                        pisanje.Write(posamezna);
                    }
                    pisanje.Write(" ");
                }
                pisanje.WriteLine();
            }

            branje.Close();
            pisanje.Close();

        }
        static void Main(string[] args)
        {
            Obrni("testna.txt", "rezultat.txt");
        }
    }
}
