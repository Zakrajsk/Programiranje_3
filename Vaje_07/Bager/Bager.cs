using System;
using System.IO;
using System.Collections.Generic;

namespace Mehanizacija
{
    class Bager : IComparable<Bager>
    {

        private int teza;
        private string ime;
        private int leto_izdelave;
        private int cena;

        /// <summary>
        /// PRazni konstruktor naredi privzete vrednosti
        /// </summary>
        public Bager()
        {
            this.teza = 4500;
            this.ime = "Osnovni Bager";
            this.leto_izdelave = 1990;
            this.Cena = 40000;
        }

        /// <summary>
        /// konstruktor, ce so podani podakti v nizu loceni z presledkom kot: ime;teza;leto;cena
        /// </summary>
        /// <param name="niz"></param>
        public Bager(string niz)
        {
            string[] podatki = niz.Split(';');
            try
            {
                ime = podatki[0];
                teza = int.Parse(podatki[1]);
                leto_izdelave = int.Parse(podatki[2]);
                Cena = int.Parse(podatki[3]);
            }
            catch
            {
                throw new Exception("Podani so napacni podatki");
            }
        }

        /// <summary>
        /// Konstruktor, ce so podani vsi podatki
        /// </summary>
        /// <param name="ime"></param>
        /// <param name="teza"></param>
        /// <param name="leto"></param>
        /// <param name="cena"></param>
        public Bager(string ime, int teza, int leto, int cena)
        {
            this.ime = ime;
            if(teza <= 0)
            {
                throw new Exception("Teza je nesmiselna!");
            }
            this.teza = teza;

            if(leto < 1990 || leto > DateTime.Now.Year)
            {
                throw new Exception("Leto je nesmiselno!");
            }
            this.leto_izdelave = leto;

            this.Cena = cena;

        }

        public override string ToString()
        {
            return $"{this.Ime};{this.Teza};{this.LetoIzdelave};{this.Cena}";
        }

        public int Teza
        {
            get { return this.teza; }
        }

        public int Cena
        {
            get { return this.cena; }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Cena mora biti pozitivna");
                }
                this.cena = value;
            }
        }

        public int LetoIzdelave
        {
            get { return this.leto_izdelave; }
        }

        public string Ime
        {
            get { return this.ime; }
        }

        /// <summary>
        /// Za primerjati dva bagra po starosti
        /// </summary>
        /// <param name="primerjani"></param>
        /// <returns></returns>
        public int CompareTo(Bager primerjani)
        {
            if (this.LetoIzdelave.CompareTo(primerjani.LetoIzdelave) == 0)
            {
                return this.Teza - primerjani.Teza;
            }
            return this.LetoIzdelave.CompareTo(primerjani.LetoIzdelave);
        }

        public void Izpis()
        {
            Console.WriteLine($"Bager {this.Ime} težak {this.Teza} stane {this.Cena} EUR");
        }

        /// <summary>
        /// Izpise obe verziji izpisa vseh bagrov v tabeli
        /// </summary>
        /// <param name="tabela"></param>
        public static void IzpisTabele(Bager[] tabela)
        {
            foreach (Bager en in tabela)
            {
                Console.Write(en + " :---: ");
                en.Izpis();
            }
        }

        /// <summary>
        /// Zapise dan objekt v datototeko dat z atributi locenimi z presledkom
        /// </summary>
        /// <param name="dat"></param>
        public void DodajNaDatoteko(StreamWriter dat)
        {
            dat.Write(this.ToString());
            dat.Close();
        }

        /// <summary>
        /// Prebere vse vrstice v datoteki in ustvari toliko objektov in vrne tabelo le teh
        /// </summary>
        /// <param name="datoteka"></param>
        /// <returns>return Bager[]</returns>
        public static Bager[] PreberiIzDatoteke(string datoteka)
        {
            StreamReader preberi = File.OpenText("../../../" + datoteka);
            List<Bager> list_bagrov = new List<Bager>();
            string vrstica;
            
            while((vrstica = preberi.ReadLine()) != null)
            {
                list_bagrov.Add(new Bager(vrstica));
            }

            return list_bagrov.ToArray();
        }

        /// <summary>
        /// Izpise predstavitve vseh objektov v datoteki na konzolo
        /// </summary>
        /// <param name="datoteka"></param>
        public static void IzpisiDatoteko(string datoteka)
        {
            Bager[] tabela = PreberiIzDatoteke(datoteka);
            foreach (Bager posamezen in tabela)
            {
                posamezen.Izpis();
            }
        }

        /// <summary>
        /// ustvari datoteko z imenom datoteka in notri zapise st_eleemntov generiranih objektov
        /// </summary>
        /// <param name="datoteka"></param>
        /// <param name="st_elementov"></param>
        public static void TvoriDatoteke(string datoteka, int st_elementov)
        {
            Random rng = new Random();
            string[] tab_imen = new string[] { "bager", "kopac", "vrtalec", "valjar", "asfalter" };

            StreamWriter zapisovanje = File.CreateText("../../../" + datoteka);

            for (int i = 0; i < st_elementov; i++)
            {
                //generiramo podatke
                string ime = tab_imen[rng.Next(tab_imen.Length)];
                int teza = rng.Next(5000) + 2000;
                int leto = rng.Next(DateTime.Now.Year - 1990) + 1990;
                int cena = rng.Next(50000) + 25000;

                Bager nov = new Bager(ime, teza, leto, cena);
                zapisovanje.Write(nov + "\n");

            }
            zapisovanje.Close();


        }


        /// <summary>
        /// Metoda izpise najtezji bager v tabeli
        /// </summary>
        /// <param name="tabela_bagrov"></param>
        public static void Najteznji(Bager[] tabela_bagrov)
        {
            if(tabela_bagrov.Length == 0)
            {
                throw new Exception("Tabela bagrov je prazna");
            }
            Bager najtezji = tabela_bagrov[0];
            foreach (Bager posamezni in tabela_bagrov)
            {
                if(posamezni.Teza > najtezji.Teza)
                {
                    najtezji = posamezni;
                }
            }

            najtezji.Izpis();
        }

        /// <summary>
        /// Vre bagre, ki so drazji od meje pocenimo za procent %
        /// </summary>
        /// <param name="tabela"></param>
        /// <param name="meja"></param>
        /// <param name="procent"></param>
        public static void Poceni(Bager[] tabela, int meja, double procent)
        {
            foreach (Bager posamezni in tabela)
            {
                if(posamezni.Cena >= meja)
                {
                    posamezni.Cena = (int)(posamezni.Cena * ((100 - procent) / 100));
                }
            }
        }

        /// <summary>
        /// Izbrise vse bagre starejse od koliko_starih let
        /// </summary>
        /// <param name="tabela"></param>
        /// <param name="koliko_stari"></param>
        public static void IzbrisStarih(ref Bager[] tabela, int koliko_stari)
        {
            List<Bager> ustrezni = new List<Bager>();
            foreach (Bager posamezni in tabela)
            {
                if(DateTime.Now.Year - posamezni.LetoIzdelave <= koliko_stari)
                {
                    ustrezni.Add(posamezni);
                }
            }
            tabela = ustrezni.ToArray();
        }

        /// <summary>
        /// Kot parameter dobi tabelo, ki jo uredi in nato po letnicah razporedi v datoteke
        /// </summary>
        /// <param name="tabela"></param>
        /// <param name="datoteka"></param>
        public static void RazporediPoDatotekah(Bager[] tabela, string datoteka)
        {
            datoteka = datoteka.Substring(0, datoteka.Length - 4);
            Array.Sort(tabela); //uredimo ce slucajno se ni
            int letnica = tabela[0].LetoIzdelave;
            StreamWriter pisanje = File.CreateText($"../../../{datoteka}_{letnica}.txt");
            for (int i = 0; i < tabela.Length; i++)
            {
                if(tabela[i].LetoIzdelave != letnica)
                {
                    pisanje.Close();
                    letnica = tabela[i].leto_izdelave;
                    //odpremo novo datoteko
                    pisanje = File.CreateText($"../../../{datoteka}_{letnica}.txt");

                }
                pisanje.WriteLine(tabela[i]);
            }
            pisanje.Close();
        }



        static void Main(string[] args)
        {
            string testna_datoteka = "testna1.txt";
            Bager.TvoriDatoteke(testna_datoteka, 12);
            Bager[] prebrani = Bager.PreberiIzDatoteke(testna_datoteka);

            Bager.IzpisTabele(prebrani);

            Console.WriteLine("------------------------------------------------------------");
            //najtezji bager
            Console.Write("Najtezji bager: ");
            Bager.Najteznji(prebrani);

            Console.WriteLine("------------------------------------------------------------");
            //pocenitev bagrov
            Console.WriteLine("Pocenili vse nad 20.000 EUR za 20%: ");
            Bager.Poceni(prebrani, 20000, 20);

            Bager.IzpisTabele(prebrani);

            Console.WriteLine("------------------------------------------------------------");
            //Urejanje po letih
            Console.WriteLine("Urejeni po letih: ");
            Array.Sort(prebrani);

            Bager.IzpisTabele(prebrani);

            Console.WriteLine("------------------------------------------------------------");
            //Brisanje starejsih od 12 let
            Console.WriteLine("Izbrisani starejsi od 12ih let: ");
            Bager.IzbrisStarih(ref prebrani, 12);

            Bager.IzpisTabele(prebrani);

            Console.WriteLine("------------------------------------------------------------");
            //Brisanje starejsih od 12 let
            Console.WriteLine("Naredimo izpis po letnicah v posamezne datoteke: ");
            Bager.RazporediPoDatotekah(prebrani, testna_datoteka);

            Console.WriteLine("Opravljeno! Datoteke preveri v raziskovalcu");


        }
    }
}
