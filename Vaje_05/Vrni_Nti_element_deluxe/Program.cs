using System;
using System.Collections.Generic;

namespace Vrni_Nti_element_deluxe
{
    class Program
    {

        /// <summary>
        /// Genericna metoda, ki vrne n-ti element v tabeli. Zacnemo šteti od 1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela"></param>
        /// <param name="n"></param>
        /// <returns>return T</returns>
        public static T VrniNtiElement<T>(T[] tabela, int n)
        {
            if(n < 0)
            {
                n = n + tabela.Length + 1;
            }
            try
            {
                return tabela[n - 1];
            }
            catch (Exception)
            {
                throw new Exception($"{n}. elementa ni v tabeli");
            }

        }
        static void Main(string[] args)
        {
            string[] blebetanje = { "bla", "blo", "bli" };
            
            string niz1 = VrniNtiElement(blebetanje, 2); // dobimo "blo"
            Console.WriteLine(niz1);
            string niz2 = VrniNtiElement(blebetanje, -3); // dobimo "bla"
            Console.WriteLine(niz2);

            try
            {
                string niz3 = VrniNtiElement(blebetanje, -4); // sproži seizjema
            }
            catch (Exception e)
            {
                Console.WriteLine("Pri VrniNtiElement(blebetanje, 2) se sprozi izjema: " + e);
            }

            int[] tja = { 10, 20, 30 };

            int tam = VrniNtiElement(tja, 1); // dobimo 10
            Console.WriteLine(tam);

            try
            {
                int tu = VrniNtiElement(tja, 0); // sproži se izjema
            }
            catch (Exception e)
            {
                Console.WriteLine("Pri VrniNtiElement(tja, 0) se sprozi izjema: " + e);
            }

            try
            {
                int tuk = VrniNtiElement(tja, 4); // sproži se izjema
            }
            catch (Exception e)
            {
                Console.WriteLine("Pri VrniNtiElement(tja, 4) se sprozi izjema:" + e);
            }
        }
    }
}
