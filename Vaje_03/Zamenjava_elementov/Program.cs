using System;

namespace Zamenjava_elementov
{
    class Program
    {
        static int[] Kopija(int[] t)
        {
            int[] kopija = new int[t.Length];
            t.CopyTo(kopija, 0);
            return kopija;
        }

        static void Izpisi(string ime, int[] t)
        {
            Console.Write(ime + ": " );
            foreach (int stevilo in t)
            {
                Console.Write(stevilo + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = Kopija(a);
            Console.WriteLine("Prej: ");
            Izpisi("a", a);
            Izpisi("b", b);
            a[1] = b[2];
            a[2] = b[1];
            Console.WriteLine("Potem: ");
            Izpisi("a", a);
            Izpisi("b", b);
        }
    }
}
