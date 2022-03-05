using System;

namespace Knjiznica
{
    class Knjiznica
    {
        /// <summary>
        /// Podano tabelo spremeni tako, da je sedaj dvojne velikosti in pri tem ohrani obstoječe elemente.
        /// </summary>
        /// <param name="tabela"></param>
        public static void PodvojiVelikost(ref int[] tabela)
        {
            int[] nova_tabela = new int[tabela.Length * 2];
            for (int i = 0; i < tabela.Length; i++)
            {
                nova_tabela[i] = tabela[i];
            }
            tabela = nova_tabela;

        }
        /// <summary>
        /// Vrne tabelo dolzine dolzina v katerih so stevila od 1 do max_meja
        /// </summary>
        /// <param name="dolzina"></param>
        /// <param name="max_meja"></param>
        /// <returns>return int[]</returns>
        public static int[] NakljucnaTabela(int dolzina, int max_meja)
        {
            Random ran_gen = new Random();
            int[] tabela = new int[dolzina];

            for (int i = 0; i < dolzina; i++)
            {
                tabela[i] = ran_gen.Next(max_meja) + 1;
            }

            return tabela;

        }

        /// <summary>
        /// Vrne niz, ki predstavlja kako izgleda tabela loceno z presledki
        /// </summary>
        /// <param name="tabela"></param>
        /// <returns>return string</returns>
        public static string TabelaKotNiz(int[] tabela)
        {
            return string.Join(' ', tabela);
        }

        /// <summary>
        /// Iz niza zgenerira tabelo integerjev
        /// </summary>
        /// <param name="niz"></param>
        /// <returns>return int[]</returns>
        public static int[] NizKotTabela(string niz)
        {
            string[] tabela_nizov = niz.Split(' ');
            int n = tabela_nizov.Length;
            int[] koncna_tabela = new int[n];
            for (int i = 0; i < n; i++)
            {
                koncna_tabela[i] = int.Parse(tabela_nizov[i]);
            }
            return koncna_tabela;
        }


        static void Main(string[] args)
        {
            int[] testna = NakljucnaTabela(10, 5);


            Console.WriteLine("Tabela spremenjena v niz: " + TabelaKotNiz(testna));

            Console.Write("Tabela zgenerirana iz niza: ");
            string testen_niz = "5 2 1 5 2 9 2 4 5";
            int[] gen_tabela = NizKotTabela(testen_niz);
            foreach (int en in gen_tabela)
            {
                Console.Write(en + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Dolzina originalne tabele " + testna.Length + " in celotni izpis: " + TabelaKotNiz(testna));
            Knjiznica.PodvojiVelikost(ref testna);
            Console.WriteLine("Dolzina tabele po metodi PodvojiVelikost " + testna.Length + " in celotni izpis: " + TabelaKotNiz(testna));

        }
    }
}
