//Link: https://open.kattis.com/problems/aaah

using System;

namespace Kattis_Aaah
{
    class Program
    {
        static void Main(string[] args)
        {
            string zmore = Console.ReadLine();
            string zahtevano = Console.ReadLine();

            if (zmore.Length >= zahtevano.Length)
                Console.WriteLine("go");
            else
                Console.WriteLine("no");

        }
    }
}
