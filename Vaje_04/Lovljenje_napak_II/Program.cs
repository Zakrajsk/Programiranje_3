using System;

namespace Lovljenje_napak_II
{
    class Program
    {
        /// <summary>
        /// Sprašuje uporabnika da vnese integer dokler ga ne vnese
        /// </summary>
        /// <param name="text"></param>
        /// <returns>return int</returns>
        public static int PreberiInt(string text)
        {
            Console.Write(text);
            string vnos = Console.ReadLine();
            try
            {
                int st = int.Parse(vnos);
                return st;
            }
            catch (FormatException)
            {
                Console.WriteLine($"NAPAKA: {vnos} ni celo stevilo!");
                return PreberiInt(text);
            }
        }

        /// <summary>
        /// Sprasuje uporabnika po stevilu dokler ne vpise stevila v nekih danih mejah
        /// </summary>
        /// <param name="text"></param>
        /// <param name="spMeja"></param>
        /// <param name="zgMeja"></param>
        /// <returns>return int</returns>
        public static int PreberiIntMeje(string text, int spMeja, int zgMeja)
        {
            while (true)
            {
                int vnos = PreberiInt(text);
                if (spMeja <= vnos && vnos <= zgMeja)
                {
                    return vnos;
                }
                else
                {
                    Console.WriteLine($"NAPAKA: {vnos} ni med {spMeja} in {zgMeja}");
                }
            }
        }

        /// <summary>
        /// Privzeto nastavi mejo med -100 in 100
        /// </summary>
        /// <param name="text"></param>
        /// <returns>return int</returns>
        public static int PreberiIntMeje(string text)
        {
            return PreberiIntMeje(text, -100, 100);
        }

        /// <summary>
        /// Prebere koliko elementov zelimo v tabeli in nato sprasuje dokler jih pravilno ne vnesemo
        /// </summary>
        /// <returns>return int[]</returns>
        public static int[] VnosTabele()
        {
            int st_elementov = PreberiIntMeje("Vnesi stevilo elementov: ", 0, 100);
            int[] tabela = new int[st_elementov];

            for (int i = 0; i < st_elementov; i++)
            {
                tabela[i] = PreberiIntMeje($"Vnesi {i + 1}. element: ");
            }
            return tabela;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PreberiIntMeje("Vnesi celo stevilo: "));
            int[] testna = VnosTabele();
            foreach (int st in testna)
            {
                Console.Write(st + " ");
            }
        }
    }
}
