using System;

namespace Vozila
{
    public class Vozilo : IComparable<Vozilo>
    {
        private static int koliko_obstojeci = 0;
        private int zaporedna_st;
        private double gorivo; //litri
        private double kapaciteta; //litri
        private double poraba;  //litri na 100 km

        public Vozilo(double kapaciteta, double poraba)
        {
            if (kapaciteta < 0)
            {
                throw new Exception("Kapaciteta ne more biti negativna!");
            }

            if (poraba <= 0 || poraba > kapaciteta)
            {
                throw new Exception("Podana je nesmiselna poraba vozila");
            }

            this.gorivo = kapaciteta;
            this.kapaciteta = kapaciteta;
            this.poraba = poraba;

            koliko_obstojeci++;
            this.zaporedna_st = koliko_obstojeci;

        }

        public double Kapaciteta
        {
            get { return this.kapaciteta; }
        }

        public double Poraba
        {
            get { return this.poraba; }
        }

        public override string ToString()
        {
            return $"{this.zaporedna_st} : Avto z kapaciteto tanka: {Math.Round(this.kapaciteta, 3)}l ima še {Math.Round(this.gorivo, 2)}l goriva njegova poraba je {Math.Round(this.poraba, 3)}l/100km";
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
                if (pot < 0)
                {
                    throw new Exception("Pot ne more biti negativna");
                }

                if (pot == 0)
                {
                    if (trenutno == this.kapaciteta)
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
        public int CompareTo(Vozilo primerjani)
        {
            if (this.kapaciteta.CompareTo(primerjani.kapaciteta) == 0)
            {
                return this.zaporedna_st - primerjani.zaporedna_st;
            }
            return this.kapaciteta.CompareTo(primerjani.kapaciteta);
        }
    }
}
