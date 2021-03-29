using System;

namespace Vozila
{
    public class Vozilo
    {
        private double gorivo; //litri
        private double kapaciteta; //litri
        private double poraba;  //litri na 100 km

        public Vozilo(double kapaciteta, double poraba)
        {
            if(kapaciteta < 0)
            {
                throw new Exception("Kapaciteta ne more biti negativna!");
            }

            if(poraba <= 0 || poraba > kapaciteta)
            {
                throw new Exception("Podana je nesmiselna poraba vozila");
            }

            this.gorivo = kapaciteta;
            this.kapaciteta = kapaciteta;
            this.poraba = poraba;
        }

        public override string ToString()
        {
            return $"Avto z kapaciteto tanka: {this.kapaciteta}l ima še {this.gorivo}l goriva njegova poraba je {this.poraba}l/100km";
        }

        public double GetGorivo()
        {
            return this.gorivo;
        }

        public double PreostaliKilometri
        {
            get { return this.gorivo / this.poraba * 100; }
        }

        public void Crpalka()
        {
            this.gorivo = this.kapaciteta;
        }

        public bool Prevozi(double[] opis_poti)
        {
            double trenutno = this.gorivo;
            foreach (double pot in opis_poti)
            {
                if(pot < 0)
                {
                    throw new Exception("Pot ne more biti negativna");
                }

                if(pot == 0){
                    if(trenutno == this.kapaciteta)
                    {
                        throw new Exception("Gorivo poskušaš tankati v poln tank");
                    }
                    else
                    {
                        //napolnimo tank
                        trenutno = this.kapaciteta;
                    }
                }

                trenutno -= pot / 100 * this.poraba;
                if (trenutno < 0)
                {
                    return false;
                }

            }
            this.gorivo = trenutno;
            return true;
        }

        static void Main(string[] args)
        {
        }
    }
}
