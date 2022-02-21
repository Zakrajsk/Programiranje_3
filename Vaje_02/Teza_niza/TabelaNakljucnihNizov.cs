using System;
using System.Linq;

namespace Teza_niza
{
    class TabelaNakljucnihNizov
    {
        /// <summary>
        /// Generira tabelo nizov, kjer so nizi sestavljeni iz malih črk dolžine med min in max
        /// </summary>
        /// <param name="st_nizov">stevilo generiranih nizov</param>
        /// <param name="min">minimalna dolzina niza</param>
        /// <param name="max">maksimalna dolzina niza</param>
        /// <returns>return string[]</returns>
        public static string[] Generiraj_tabelo_nizev(int st_nizov, int min, int max)
        {
            Random generator = new Random();
            string slovenske_crke = "abcčdefghijklmnoprsštuvzž";

            string[] tabela_nizov = new string[st_nizov];
            for (int i = 0; i < st_nizov; i++)
            {
                int dolzina_niza = generator.Next(min, max + 1);
                string niz = "";
                for (int j = 0; j < dolzina_niza; j++)
                {
                    niz += slovenske_crke[generator.Next(slovenske_crke.Length)];
                }
                tabela_nizov[i] = niz;
            }

            return tabela_nizov;
        }

        /// <summary>
        /// Izpiše dane nize vsakega v svojo vrsto in z dodano zaporedno številko spredaj
        /// </summary>
        /// <param name="nizi">tabela nizov</param>
        public static void Izpisi_nize(string[] nizi)
        {
            for (int i = 0; i < nizi.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {nizi[i]}");
            }
        }

        /// <summary>
        /// Prešteje posamezne črke in nariše histogram pogostosti
        /// </summary>
        /// <param name="nizi">tabela nizov</param>
        public static void Prestej_in_histogram(string[] nizi)
        {
            string slovenske_crke = "abcčdefghijklmnoprsštuvzž";
            int[] st_pojavitev = new int[slovenske_crke.Length];

            for (int i = 0; i < nizi.Length; i++)
            {
                for (int j = 0; j < nizi[i].Length; j++)
                {
                    int index = slovenske_crke.IndexOf(nizi[i][j]);
                    st_pojavitev[index]++;
                }
            }

            //Risanje histograma
            int naj_pojavitev = st_pojavitev.Max();
            for (int i = 0; i < naj_pojavitev; i++)
            {
                for (int j = 0; j < slovenske_crke.Length; j++)
                {
                    Console.Write((st_pojavitev[j] >= naj_pojavitev - i)? "# " : "  ");

                }
                Console.WriteLine("");

            }
            for (int j = 0; j < slovenske_crke.Length; j++)
            {
                Console.Write($"--");
            }
            Console.WriteLine("");
            for (int j = 0; j < slovenske_crke.Length; j++)
            {
                Console.Write($"{slovenske_crke[j]} ");
            }
            
        }
        static void Main(string[] args)
        {
            //za dodajanje šumnikov v conzolo
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Vnesi število nizov: ");
            int st_nizov = int.Parse(Console.ReadLine());

            Console.Write("Vnesi najmanjšo dolžino nizov: ");
            int min_dolzina = int.Parse(Console.ReadLine());

            Console.Write("Vnesi največjo dolžino nizov: ");
            int max_dolzina = int.Parse(Console.ReadLine());

            string[] nizi = Generiraj_tabelo_nizev(st_nizov, min_dolzina, max_dolzina);
            Izpisi_nize(nizi);
            Prestej_in_histogram(nizi);

        }
    }
}
