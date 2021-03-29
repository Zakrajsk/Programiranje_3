using System;
using System.Collections.Generic;
using Vozila;

namespace Kosara
{
    public class Kosarica<T>
    {
        private T _podatek;

        public Kosarica(T podatek)
        {
            this.podatek = podatek;
        }

        public T podatek
        {
            get { return this._podatek; }
            set { this._podatek = value; }
        }

        public override string ToString()
        {
            return this._podatek.ToString();
        }

    }
    class Testiranje
    {
        static void Main(string[] args)
        {
            string tests = "niz";
            Kosarica<string> teststring = new Kosarica<string>(tests);
            Console.WriteLine(teststring);

            int testi = 5;
            Kosarica<int> testint = new Kosarica<int>(testi);
            Console.WriteLine(testint);


            //Pravilnost izpisa pri lastnih razredij je odvisna ali smo implementirali oziroma prepisali metodo ToString()
            Vozilo testv = new Vozilo(50.6, 5.2);
            Kosarica<Vozilo> testvozilo = new Kosarica<Vozilo>(testv);
            Console.WriteLine(testvozilo);


            double testd = 5.7;
            Kosarica<double> testdouble = new Kosarica<double>(testd);
            Console.WriteLine(testdouble);


            //Pri tem se pojavijo težave, saj to string na tabeli celih stevil ne vrne izpisa tabele ampak nekaj drugega
            int[] testit = new int[] { 4, 2, 4, 2 };
            Kosarica<int[]> testinttab = new Kosarica<int[]>(testit);
            Console.WriteLine(testinttab);
        }
    }
}
