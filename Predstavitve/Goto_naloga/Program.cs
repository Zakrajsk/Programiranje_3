using System;

namespace Goto_naloga
{
    class Program
    {
         static void CudnaKoda2()
        {

            int i = 2;
            int j = 4;
            goto Značka1;
            Značka3:
                i--;
                if(i == 0)
                {
                    goto Značka2;
                }
            Značka1:
                Console.WriteLine("i je: " + i);
            Značka4:

                if(j > 0)
                {
                    j--;
                    Console.WriteLine("j je: " + j);
                    goto Značka4;
                }
                else
                {
                    goto Značka3;
                }
                
            Značka2:
                Console.WriteLine("Konec");
        }

        public static void PopravekCudneKode()
        {

            int i = 2;
            int j = 4;

            while(i > 0)
            {
                Console.WriteLine("i je: " + i);
                while (j > 0)
                {
                    j--;
                    Console.WriteLine("j je: " + j);
                }
                i--;
            }
            Console.WriteLine("Konec");

        }

        public static void WC()
        {
            bool zaklenjena_vrata = true;
            KajNaredi:
            string vnos = Console.ReadLine();

            if(vnos == "kovanec")
            {
                Console.WriteLine("Hvala za plačilo, vrata so sedaj odklenjena");
                zaklenjena_vrata = false;
                goto KajNaredi;
            }

            if(vnos == "porini")
            {
                if(zaklenjena_vrata)
                {
                    Console.WriteLine("OJ najprej moraš plačati");
                    goto KajNaredi;
                }
                else
                {
                    Console.WriteLine("Človek je vstopil in vrata so ponovno zaklenjena");
                    zaklenjena_vrata = true;
                    goto KajNaredi;
                }
            }
            
            Console.WriteLine("Želim vam lep dan");
        }
        static void Main(string[] args)
        {
            CudnaKoda2();
            Console.WriteLine("--------------------------");
            PopravekCudneKode();

            WC();
        }
    }
}
