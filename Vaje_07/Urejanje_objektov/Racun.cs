using System;

namespace Racuni
{
    public class Racun : IComparable<Racun>
    {
        private static int koliko = 0;
        private int st_racuna;
        private string valuta;
        private double stanje;
        private double tecaj;

        public Racun(string valuta, double tecaj) 
        {
            this.valuta = valuta;
            this.tecaj = tecaj;
            this.stanje = 0;

            Racun.koliko++;
            this.st_racuna = Racun.koliko;
        }

        public override string ToString()
        {
            return $"{this.st_racuna} - Stanje: {this.stanje}{this.valuta}, kar je {this.StanjeEUR}EUR";
        }

        /// <summary>
        /// Vrne stanje v eur
        /// </summary>
        public double StanjeEUR
        {
            get { return this.stanje * this.tecaj; }
        }

        public string Valuta
        {
            get { return this.valuta; }
        }

        public double Tecaj
        {
            get { return this.tecaj; }
        }

        public double Stanje
        {
            get { return this.stanje; }
        }

        /// <summary>
        /// Pretvori eure v dano valuto in jo doda stanju
        /// </summary>
        /// <param name="znesek_v_eur"></param>
        public void Polog(double znesek_v_eur)
        {
            this.stanje += znesek_v_eur / this.tecaj;
        }

        public override bool Equals(object primerjani)
        {
            if(primerjani is Racun)
            {
                Racun primer = (Racun)primerjani;
                return primer.StanjeEUR == this.StanjeEUR;
            }
            return false;
        }

        public int CompareTo(Racun primerjani)
        {
            if(this.StanjeEUR.CompareTo(primerjani.StanjeEUR) == 0)
            {
                return this.st_racuna - primerjani.st_racuna;
            }
            return this.StanjeEUR.CompareTo(primerjani.StanjeEUR);
        }
    }
}
