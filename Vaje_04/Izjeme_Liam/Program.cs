using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NajSeIzvede.ignoriraj;

namespace NajSeIzvede
{
    class Program
    {
        static void Main(string[] args)
        {
            Analitik analitik = new Analitik();
            Analiziraj(analitik);
            Console.ReadKey();
        }
        /// <summary>
        /// V spodnjo metodo vstavi ustrezne try-catch bloke, da se bo metoda Preveri izvedla.
        /// </summary>
        /// <param name="analitik"></param>
        static void Analiziraj(Analitik analitik)
        {

            try
            {
                analitik.DobiPodatke();
            }
            catch (System.IO.FileNotFoundException)
            {

                Console.WriteLine("FileNotFoundException");
            }


            analitik.Premisli();

            try
            {
                analitik.Analiziraj();
                analitik.PredebatirajAnalizo();
            }
            catch (ArithmeticException)
            {

                Console.WriteLine("ArithmeticException");
            }

            try
            {
                analitik.ShraniAanalizoVBazo();
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("IndexOutOfRangeException");
            }

            analitik.Zakljuci();

            // Klica te metode ni treba lovit
            analitik.Preveri();
        }
    }
}