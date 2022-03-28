using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger_Ziga
{
    class Debug
    {
        public static void Main(String[] args)
        {
            List<Rezultat> rezultat = spremembe("morje", "poletje");
            foreach (Rezultat elt in rezultat)
            {
                Console.WriteLine(elt.niz + " blaa " + elt.koliko);
            }
        }
        /// <summary>
        /// za lažji izpis rezultata
        /// </summary>
        public class Rezultat
        {
            public string niz;
            public double koliko;
            public Rezultat(string niz, int koliko)
            {
                this.niz = niz;
                this.koliko = koliko;
            }
        }
        public static int[,] GenMatriko(int n, int m)
        {
            int[,] matrika = new int[n + 1, m + 1];
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < m + 1; j++)
                {
                    matrika[0, j] = j;
                    matrika[i, 0] = i;
                }
            }
            return matrika;
        }
        /// <summary>
        /// Vrne minimalne spremembe med nizoma a in b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static List<Rezultat> spremembe(string a, string b)
        {
            int n = a.Length;
            int m = b.Length;
            int[,] c = GenMatriko(n, m);
            for (int k = 1; k < n; k++)
            {
                for (int h = 1; h < m; h++)
                {
                    int zapomni = c[k - 1, h - 1];
                    if (a[k - 1] != b[h - 1])
                    {
                        zapomni++;
                    }
                    if (c[k, h - 1] + 1 < zapomni)
                    {
                        zapomni = c[k, h - 1] + 1;
                    }
                    if (c[k - 1, h] + 1 < zapomni)
                    {
                        zapomni = c[k - 1, h] + 1;
                    }
                    c[k, h] = zapomni;
                }

            }
            int i = n;
            int j = m;
            List<Rezultat> seznam = new List<Rezultat>();
            while (i > 0 || j > 0)
            {
                if (i > 0 && c[i, j] > c[i - 1, j])
                {
                    seznam.Add(new Rezultat("-" + a[i - 1], j + 1));
                    i--;
                }
                else if (j > 0 && c[i, j] > c[i, j - 1])
                {
                    seznam.Add(new Rezultat("+" + b[j - 1], j));
                    j--;
                }
                else
                {
                    if (c[i, j] > c[i - 1, j - 1])
                    {
                        seznam.Add(new Rezultat(b[j - 1] + "/" + a[i - 1], j));
                    }
                    i--;
                    j--;
                }
            }
            seznam.Reverse();
            return seznam;
        }
    }
}
