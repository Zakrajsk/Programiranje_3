using System;
using System.IO;

namespace To_je_moja_datoteka
{
    class ToJeMojaDatoteka
    {
        static void Main(string[] args)
        {
            // Ustvari datoteko ter noter nekja napiše
            string f = @"../../../vaja.txt";
            UstvariDatoteko(f);

            // Beremo datoteko in izpišemo v konzolo
            BeriDatoteko(f);

            // Vnesi ime in ga izpiše
            VnesiIme(f);

            // Oštevilči ter izpiše vrstice iz datoteke
            Izpis(f);
        }

        /// <summary>
        /// Izpise vse vrstice v datoteki ostevilcene od 1 naprej
        /// </summary>
        /// <param name="f"></param>
        private static void Izpis(string f)
        {
            StreamReader novobranje = File.OpenText(f);
            int i = 0;
            string vrstica;
            while ((vrstica = novobranje.ReadLine()) != null)
            {
                Console.WriteLine(++i + ": " + vrstica);
            }
            novobranje.Close();
        }

        /// <summary>
        /// Uporabnika vprasa po imenu in ga zapise na konec datoteke na lokaciji f
        /// </summary>
        /// <param name="f"></param>
        private static void VnesiIme(string f)
        {
            StreamWriter dodajanje = File.AppendText(f);
            //StreamWriter dodajanje = File.CreateText(f);
            Console.WriteLine("Vnesi ime: ");
            string ime = Console.ReadLine();

            dodajanje.WriteLine(ime);
            dodajanje.Close();
        }

        /// <summary>
        /// Prebere datoteko in izpise prvo vrstico
        /// </summary>
        /// <param name="f"></param>
        private static void BeriDatoteko(string f)
        {
            StreamReader branje;
            string vrstica;

            branje = File.OpenText(f);
            vrstica = branje.ReadLine();
            branje.Close();
            Console.WriteLine(vrstica);
        }

        /// <summary>
        /// Ustvari datoteko za pisanje na lokaciji f in notri zapise "to je moja datoteka"
        /// </summary>
        /// <param name="f"></param>
        private static void UstvariDatoteko(string f)
        {
            StreamWriter pisanje = File.CreateText(f);
            pisanje.WriteLine("To je moja datoteka");
            pisanje.Close();
        }
    }
}
