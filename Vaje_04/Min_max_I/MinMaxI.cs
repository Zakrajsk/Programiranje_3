using System;

namespace Min_max_I
{
    class MinMaxI
    {
        /// <summary>
        /// Vrne tabelo [najmanjsi,  najvecji] element
        /// </summary>
        /// <param name="tabela"></param>
        /// <returns>return int[]</returns>
        public static int[] MinMax(int[] tabela)
        {
            int[] resitev = new int[2] { tabela[0], tabela[0] };
            foreach (int element in tabela)
            {
                if(element > resitev[1])
                {
                    resitev[1] = element;
                }
                if(element < resitev[0])
                {
                    resitev[0] = element;
                }
            }
            return resitev;
        }

        /// <summary>
        /// Vrne tabelo [najmanjsi, najvecji] element glede na dolžino niza
        /// </summary>
        /// <param name="tabela"></param>
        /// <returns>return string[]</returns>
        public static string[] MinMax(string[] tabela)
        {
            string[] resitev = new string[2] { tabela[0], tabela[0] };
            foreach (string element in tabela)
            {
                if (element.Length > resitev[1].Length)
                {
                    resitev[1] = element;
                }
                if (element.Length < resitev[0].Length)
                {
                    resitev[0] = element;
                }
            }
            return resitev;
        }

        static void Main(string[] args)
        {
            int[] test = new int[] { 2, 1, 5, 2, 9, 1, 2, 4, 3, 8, 7, 24, 42 };
            int[] rezultat = MinMax(test);
            Console.WriteLine($"min: {rezultat[0]} max: {rezultat[1]}");

            string[] test_string = new string[] { "burek", "pica", "kebab", "pomfri", "jufka", "strudel", "mongolska", "riba" };
            string[] rezultat_str = MinMax(test_string);
            Console.WriteLine($"min: {rezultat_str[0]} max: {rezultat_str[1]}");

        }
    }
}
