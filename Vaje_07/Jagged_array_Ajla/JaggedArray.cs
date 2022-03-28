using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_array_Ajla
{
    class JaggedArray
    {
        static void Main(string[] args)
        {

            //S pomočjo zank izpiši naslednjo tabelo po vrsticah, ter nato določi največje število v glavni tabeli.
            //Preštej, koliko je vseh elementov v spodnji tabeli.

            int[][] tabela = new int[4][];

            tabela[0] = new int[7] { 14, 25, 163, 44, 89, 334, 414 };
            tabela[1] = new int[5] { 22, 57, 77, 86, 23 };
            tabela[2] = new int[4] { 345, 56, 442, 135 };
            tabela[3] = new int[6] { 263, 144, 88, 55, 265, 248 };

            for (int i = 0; i < tabela.Length; i++)
            {
                Console.WriteLine(string.Join(" ", tabela[i]));
            }

            int najvecje = 0;
            int vseh = 0;
            for (int i = 0; i < tabela.Length; i++)
            {
                for (int j = 0; j < tabela[i].Length; j++)
                {
                    najvecje = Math.Max(tabela[i][j], najvecje);
                    vseh++;
                }
            }
            Console.WriteLine($"Najvecje stevilo: {najvecje}. Stevilo vseh elementov: {vseh}");

            

        }
    }
}
