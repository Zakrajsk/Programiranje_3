using System;

namespace N1
{
    public class Program
    {
        public static int DruzabneStevke(string niz)
        {
            int st_druzabnih = 0;

            for(int i = 0; i < niz.Length; i++)
            {
                bool je_stevka = int.TryParse(niz[i].ToString(), out _);
                if (!je_stevka)
                {
                    continue;
                }
                bool predhodna = false;
                bool naslednja = false;
                if(i > 0)
                {
                    predhodna = int.TryParse(niz[i - 1].ToString(), out _);
                }
                if(i < niz.Length - 1)
                {
                    naslednja = int.TryParse(niz[i + 1].ToString(), out _);
                }
                if(predhodna || naslednja)
                {
                    st_druzabnih++;
                }
            }
            return st_druzabnih;
        }


        static void Main(string[] args)
        {
        }
    }
}
