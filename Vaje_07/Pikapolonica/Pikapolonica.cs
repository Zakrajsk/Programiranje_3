using System;

namespace Zivali
{
    public class Pikapolonica
    {
        private int _starost; //v tednih
        private int _stevilo_pik;

        public int Starost
        {
            get { return this._starost; }
            set
            {
                if(value < 0 || value > 250) //50 tednov v letu * 5 ker recmo da je 5 let najvec kar lahko zivi 3 pa povprecje
                {
                    throw new Exception("Starost pikapolonice je nesmiselna!");
                }
                this._starost = value;
            }
        }

        public int SteviloPik
        {
            get { return this._stevilo_pik; }
            set
            {
                if(value < 0 || value > 7)
                {
                    throw new Exception("Stevilo pik je nesmiselno");
                }
                this._stevilo_pik = value;
            }
        }

        public Pikapolonica(int starost, int stevilo_pik)
        {
            this.Starost = starost;
            this.SteviloPik = stevilo_pik;
        }

        public void NastaviSteviloPik(int st_pik)
        {
            this.SteviloPik = st_pik;
        }

        public override string ToString()
        {
            return $"Jaz sem PikaPoka, stara {this.Starost} tednov in imam {this.SteviloPik} pik";
        }

        /// <summary>
        /// Redefiniran * operator. Ne znam za drug ostran da bi lahko mnozili (int * pikapolonica)
        /// </summary>
        /// <param name="mnozitelj"></param>
        /// <param name="mnozenec"></param>
        /// <returns>return Pikapolonica[]</returns>
        public static Pikapolonica[] operator *(Pikapolonica mnozitelj, int mnozenec)
        {
            if(mnozenec < 0)
            {
                throw new Exception("Nesmiselno stevilo");
            }
            Pikapolonica[] tabela_kopij = new Pikapolonica[mnozenec];
            for (int i = 0; i < mnozenec; i++)
            {
                tabela_kopij[i] = new Pikapolonica(mnozitelj.Starost, mnozitelj.SteviloPik);
            }
            return tabela_kopij;
        }

        /// <summary>
        /// Sesteje vse pike na vseh pikapolnicah starejsih od 1 leta
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static int SteviloPikVseh(Pikapolonica[] tabela)
        {
            int vsota = 0;
            foreach (Pikapolonica posamezna in tabela)
            {
                if(posamezna.Starost > 52)
                {
                    vsota += posamezna.SteviloPik;
                }
            }
            return vsota;
        }


        public 
        static void Main(string[] args)
        {
        }
    }
}
