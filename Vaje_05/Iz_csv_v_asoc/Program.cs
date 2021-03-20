using System;
using System.Text;
using System.IO;

namespace Vaje_5
{
    class Program
    {
        /// <summary>
        /// Vpiše podatek iz prve datoteke v drugo datotko, z drugačnim izpisom, namesto po stopkcih v vrsticah
        /// </summary>
        /// <param name="prva_datoteka"></param>
        /// <param name="druga_datoteka"></param>
        public static void SpremeniDatotek(string prva_datoteka, string druga_datoteka)
        {
            StreamReader branje;
            try
            {
                branje = new StreamReader(prva_datoteka);
            }
            catch(Exception)
            {
                throw new Exception("Datoteke za branje ni mogoče najti!");
            }

            StreamWriter pisanje = File.CreateText(druga_datoteka);
            string vrstica = branje.ReadLine();
            string[] parametri;
            try
            {
            parametri = vrstica.Split(',');
            }
            catch(Exception)
            {
                throw new Exception("Podatki v prvi vrstici v vhodni datoteki niso ustrezni");
            }
            vrstica = branje.ReadLine();
            while (vrstica != null)
            {
                StringBuilder nov = new StringBuilder('[');
                string[] podatki = vrstica.Split(',');
                for (int i = 0; i < parametri.Length; i++)
                {
                    nov.Append($"({parametri[i].Trim()}, {podatki[i].Trim()}), ");
                }
                nov.Remove(nov.Length - 2, 2);
                vrstica = branje.ReadLine();
                nov.Append(']');
                pisanje.WriteLine(nov);

            }
            pisanje.Close();
            branje.Close();

        }
        static void Main(string[] args)
        {
            string branje;
            string pisanje;
            try
            {
                //Primer iz besedila
                branje = @"..\..\..\vnos1.txt";
                pisanje = @"..\..\..\resitev1.txt";
                SpremeniDatotek(branje, pisanje);
            }
            catch(Exception e)
            {
                Console.WriteLine("Pri primeru 1 je prislo do napake: " + e);
            }

            try
            {
                //Prazna datoteka
                branje = @"..\..\..\vnos2.txt";
                pisanje = @"..\..\..\resitev2.txt";
                SpremeniDatotek(branje, pisanje);
            }
            catch(Exception e)
            {
                Console.WriteLine("Pri primeru 2 je prislo do napake: " + e);
            }

            try
            {
                //Neobstojeca datoteka
                branje = @"..\..\..\vnos3.txt";
                pisanje = @"..\..\..\resitev3.txt";
                SpremeniDatotek(branje, pisanje);
            }
            catch (Exception e)
            {
                Console.WriteLine("Pri primeru 3 je prislo do napake: " + e);
            }
        }
    }
}
