using System;

namespace N3
{
    public class Dolzina : IComparable<Dolzina>
    {
        private string enota;
        private double kolicina;
        private string[] dovoljene = { "m", "dm", "cm", "mm" };
        private int[] pretvorbe = { 1, 10, 100, 1000};

        public Dolzina(double kolicina, string enota)
        {
            bool pravilna = false;
            foreach(string posamezna in this.dovoljene)
            {
                if (enota == posamezna)
                {
                    pravilna = true;
                    break;
                }
            }

            if (!pravilna)
            {
                throw new Exception("Nepravilna enota");
            }
            this.enota = enota;
            this.Koliko = kolicina;
        }

        public string Enota
        {
            get { return this.enota; }
        }

        public double Koliko
        {
            get { return this.kolicina; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Kolicina ne more biti manjsa od 0");
                }
                this.kolicina = value;
            }
        }

        /// <summary>
        /// Pretvori dano dolzino v centimetre in jih vrne
        /// </summary>
        /// <returns></returns>
        public double pretvori_v_cm()
        {
            if (this.enota == "mm")
            {
                return this.Koliko * 0.1;
            }
            if (this.enota == "cm")
            {
                return this.Koliko * 1;
            }
            if (this.enota == "dm")
            {
                return this.Koliko * 10;
            }
            return this.Koliko * 100;
        }

        public static Dolzina operator *(Dolzina mnozenec, int mnozitelj)
        {
            mnozenec.Koliko = mnozenec.Koliko * mnozitelj;
            return mnozenec;
        }

        public static Dolzina operator *(int mnozitelj, Dolzina mnozenec)
        {
            return mnozenec * mnozitelj;
        }


        public override string ToString()
        {
            double centimetri = this.pretvori_v_cm();
            return $"{centimetri} cm";
        }

        public int CompareTo(Dolzina primerjani)
        {
            //Pretvorimo razdalji
            double pret_prva = this.pretvori_v_cm();
            double pret_druga = primerjani.pretvori_v_cm();
            return pret_prva.CompareTo(pret_druga);
        }

        /// <summary>
        /// Vrne najkrajso dolzino v tabeli, v primeru da je tabela prazna vrne null
        /// </summary>
        /// <param name="tabela_dolzin"></param>
        /// <returns></returns>
        public static Dolzina NajkrajsaRazdalja(Dolzina[] tabela_dolzin)
        {
            if(tabela_dolzin.Length == 0)
            {
                return null;
            }
            Array.Sort(tabela_dolzin);
            return tabela_dolzin[0];
        }


        static void Main()
        {
            Dolzina[] par = new Dolzina[3];
            par[0] = new Dolzina(3.0, "m");
            par[1] = new Dolzina(54, "mm");
            par[2] = new Dolzina(100000, "mm");
            Console.WriteLine(Dolzina.NajkrajsaRazdalja(par));


            Dolzina test = new Dolzina(30, "cm");
            test = test * 5;
            Console.WriteLine(test);

            test = 10 * test;
            Console.WriteLine(test);
        }

    }
}
