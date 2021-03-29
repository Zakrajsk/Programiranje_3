using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Registracije
{
    /// <summary>
    /// Razred za hranjenje registrskih stevilk v SLO
    /// Registrka sestavljena skupaj iz 7 znakov prve 2 oznacujeta obmocje ostalih 5 pa registrsko
    /// Razred ima tudi staticni spisek vseh veljavnih obmocij
    /// </summary>
    public class Registracija
    {
        private string _obmocje;
        private string _registracija;
        private static string[] spisek_obmocij = new string[] { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };

        public Registracija(string obmocje, string registracija)
        {
            this.obmocje = obmocje;
            this.registracija = registracija;
        }

        /// <summary>
        /// Izpise registrsko v stilu obmocje : registracija
        /// </summary>
        /// <returns>return string</returns>
        public override string ToString()
        {
            return $"{this._obmocje} : {this._registracija}";
        }

        /// <summary>
        /// Lastnost obmocje, ki poskrbi za pravilnost obmocja
        /// Lahko je samo dolzine dva in mora biti vsebovan v trenutnem spisku vseh obmocji
        /// Sestavljen je lahko samo iz crk
        /// </summary>
        public string obmocje
        {
            get { return this._obmocje; }
            set
            {
                if(value.Length != 2)
                {
                    throw new Exception("Obmocje mora biti dolzine 2");
                }

                if (!spisek_obmocij.Contains(value))
                {
                    throw new Exception("Obmocje ni na spisku dovoljenih obmocij");
                }

                foreach (char crka in value)
                {
                    if (!char.IsLetter(crka))
                    {
                        throw new Exception("Obmocje mora biti sestavljeno samo iz crk");
                    }
                }
                this._obmocje = value;
            }
        }

        /// <summary>
        /// Lastnost registracije
        /// PReverja, da je vsaka registracija sestavljena iz 5 crk in/ali stevilk
        /// </summary>
        public string registracija
        {
            get { return this._registracija; }
            set
            {
                if(value.Length != 5)
                {
                    throw new Exception("Registracija mora biti dolzine 5");
                }
                foreach (char crka in value)
                {
                    if (!char.IsLetterOrDigit(crka))
                    {
                        throw new Exception("Registracija mora biti sestavljena samo iz crk in stevilk");
                    }
                }
                this._registracija = value;
            }
        }

        /// <summary>
        /// Nadomesti aktualna obmocja z novimi
        /// </summary>
        /// <param name="nova"></param>
        public static void SpremeniObmocja(string[] nova)
        {
            spisek_obmocij = nova;
        }

        /// <summary>
        /// Izpise v conzolo vse registrske, ki so iz danega obmocja
        /// </summary>
        /// <param name="registrske"></param>
        /// <param name="obmocje"></param>
        public static void IzObmocja(Registracija[] registrske, string obmocje)
        {
            foreach (Registracija posamezna in registrske)
            {
                if(posamezna.obmocje == obmocje)
                {
                    Console.WriteLine(posamezna);
                }
            }
        }

        /// <summary>
        /// Vrne slovar {obmocje : kolikokrat se pojavi v tabeli}
        /// </summary>
        /// <param name="registrske"></param>
        /// <returns>return Dictionary(string, int)</returns>
        public static Dictionary<string, int> KolikoPoObmocjih(Registracija[] registrske)
        {
            Dictionary<string, int> slovar_pogostosti = new Dictionary<string, int>();
            foreach (string obm in Registracija.spisek_obmocij)
            {
                slovar_pogostosti.Add(obm, 0);
            }

            foreach (Registracija ena in registrske)
            {
                slovar_pogostosti[ena.obmocje]++;
            }

            return slovar_pogostosti;
        }


        static void Main(string[] args)
        {
            Random rng = new Random();
            //generator registrskih
            Registracija[] tabela_registrskih = new Registracija[100];
            string ustrezni_znaki = "ABCDEFGHIJKLMNOPRSTUVZ0123456789";
            StringBuilder reg = new StringBuilder();
            int koliko_generiramo = 100;
            for(int i = 0; i < koliko_generiramo; i++)
            {
                string obmocje = Registracija.spisek_obmocij[rng.Next(Registracija.spisek_obmocij.Length)];
                for (int j = 0; j < 5; j++)
                {
                    reg.Append(ustrezni_znaki[rng.Next(ustrezni_znaki.Length)]);
                }
                tabela_registrskih[i] = new Registracija(obmocje, reg.ToString());
                reg.Clear();
            }

            //izpis
            Console.WriteLine("----------------Vsi--------------------");

            foreach (Registracija ena in tabela_registrskih)
            {
                Console.WriteLine(ena);
            }

            Console.WriteLine("----------------Samo iz LJ--------------------");

            Registracija.IzObmocja(tabela_registrskih, "LJ");

            Console.WriteLine("----------------Najdemo najpogostejšo in najredkejšo--------------------");

            Dictionary<string, int> pojavitve = Registracija.KolikoPoObmocjih(tabela_registrskih);
            string najredkejsa = "Napaka", najpogostejsa = "Napaka";
            int st_najredkejsa = koliko_generiramo, st_najpogostejsa = 0;

            foreach (KeyValuePair<string, int> eno_obmocje in pojavitve)
            {
                Console.Write($"{eno_obmocje.Key}: {eno_obmocje.Value}\t");
                if(eno_obmocje.Value < st_najredkejsa) //ce se pojami manjkrat kot dosedaj najmanjsa
                {
                    najredkejsa = eno_obmocje.Key;
                    st_najredkejsa = eno_obmocje.Value;
                }

                if(eno_obmocje.Value > st_najpogostejsa) //ce se veckrat pojavi kot do sedaj najvecja
                {
                    najpogostejsa = eno_obmocje.Key;
                    st_najpogostejsa = eno_obmocje.Value;
                }
            }
            Console.WriteLine($"\nNajpogosteja: {najpogostejsa}");
            Console.WriteLine($"Najredkejsa: {najredkejsa}");

            //spreminjanje spiska
            string[] nov_spisek = new string[Registracija.spisek_obmocij.Length - 2];
            int najden = 0; //da vemo za koliko se premakne indeks 
            int koliko_manj = 0; //s tem bomo belezili koliko manj bo vozil v novi tabeli

            for (int i = 0; i < Registracija.spisek_obmocij.Length; i++)
            {
                if(Registracija.spisek_obmocij[i] != najpogostejsa && Registracija.spisek_obmocij[i] != najredkejsa)
                {
                    nov_spisek[i - najden] = Registracija.spisek_obmocij[i];
                }
                else
                {
                    koliko_manj += pojavitve[Registracija.spisek_obmocij[i]]; //sesteje obe dve ki smo ju izbrisali
                    najden++;
                }
            }

            Registracija.SpremeniObmocja(nov_spisek);
            najden = 0; //damo nazaj na nic ker bomo spet gledali indekse
            Registracija[] nova_tabela = new Registracija[tabela_registrskih.Length - koliko_manj];

            for (int i = 0; i < tabela_registrskih.Length; i++)
            {
                if (Registracija.spisek_obmocij.Contains(tabela_registrskih[i].obmocje))
                {
                    nova_tabela[i - najden] = tabela_registrskih[i];
                }
                else
                {
                    najden++;
                }
            }

            Console.WriteLine("----------------Odstranjene vse z najpogostejšo in najredkejšo--------------------");


            foreach (Registracija ena in nova_tabela)
            {
                Console.WriteLine(ena);
            }
        }
    }
}
