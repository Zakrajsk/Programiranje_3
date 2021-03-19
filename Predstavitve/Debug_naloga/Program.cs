using System;

namespace NalogeZaDebug
{
    class Popravi
    {
        // Spodnja funkcija ima nalogo prešteti vse možne poti v matriki,
        // pri pogojih, da se lahko premikamo zgolj desno / dol / diagonalno. 
        // Sintaktičnih napak v programu ni, toda nekaj ne dela prav.
        // Popravi tako, da bo program delal pravilno in poskrbi, da program vrne
        // celotno matriko, tako da vemo do vsake pozicije na koliko načinov se da priti.
        public static int Prestej(int[,] matrika, int n)
        {
            for (int i = 1; i < n; ++i)
            {
                for (int j = 1; j < n; ++j)
                {
                    matrika[i, j] = matrika[i - 1, j] + matrika[i, j - 1] + matrika[i - 1, j - 1];
                }
            }
            int stevilo = matrika[n - 1, n - 1];
            return stevilo;
        }

        public static int[,] GenMatriko(int n)
        {
            int[,] matrika = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                matrika[0, i] = 1;
                matrika[i, 0] = 1;
            }
            return matrika;
        }
        public static void Main(String[] args)
        {
            Console.Write("Vpiši velikost matrike: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrika = GenMatriko(n);
            Console.WriteLine(Prestej(matrika, n));

        }
    }
}
