//Link: https://open.kattis.com/problems/abc

using System;

namespace Kattis_ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            string stevila = Console.ReadLine();
            char[] crke = Console.ReadLine().ToCharArray();

            int[] tab_stevil = Array.ConvertAll(stevila.Split(' '), int.Parse);
            
            Array.Sort(tab_stevil);

            string rezultat = "";
            for (int i = 0; i < 3; i++)
            {
                switch (crke[i])
                {
                    case 'A': rezultat += tab_stevil[0]; break;
                    case 'B': rezultat += tab_stevil[1]; break;
                    case 'C': rezultat += tab_stevil[2]; break;

                }

                if (i != 2)
                {
                    rezultat += " ";
                }
            }
            Console.WriteLine(rezultat);
        }
    }
}
