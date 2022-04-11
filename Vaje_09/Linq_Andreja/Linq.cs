using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Andreja
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sadje = { "banana", "ananas", "pomaračna", "kivi", "jabolko", "hruška", "mandarina", " mango", "jagoda", "ribez" };
            int[] stevila = { 2, 4, 3, 24, 6, 74, 132, 6545, 23, 87, 231, 2, 22, 98, 70, 21 };

            // Izpiši vse tiste besede v tabeli sadje, ki imajo več kot dva a-ja, jih uredu po prvi črki besede ter nato še po velikosti od najkrajše do najdaljše
            Console.WriteLine("---------------------------------------------------------");
            var poizvedba = from el in sadje
                            where el.Split('a').Length - 1 > 2
                            orderby el[0], el.Length
                            select el;

            foreach (string el in poizvedba)
            {
                Console.WriteLine(el);
            }

            // izpiši katera števila iz tabele števila pri deljuenju z številom 3 dajo ostanek 0,1 in 2
            var poizvedba2 = from el in stevila
                        group el by el % 3 into grupe
                        select grupe;

            Console.WriteLine("---------------------------------------------------------");
            foreach (var kljuc in poizvedba2)
            {
                Console.WriteLine($"Kljuc: {kljuc.Key}");
                foreach (int el in kljuc)
                {
                    Console.WriteLine(el);
                }
            }

            Console.WriteLine("---------------------------------------------------------");
            // izpiši vsoto števil it tabele stevil, ki pri deljenju s 5 dajo ostanek 1,2,3,4
            var poizvedba3 = from el in stevila
                             group el by el % 5 into grupe
                             select grupe;

            Console.WriteLine("---------------------------------------------------------");
            foreach (var kljuc in poizvedba3)
            {
                Console.WriteLine($"Kljuc: {kljuc.Key}");
                foreach (int el in kljuc)
                {
                    Console.WriteLine(el);
                }
            }

            Console.WriteLine("---------------------------------------------------------");
            // Izpiši vsa tista prva števila v tabeli števil, ki so manjša od 100
            Console.WriteLine(string.Join(" ", stevila.TakeWhile(el => el < 100)));   

            // Elemente v tabeli sadje izpiši kot niz, ki ima elemente tabele ločene z vejico.

        }
    }
}
