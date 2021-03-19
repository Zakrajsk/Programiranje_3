//Link: https://open.kattis.com/problems/alphabetspam

using System;

namespace Kattis_Alphabet_spam
{
    class Program
    {
        static void Main(string[] args)
        {
            string niz = Console.ReadLine();

            int presledki = 0, male = 0, velike = 0, znaki = 0;
            double dolzina = niz.Length;

            for (int i = 0; i < dolzina; i++)
            {
                if (niz[i] == '_')
                {
                    presledki++;
                    continue;
                }
                if (char.IsLower(niz[i]))
                {
                    male++;
                    continue;
                }
                if (char.IsUpper(niz[i]))
                {
                    velike++;
                    continue;
                }
                znaki++;
            }

            Console.WriteLine(presledki / dolzina);
            Console.WriteLine(male / dolzina);
            Console.WriteLine(velike / dolzina);
            Console.WriteLine(znaki / dolzina);
        }
    }
}
