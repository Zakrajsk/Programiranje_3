using System;

namespace Prozenje_napak_III
{
    class ProzenjeNapakIII
    {
        /// <summary>
        /// Vrne tabelo dveh ničelj kvadratne funcije ax^2 + bx + c ali pa ustrezno izjemo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double[] NicleKvEnacbe(double a, double b, double c)
        {
            if(a == 0)
            {
                throw new Exception("Ni resitve");
            }

            double D = Math.Pow(b, 2) - 4 * a * c;
            if(D < 0)
            {
                throw new Exception("Funkcija ima kompleksne ničle");
            }

            double[] resitev = new double[] { (-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a) };
            return resitev;

        }
        static void Main(string[] args)
        {
            double[] res = NicleKvEnacbe(1, 1, -1);
            Console.WriteLine($"x1 = {res[0]}, x2 = {res[1]}");
        }
    }
}
