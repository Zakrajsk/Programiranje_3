using System;

namespace Viva_la_difference
{
    class Program
    {
        /// <summary>
        /// Prebere dve stevili ki morata biti nenegativni in vrne njuno razliko
        /// v nasprotnih primerih sprozi izjeme
        /// </summary>
        /// <returns>return double</returns>
        public static double Odstevanje()
        {
            double zman, ods;
            try
            {
                Console.Write("Zmanjševanec: ");
                zman = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new Exception("Zmanjševanec mora biti realno število!");
            }

            if(zman < 0)
            {
                throw new Exception("Zmanjševanec mora biti nenegativno število!");
            }

            try
            {
                Console.Write("Odštevanec: ");
                ods = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new Exception("Odštevanec mora biti realno število!");
            }

            if (ods < 0)
            {
                throw new Exception("Odštevanec mora biti nenegativno število!");
            }

            if (ods > zman)
            {
                throw new Exception("Odštevanec mora biti manjši od zmanjševanca!");
            }

            return zman - ods;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Odstevanje());
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
