//Link: https://open.kattis.com/problems/r2

using System;

namespace Kattis_R2
{
    class Program
    {
        static void Main(string[] args)
        {
            string niz = Console.ReadLine();
            string[] stevili = niz.Split(" ");
            int prvo = Convert.ToInt32(stevili[0]);
            int drugo = Convert.ToInt32(stevili[1]);

            Console.WriteLine(drugo * 2 - prvo);

        }
    }
}
