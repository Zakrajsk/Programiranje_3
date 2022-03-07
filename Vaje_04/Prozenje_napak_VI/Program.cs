using System;
using System.Linq;

namespace Prozenje_napak_VI
{
    class Program
    {
        public static bool PermutacijaPravilna(string[] vneseni,int n)
        {
            bool[] vsebovani = new bool[n];
            for (int i = 0; i < vneseni.Length; i++)
            {

                try
                {
                    int mesto = int.Parse(vneseni[i]) - 1;
                    if (vsebovani[mesto] == true)
                    {
                        return false;
                    }
                    vsebovani[mesto] = true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

            return Enumerable.Min(vsebovani);
        }

        static void Main(string[] args)
        {
            Console.Write("Vnesi n: ");
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                string vnos = Console.ReadLine();
                string[] permutacija = vnos.Split(" ");
                
                if (PermutacijaPravilna(permutacija, n))
                {
                    Console.WriteLine("Bravo to je permutacija: " + vnos);
                    break;
                }
                else
                {
                    Console.WriteLine("NISI VNESEL PERMUTACIJE");
                }
            }
        }
    }
}
