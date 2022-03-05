using System;
using System.IO;

namespace Prodaja_banan
{
    class ProdajaBanan
    {
        /// <summary>
        /// Funkcija vrne tabelo dveh elementov, ki poveta skupno prodajo in najvecjo prodajo v enem mesecu za podjetje.
        /// </summary>
        /// <param name="ime_datoteke">ime datoteke v kateri so shranjeni podatki o prodaji</param>
        /// <returns>[skupna prodaja, najvecja prodaja v enem mesecu]</returns>
        public static int[] PovzetekProdaje(string ime_datoteke)
        {
            StreamReader bralec;
            try
            {
                bralec = File.OpenText("../../../" + ime_datoteke);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("Datoteke z tem imenom ni mogoče najti.");
            }

            int skupna_prodaja = 0;
            int najvecja_dnevna_prodaja = 0;

            while (!bralec.EndOfStream)
            {
                int dnevna_vsota = 0;
                string[] podatki = bralec.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                // i zacnemo steti pri 0, ce vrstica nima datuma spredaj drugace zacnemo steti z 1
                for (int i = (podatki[0].Length == 10 && podatki[0][2] == '.')? 1 : 0 ; i < podatki.Length; i++)
                {
                    dnevna_vsota += int.Parse(podatki[i]);
                }
                skupna_prodaja += dnevna_vsota;
                if (dnevna_vsota > najvecja_dnevna_prodaja)
                {
                    najvecja_dnevna_prodaja = dnevna_vsota;
                }
            }

            return new int[] { skupna_prodaja, najvecja_dnevna_prodaja };
        }
        static void Main(string[] args)
        {
            int[] podatki = PovzetekProdaje("Februar.txt");
            Console.WriteLine($"Mesecna prodaja: {podatki[0]}");
            Console.WriteLine($"Najvecja dnevna prodaja: {podatki[1]}");
        }
    }
}
