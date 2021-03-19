using System;
using System.Collections.Generic;

namespace Min_max_II
{
    class Program
    {
        /// <summary>
        /// Vrne tabelo [najmanjsi, najvecji] element v podani tabeli. Stringe primerja po dolzini.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela"></param>
        /// <returns></returns>
        public static T[] MinMax<T>(T[] tabela) where T : IComparable
        {
            T[] resitev = new T[2] { tabela[0], tabela[0] };
            if(resitev[0].GetType() == typeof(int))
            {
                foreach(T element in tabela)
                {
                    if (element.CompareTo(resitev[1]) > 0)
                    {
                        resitev[1] = element;
                    }
                    if (element.CompareTo(resitev[0]) < 0)
                    {
                        resitev[0] = element;
                    }
                }
            }
            else
            {
                foreach (T el in tabela)
                {
                    string element = (string)(object)el;
                    if (element.Length > ((string)(object)resitev[1]).Length)
                    {
                        resitev[1] = el;
                    }
                    if (element.Length < ((string)(object)resitev[0]).Length)
                    {
                        resitev[0] = el;
                    }
                }
            }

            return resitev;
        }

        static void Main(string[] args)
        {
            int[] test = new int[] { 2, 1, 5, 2, 9, 1, 2, 4, 3, 8, 7, 24, 42 };
            int[] rezultat = MinMax(test);
            Console.WriteLine($"min: {rezultat[0]} max: {rezultat[1]}");

            string[] test_string = new string[] { "burek", "pica", "kebab", "pomfri", "jufka", "strudel", "mongolska", "riba" };
            string[] rezultat_str = MinMax(test_string);
            Console.WriteLine($"min: {rezultat_str[0]} max: {rezultat_str[1]}");
        }
    }
}
