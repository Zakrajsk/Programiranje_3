using System;

namespace Piton_na_obisku
{
    class Piton_na_obisku
    {
        /// <summary>
        /// Funckija vrne vsoto števil od 1 do n, ki so potencirana z k
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns>double vsota</returns>
        public static double Nekaj(int n, int k)
        {
            double vsota = 0;

            for (int i = 1; i <= n; i++)
            {
                vsota += Math.Pow(i, k);
            }

            return vsota;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi n in k locena z presledkom!");
            string[] podatka = Console.ReadLine().Split(' ');
            int n = int.Parse(podatka[0]);
            int k = int.Parse(podatka[1]);

            double rezultat = Nekaj(n, k);

            Console.WriteLine(rezultat);
            


        }
    }
}
