using System;

namespace Album
{
    class Program
    {
 
        /// <summary>
        /// Vrne vse vrednosti v tabeli na false
        /// </summary>
        /// <param name="album"></param>
        public static void Ponastavi_album(bool[] album)
        {
            for(int i = 0; i < album.Length; i++)
            {
                album[i] = false;
            }
        }

        /// <summary>
        /// Pogleda, ali je ta vrednost ze v tabeli, pri tem pogleda samo zapolnjen del da se izognemo problemov z 0
        /// </summary>
        /// <param name="tabela"></param>
        /// <param name="vrednost"></param>
        /// <param name="do_kje"></param>
        /// <returns></returns>
        public static bool Je_v_tabeli(int[] tabela, int vrednost, int do_kje)
        {
            for(int i = tabela.Length - 1; i > do_kje; i--)
            {
                if (tabela[i] == vrednost)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Generira tabelo, ki predstavlja en pokec kjer so notri same razlicne slicice
        /// </summary>
        /// <param name="velikost"></param>
        /// <param name="st_slicic></param>
        /// <returns>return int[]</returns>
        public static int[] Generiraj_pokec(int velikost, int st_slicic)
        {
            int[] pokec = new int[velikost];
            Random nakljucna = new Random();
            while(velikost > 0)
            {
                int nova = nakljucna.Next(st_slicic);
                if (!Je_v_tabeli(pokec, nova, velikost))
                {
                    pokec[velikost - 1] = nova;
                    velikost--;
                }
            }
            return pokec;
        }

        /// <summary>
        /// V album nalepi mankajoce slicice in vrne koliko smo jih naleple
        /// </summary>
        /// <param name="pokec"></param>
        /// <param name="album"></param>
        /// <returns></returns>
        public static int Koliko_nalepimo(int[] pokec, bool[] album)
        {
            int nalepljeni = 0;

            foreach (int stevilka in pokec)
            {
                if (!album[stevilka])
                {
                    nalepljeni++;
                    album[stevilka] = true;
                }
            }
            return nalepljeni;
        }

        /// <summary>
        /// Simulira polnjenje albuma 1000 za izracun povprecja koliko pokcev slicic potrebujemo za zapolnitev
        /// </summary>
        /// <param name="koliko_v_paketu"></param>
        /// <param name="st_slicic"></param>
        /// <returns>return int</returns>
        public static void Koliko_kupimo(int koliko_v_paketu, int st_slicic)
        {
            int najvec = 0;
            int najmanj = 10000;
            int st_vseh_kupljenih = 0;
            bool[] album = new bool[st_slicic];


            for(int i = 0; i < 1000; i++)
            {
                int koliko_manjka = st_slicic;
                int stevilo_pokcev = 0;
                Ponastavi_album(album);

                while (koliko_manjka > 0)
                {
                    int[] nov_pokec = Generiraj_pokec(koliko_v_paketu, st_slicic);
                    stevilo_pokcev++;

                    koliko_manjka -= Koliko_nalepimo(nov_pokec, album);

                }
                if(stevilo_pokcev < najmanj)
                {
                    najmanj = stevilo_pokcev;
                }
                if(stevilo_pokcev > najvec)
                {
                    najvec = stevilo_pokcev;
                }
                st_vseh_kupljenih += stevilo_pokcev;
            }

            Console.WriteLine("Povprečno število pokcev, ki jih je potrebno kupiti, da zapolnimo album je " + st_vseh_kupljenih / 1000 + ".");
            Console.WriteLine("Najmanjše število pokcev, ki jih je potrebno kupiti, da zapolnimo album je " + najmanj + ".");
            Console.WriteLine("Največje število pokcev, ki jih je potrebno kupiti, da zapolnimo album je " + najvec + ".");
        }


        static void Main(string[] args)
        {

            Console.Write("Koliko slicic je v albumu: ");
            int st_slicic = int.Parse(Console.ReadLine());
            Console.Write("Koliko slicic ima en pokec: ");
            int v_pokcu = int.Parse(Console.ReadLine());

            Koliko_kupimo(v_pokcu, st_slicic);
  
        }
    }
}
