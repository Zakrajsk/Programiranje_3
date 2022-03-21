using System;
using System.Collections.Generic;

namespace Vrni_Nti_element_deluxe
{
    public class VrniNtiElementDeluxe
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
                throw new IndexOutOfRangeException($"{n}. elementa ni v tabeli");
            }

        }
        static void Main(string[] args)
        {

        }
    }
}
