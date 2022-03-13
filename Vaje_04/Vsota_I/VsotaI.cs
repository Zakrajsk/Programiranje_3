using System;
using System.Collections.Generic;

namespace VsotaI
{
    class VsotaI
    {
        public static int Sestej(int a, int b)
        {
            return a + b;
        }

        public static string Sestej(string a, string b)
        {
            return a + b;
        }

        /// <summary>
        /// sesteje tabelo, v primeru int ali double je to vsota vseh pri nizih pa jih zlepi skupaj
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela"></param>
        /// <returns></returns>
        public static T Sestej_neki<T>(T[] tabela)
        {
            T vsota = tabela[0];

            for (int i = 1; i < tabela.Length; i++)
            {
                if (vsota.GetType() == typeof(int))
                {
                    int x = (int)(object)tabela[i];
                    int y = (int)(object)vsota;
                    vsota = (T)(object)Sestej(x, y);
                }
                if (vsota.GetType() == typeof(string))
                {
                    string x = (string)(object)tabela[i];
                    string y = (string)(object)vsota;
                    vsota = (T)(object)Sestej(y, x);
                }
            }
            return vsota;
        }

        static void Main(string[] args)
        {
            int[] tabela = new int[] { 1, 4, 5, 2, 1, 9 };
            string[] tabela_nizov = new string[] { "lala", "lele", "lili" };
            Console.WriteLine(Sestej_neki(tabela));
            Console.WriteLine(Sestej_neki(tabela_nizov));
        }
    }
}
