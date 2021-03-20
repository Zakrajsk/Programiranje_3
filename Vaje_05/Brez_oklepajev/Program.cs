using System;
using System.IO;
using System.Text;

namespace Brez_oklepajev
{
    class Program
    {
        /// <summary>
        /// Metoda iz vhodne datoteke prebera vrstice in jih zapisuje v izhodno pri tem spusti vse, kar je v napisano v oklepajih
        /// Ce so oklepaji narobe postavljeni v to vrsto napise NAPAKA
        /// </summary>
        /// <param name="imeVhod"></param>
        /// <param name="imeIzhod"></param>
        public static void BrezOklepajev(string imeVhod, string imeIzhod)
        {
            StreamReader branje;
            try
            {
                branje = new StreamReader(imeVhod);
            }
            catch (Exception)
            {
                throw new Exception("Datoteke za branje ni mogoče najti!");
            }

            StreamWriter pisanje = File.CreateText(imeIzhod);

            string vrstica = branje.ReadLine();
            while(vrstica != null)
            {
                bool najden_oklepaj = false;
                bool najden_zaklepaj = false;
                StringBuilder nova_vrsta = new StringBuilder();
                foreach(char znak in vrstica)
                {
                    if(znak == ')')
                    {
                        najden_zaklepaj = true;
                        if (najden_oklepaj)
                        {
                            continue;
                        }
                        else
                        {
                            //zaklepaj je pred oklepajem
                            break;
                        }
                    }
                    if(znak == '(')
                    {
                        najden_oklepaj = true;
                        continue;
                    }
                    if (!najden_oklepaj || (najden_oklepaj && najden_zaklepaj)) // ce smo pred oklepajem ali pa za obema
                    {
                        nova_vrsta.Append(znak);
                    }
                }
                if((najden_oklepaj && najden_zaklepaj) || (!najden_oklepaj && !najden_zaklepaj))
                {
                    pisanje.WriteLine(nova_vrsta);
                }
                else
                {
                    pisanje.WriteLine("NAPAKA");
                }
                vrstica = branje.ReadLine();
                
            }

            branje.Close();
            pisanje.Close();
        }
        static void Main(string[] args)
        {
            string branje = @"..\..\..\vnos1.txt";
            string pisanje = @"..\..\..\resitev1.txt";
            BrezOklepajev(branje, pisanje);

            try
            {
                branje = @"..\..\..\vnos2.txt";
                pisanje = @"..\..\..\resitev2.txt";
                BrezOklepajev(branje, pisanje);
            }
            catch (Exception e)
            {
                Console.WriteLine("Drugi primer vrne napako: " + e);
            }

        }
    }
}
