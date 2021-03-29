using System;

namespace Racuni
{
    public class Racun
    {
        private string valuta;
        private double stanje;
        private double tecaj;

        public Racun(string valuta, double tecaj)
        {
            this.valuta = valuta;
            this.tecaj = tecaj;
            this.stanje = 0;
        }

        public override string ToString()
        {
            return $"Stanje: {this.stanje}{this.valuta}, kar je {this.StanjeEUR}EUR";
        }

        /// <summary>
        /// Vrne stanje v eur
        /// </summary>
        public double StanjeEUR
        {
            get { return this.stanje * this.tecaj; }
        }

        /// <summary>
        /// Pretvori eure v dano valuto in jo doda stanju
        /// </summary>
        /// <param name="znesek_v_eur"></param>
        public void Polog(double znesek_v_eur)
        {
            this.stanje += znesek_v_eur / this.tecaj;
        }

        static void Main(string[] args)
        {
        }
    }
}
