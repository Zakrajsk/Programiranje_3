using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Izpit_datoteke
{
    class Sloni
    {
        /// <summary>
        /// Metoda generira v datoteko 100 slonov, ki jim naključno dodeli vrsto, starost in težo.
        /// Vsakega zapiše v svojo vrsto, lastnosti pa so ločene z vejicami.
        /// </summary>
        /// <param name="ime_datoteke">ime kamor zapiše slone</param>
        public static void GeneratorSlonov(string ime_datoteke)
        {
            string[] vrste = new string[] { "Afriski savanjski", "Afriski gozdni", "Azijski" };
            Random rng = new Random();
            StreamWriter zapisovanje = File.CreateText(@"..\..\" + ime_datoteke);
            char spol;
            int teza;
            int starost;
            
            for (int i = 0; i < 100; i++)
            {
                spol = new char[] { 'M', 'Z' }[rng.Next(2)];
                starost = rng.Next(5, 35);
                if (spol == 'M')
                {
                    teza = (int)(rng.NextDouble() * 2600 + 2500);
                }
                else
                {
                    teza = (int)(rng.NextDouble() * 1000 + 2000);
                }
                zapisovanje.WriteLine($"{vrste[rng.Next(3)]},{spol},{starost},{teza}");
            }
            zapisovanje.Close();
        }
        /// <summary>
        /// Metoda primerja povprecje teze slonov z povprecjem teze slonic
        /// </summary>
        /// <param name="ime_datoteke">Datoteka, kjer so shranjeni podatki slonov</param>
        public static void PrimerjajTeze(string ime_datoteke)
        {
            StreamReader bralec = new StreamReader(@"..\..\" + ime_datoteke);

            string vrstica;
            int vsota_slonov = 0;
            int st_slonov = 0;
            int vsota_slonic = 0;
            int st_slonic = 0;

            Dictionary<string, int> pojavitev_vrst = new Dictionary<string, int>();

            for (int i = 0; i < 100; i++)
            {
                vrstica = bralec.ReadLine();
                string[] podatki = vrstica.Split(','); //teza bo na 3. indeksu, spol pa na 1.
                if (podatki[1] == "M")
                {
                    vsota_slonov += int.Parse(podatki[3]);
                    st_slonov++;
                }
                else
                {
                    vsota_slonic += int.Parse(podatki[3]);
                    st_slonic++;
                }

                if (pojavitev_vrst.ContainsKey(podatki[0]))
                {
                    pojavitev_vrst[podatki[0]]++;
                }
                else
                {
                    pojavitev_vrst[podatki[0]] = 1;
                }

            }
            StreamWriter zapisovanje = File.CreateText(@"..\..\rezultat.txt");
            zapisovanje.WriteLine($"{vsota_slonov / st_slonov - vsota_slonic / st_slonic }");

            foreach (KeyValuePair<string, int> ena in pojavitev_vrst)
            {
                zapisovanje.WriteLine($"{ena.Key}: {ena.Value}");
            }
            zapisovanje.Close();
        }


        static void Main(string[] args)
        {
            //GeneratorSlonov("sloni.txt");
            PrimerjajTeze("sloni.txt");

        }
    }
}
