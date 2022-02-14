//Link: https://open.kattis.com/problems/aboveaverage

using System;

namespace Kattis_Above_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int stevilo_primerov = int.Parse(Console.ReadLine());
            for (int i = 0; i < stevilo_primerov; i++)
            {
                string[] podatki = Console.ReadLine().Split(' ');

                int st_studentov = int.Parse(podatki[0]);
                int vsota_ocen = 0;
                for (int j = 1; j <= st_studentov; j++)
                {
                    vsota_ocen += int.Parse(podatki[j]);
                }
                double povprecje = (double)vsota_ocen / st_studentov;
                int st_nadpovprecnih = 0;

                for (int j = 1; j <= st_studentov; j++)
                {
                    if (int.Parse(podatki[j]) > povprecje)
                    {
                        st_nadpovprecnih++;
                    }
                }

                double odstotek_nadpovprecnih = (double)st_nadpovprecnih / st_studentov;
                //String format poskrbi, ce se pojavi premalo decimalk, da jih nadomesti z 0, saj naloga tako zahteva v kattisu
                Console.WriteLine($"{String.Format("{0:0.000}", Math.Round(odstotek_nadpovprecnih * 100, 3))}%");
            }
        }
    }
}
