using System;
using System.Collections.Generic;

namespace Kattis_Judging_Troubles
{
    class JudgingTroubles
    {
        static void Main(string[] args)
        {
            int st_vnosov = int.Parse(Console.ReadLine());
            Dictionary<string, int> slovar_resitev = new Dictionary<string, int>();
            for (int i = 0; i < st_vnosov * 2; i++)
            {
                string vnos = Console.ReadLine();
                //V primeru, da smo na prvi polovici vnosov bomo pristeli 1 za vsako pojavitev
                //Ko pa smo v drugi polovici pa odstevamo, saj tako dobimo v koliko primerih se razlikujejo
                if (slovar_resitev.ContainsKey(vnos))
                {
                    slovar_resitev[vnos] += i < st_vnosov ? 1 : -1;
                }
                else
                {
                    slovar_resitev[vnos] = i < st_vnosov? 1 : -1;
                }
            }

            int koliko_razlicnih = 0;
            foreach(int stevilo in slovar_resitev.Values)
            {
                //Pozorni moramo biti saj smo na drugi polovici odstevali vsak primer in ce se je nek niz prvic pojavil v drughi polovici ga stejemo v negativno
                koliko_razlicnih += stevilo > 0 ? stevilo : stevilo * (-1);
            }

            //Izpisemo koliko vnosov je bilo razlicnih
            Console.WriteLine(st_vnosov - (koliko_razlicnih / 2));
        }
    }
}
