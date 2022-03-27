using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTo_Switch_Anze
{
    class GoToSwitch
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Povprasuj();
        }
        /// <summary>
        /// Metoda v nedogled izpisuje naključne intervale ter sprašuje uporabnika naj izbere enega izmed njih.
        /// V primeru napačnih podatkov ponovno povpraša za iste intervale.
        /// </summary>
        static void Povprasuj()
        {
        zacetek:
            Console.WriteLine("Izberi med intervali:");
            List<int[]> intervali = GenerirajIntervale(5);
            IzpisiIntervale(intervali);
            Console.Write("Izberi: ");
        izberi:
            try
            {
                int vhod = int.Parse(Console.ReadLine());
                switch (vhod)
                {
                    case 1:
                        int[] interval = intervali[0];
                        IzpisiOdDo(interval);
                        break;
                    case 2:
                        int[] interval1 = intervali[1];
                        IzpisiOdDo(interval1);
                        break;
                    case 3:
                        int[] interval2 = intervali[2];
                        IzpisiOdDo(interval2);
                        break;
                    case 4:
                        int[] interval3 = intervali[3];
                        IzpisiOdDo(interval3);
                        break;
                    case 5:
                        int[] interval4 = intervali[4];
                        IzpisiOdDo(interval4);
                        break;
                    default:
                        throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Napačen vhod! Izberi še enkrat: ");
                goto izberi;
            }

            goto zacetek;
        }
        /// <summary>
        /// Metoda izpiše števila od - do določena z intervalom.
        /// </summary>
        /// <param name="interval"> Seznam dveh števil [int od, int do] </param>
        static void IzpisiOdDo(int[] interval)
        {
            for (int i = interval[0]; i < interval[1] + 1; i++)
            {
                Console.Write($"{i} ");
            }
        }
        /// <summary>
        /// Metoda izpiše podane intervale ter jih oštevilči.
        /// </summary>
        /// <param name="seznam"> Seznam intervalov </param>
        static void IzpisiIntervale(List<int[]> seznam)
        {
            int stevec = 1;
            foreach (int[] item in seznam)
            {
                Console.WriteLine($"{stevec}) [{item[0]}, {item[1]}]");
                stevec++;
            }
        }
        /// <summary>
        /// Metoda zgenerira število naključnih intervalov.
        /// </summary>
        /// <param name="stIntervalov"> Število intervalov za zgenerirat. </param>
        /// <returns></returns>
        static List<int[]> GenerirajIntervale(int stIntervalov)
        {
            List<int[]> seznam = new List<int[]>();
            for (int i = 0; i < stIntervalov; i++)
            {
                seznam.Add(GenerirajInterval());
            }
            return seznam;
        }
        /// <summary>
        /// Metoda zgenerira en veljaven interval med možnimi intervali od 1 do 100.
        /// </summary>
        /// <returns></returns>
        static int[] GenerirajInterval()
        {
            int spodnji = rnd.Next(1, 99);
            int zgornji = rnd.Next(spodnji, 100);
            return new int[] { spodnji, zgornji };
        }

    }
}
