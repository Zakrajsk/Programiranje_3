using System;
using Racuni;
using Vozila;
using System.Collections.Generic;

namespace Urejanje_objektov
{
    class Urejanje_objektov
    {
        public static Random rng = new Random();
        static void Main(string[] args)
        {
            TestirajVozilo();
        }

        /// <summary>
        /// Metoda, ki testira razred Racun tako, da generira 10 random potem doda kopijo 3. 5. in se enkrat 3. elementa
        /// in jih poizkusa urediti z Array sort, kar pomeni, da ima vredu compareTo metodo. Preveri potem uporabnik z metoda ostrega očesa :D
        /// </summary>
        private static void TestirajRacun()
        {
            string[] valute = new string[] { "DOLLAR", "LUM", "EUR" };
            double[] tecaji = new double[] { 0.879, 1.2, 1.0 };
            Racun[] tabela_racunov = new Racun[13]; //10 generiranih + 3 dodani pri 3.tocki
            for (int i = 0; i < tabela_racunov.Length - 3; i++)
            {
                double stanje = rng.NextDouble() * 100;
                int izbran = rng.Next(valute.Length);
                tabela_racunov[i] = new Racun(valute[izbran], tecaji[izbran]);
                tabela_racunov[i].Polog(stanje);
            }

            //dodamo kopijo 3. 5. in se enkrat 3. elementa
            tabela_racunov[tabela_racunov.Length - 3] = new Racun(tabela_racunov[2].Valuta, tabela_racunov[2].Tecaj);
            tabela_racunov[tabela_racunov.Length - 3].Polog(tabela_racunov[2].StanjeEUR);
            tabela_racunov[tabela_racunov.Length - 2] = new Racun(tabela_racunov[4].Valuta, tabela_racunov[4].Tecaj);
            tabela_racunov[tabela_racunov.Length - 2].Polog(tabela_racunov[4].StanjeEUR);
            tabela_racunov[tabela_racunov.Length - 1] = new Racun(tabela_racunov[2].Valuta, tabela_racunov[2].Tecaj);
            tabela_racunov[tabela_racunov.Length - 1].Polog(tabela_racunov[2].StanjeEUR);

            //izpis generiranih
            IzpisTabele(tabela_racunov);

            Array.Sort(tabela_racunov);

            IzpisTabele(tabela_racunov);
        }

        /// <summary>
        /// Metoda, ki testira razred Vozilo tako, da generira 10 random potem doda kopijo 3. 5. in se enkrat 3. elementa
        /// in jih poizkusa urediti z Array sort, kar pomeni, da ima vredu compareTo metodo. Preveri potem uporabnik z metoda ostrega očesa :D
        /// </summary>
        private static void TestirajVozilo()
        {
            Vozilo[] tabela_vozil = new Vozilo[13]; //10 generiranih + 3 dodani pri 3.tocki
            for (int i = 0; i < tabela_vozil.Length - 3; i++)
            {
                double poraba = rng.NextDouble() * 15;
                double kapaciteta = rng.NextDouble() * 80 + 15;
                tabela_vozil[i] = new Vozilo(kapaciteta, poraba);
            }

            //dodamo kopijo 3. 5. in se enkrat 3. elementa
            tabela_vozil[tabela_vozil.Length - 3] = new Vozilo(tabela_vozil[2].Kapaciteta, tabela_vozil[2].Poraba);
            tabela_vozil[tabela_vozil.Length - 2] = new Vozilo(tabela_vozil[4].Kapaciteta, tabela_vozil[4].Poraba);
            tabela_vozil[tabela_vozil.Length - 1] = new Vozilo(tabela_vozil[2].Kapaciteta, tabela_vozil[2].Poraba);


            //izpis generiranih
            IzpisTabele(tabela_vozil);

            Array.Sort(tabela_vozil);

            IzpisTabele(tabela_vozil);
        }

        private static void IzpisTabele<T>(T[] tabela)
        {
            Console.WriteLine("Izpisujemo tabelo");
            for (int i = 0; i < tabela.Length; i++)
            {
                if(tabela[i] != null)
                {

                    Console.WriteLine(tabela[i]);
                }
            }
        }
    }
}
