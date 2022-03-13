using System;
using System.Collections.Generic;

namespace Prozenje_napak_IV
{
    class ProzenjeNapakIV
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sez"></param>
        public static int[] OdstraniNajmanjse(string[] sez)
        {
            if(sez.Length == 0)
            {
                throw new ArgumentException("Tabela je prazna");
            }

            List<int> tabelaBrez = new List<int>();
            int najmanjsi = Int32.MaxValue;
            bool jeNapaka = false;
            for (int i = 0; i < sez.Length; i++)
            {
                try
                {
                    int st = int.Parse(sez[i]);
                    tabelaBrez.Add(st);
                    najmanjsi = Math.Min(najmanjsi, st);
                }
                catch (Exception)
                {
                    jeNapaka = true;
                }
            }
            while (tabelaBrez.Remove(najmanjsi));
            if (jeNapaka)
            {
                Console.WriteLine("Pojavili so se problematicni elementi");
            }
            tabelaBrez.ForEach(el => Console.Write(el + " "));
            Console.WriteLine("");

            return tabelaBrez.ToArray();
        }

        static void Main(string[] args)
        {
            string[] testna1 = { "22", "1", "34", "liam", "1" };
            OdstraniNajmanjse(testna1);

            string[] testna2 = { "liam", "1"};
            OdstraniNajmanjse(testna2);

            string[] testna3 = { "1", "1", "1", "1", "1" };
            OdstraniNajmanjse(testna3);
        }
    }
}
