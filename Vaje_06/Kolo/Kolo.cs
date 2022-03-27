using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kolesarnica
{
    public class Kolo
    {
        private int _st_prestav;
        private string _barva;
        private string _tip;
        private int _leto_izdelave;
        private int _st_sedezev; //Za koliko ljudi je kolo

        //osnovni konstruktor
        public Kolo()
        {
            this.StPredstav = 6;
            this.Barva = "crna";
            this.Tip = "cestno";
            this.LetoIzdelave = 2000;
            this._st_sedezev = 1;
            
        }

        /// <summary>
        /// Kolo bo cestno z neznanim letom izdelave 2000 in 1 sedezem
        /// </summary>
        /// <param name="st_prestav"></param>
        /// <param name="barva"></param>
        public Kolo(int st_prestav, string barva)
        {
            this.StPredstav = st_prestav;
            this.Barva = barva;
            this.Tip = "cestno";
            this.LetoIzdelave = 2000;
            this._st_sedezev = 1;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="st_prestav"></param>
        /// <param name="barva"></param>
        /// <param name="tip"></param>
        /// <param name="leto_izdelave"></param>
        /// <param name="st_sedezev"></param>
        public Kolo(int st_prestav, string barva, string tip, int leto_izdelave, int st_sedezev)
        {
            this.StPredstav = st_prestav;
            this.Barva = barva;
            this.Tip = tip;
            this.LetoIzdelave = leto_izdelave;
            this._st_sedezev = st_sedezev;

        }

        public int StPredstav
        {
            get { return this._st_prestav; }
            set
            {
                if (value > 0 && value < 40)
                {
                    this._st_prestav = value;
                }
                else
                {
                    throw new ArgumentException("Neveljavno stevilo prestav");
                }
            }
        }

        public string Barva
        {
            get { return this._barva; }
            set { this._barva = value; }
        }

        public string Tip
        {
            get { return this._tip; }
            set { this._tip = value; }
        }

        public int LetoIzdelave
        {
            get { return this._leto_izdelave; }
            set
            {
                if (value > 1000 && value < 2022)
                {
                    this._leto_izdelave = value;
                }
                else
                {
                    throw new ArgumentException("Nesmiselno leto povezave");
                }
            }
        }

        public int StSedezev
        {
            get { return this._st_sedezev; }
            //set metode ni, saj je nikoli ne bomo mogli spreminjat
        }

        public override string ToString()
        {
            return $"{this.Tip} kolo izdelano leta {this.LetoIzdelave} je {this.Barva} barve in ima {this.StPredstav} predstav in {this.StSedezev} sedezev.";
        }

        /// <summary>
        /// Zapise dano kolo v datoteko na konec
        /// </summary>
        /// <param name="ime_datoteke">ime datoteke</param>
        public void ZapisiVDatoteko(string ime_datoteke)
        {
            StreamWriter zapisovanje = File.AppendText(@"..\..\" + ime_datoteke);
            zapisovanje.WriteLine(this.ToString());
            zapisovanje.Close();
        }

        /// <summary>
        /// Iz niza prebere kolo in ga vrne
        /// </summary>
        /// <param name="niz"></param>
        public static Kolo PreberiIzNiza(string niz)
        {
            string[] podatki = niz.Split(' ');
            Kolo novo = new Kolo(int.Parse(podatki[10]), podatki[6], podatki[0], int.Parse(podatki[4]), int.Parse(podatki[13]));
            return novo;
        }

        
    }

    public class Testiranje
    {
        public static Random rng = new Random();

        /// <summary>
        /// Metoda za generiranje koles
        /// </summary>
        /// <param name="st_koles"></param>
        /// <returns></returns>
        public static Kolo[] GenerirajKolesa(int st_koles)
        {

            String[] barve = new string[] { "rdece", "bele", "crne", "modre", "zelene", "rjave", "sive", "rumene" };
            string[] tipi = new string[] { "cestno", "gorsko", "treking" };
            Kolo[] tab_koles = new Kolo[st_koles];


            for (int i = 0; i < st_koles; i++)
            {
                int st_prestav = rng.Next(1, 40);
                string barva = barve[rng.Next(barve.Length)];
                string tip = tipi[rng.Next(tipi.Length)];
                int leto_izdelave = rng.Next(1900, 2022);
                int st_sedezev = rng.Next(10) > 8 ? 2 : 1; //Zaradi redkosti dvosedeznih koles
                tab_koles[i] = new Kolo(st_prestav, barva, tip, leto_izdelave, st_sedezev);
            }

            return tab_koles;
        }

        /// <summary>
        /// Metoda presteje in izpise koliko koles posamezne barve je v tabeli
        /// </summary>
        /// <param name="tab_koles">tabela koles</param>
        public static void PrestejBarve(Kolo[] tab_koles)
        {
            Dictionary<string, int> stevilo_barv = new Dictionary<string, int>();
            foreach (Kolo kolo in tab_koles)
            {
                if (stevilo_barv.Keys.Contains(kolo.Barva))
                {
                    //Barva ze obstaja zato samo povezacmo stevec
                    stevilo_barv[kolo.Barva]++;
                }
                else
                {
                    //se ni barve, zato jo dodamo
                    stevilo_barv[kolo.Barva] = 1;
                }

            }
            Console.WriteLine("Barva: Stevilo koles");
            foreach (string barva in stevilo_barv.Keys)
            {
                Console.WriteLine($"{barva}: {stevilo_barv[barva]}");
            }
        }

        /// <summary>
        /// Metoda v tabeli koles pobarva vsa kolesa, ki so stare barve na novo barvo
        /// </summary>
        /// <param name="stara_barva">barva ki jo bomo spremenili</param>
        /// <param name="nova_barva">barva z katero bomo prebarvali</param>
        public static void PrebarvajKolesa(Kolo[] tab_koles, string stara_barva, string nova_barva)
        {
            foreach (Kolo kolo in tab_koles)
            {
                if (kolo.Barva == stara_barva)
                {
                    kolo.Barva = nova_barva;
                }
            }
        }

        /// <summary>
        /// Metoda vrne koliko sedezev imamo na cestnih kolesih v tabeli
        /// </summary>
        /// <param name="tab_koles">tabela koles</param>
        public static int KolikoCestnih(Kolo[] tab_koles)
        {
            int vsota_sedezev = 0;

            foreach (Kolo kolo in tab_koles)
            {
                if (kolo.Tip == "cestno")
                {
                    vsota_sedezev += kolo.StSedezev;
                }
            }
            return vsota_sedezev;
        }
        

        static void Main(string[] args)
        {
            //Generiranje koles in shranjevanje v datoteko
            Kolo[] tab_koles = GenerirajKolesa(100);
            for (int i = 0; i < tab_koles.Length; i++)
            {
                tab_koles[i].ZapisiVDatoteko("test100.txt");
            }

            Console.WriteLine("Barve generiranih koles");
            PrestejBarve(tab_koles);

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Prebarvamo vsa rdeca kolesa na rumeno");

            PrebarvajKolesa(tab_koles, "rdece", "rumene");
            Console.WriteLine("Ko smo prebarvali kolesa imamo naslednje barve");
            PrestejBarve(tab_koles);

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Prestejmo sedeze na cestnih kolesih: {KolikoCestnih(tab_koles)}");


        }
    }
}
