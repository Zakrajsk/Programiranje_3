using System;

namespace Prozenje_napak_I
{
    class ProzenjeNapakI
    {
        static Random rng = new Random();
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
        /// Generira racune in sprasuje dokler uporabnik pravilno ne resi n racunov
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static void Racunanje(int n)
        {
            char[] tab_operacij = new char[] { '+', '-', '*' };
            int prvo, drugo;

            for (int i = 0; i < n; i++)
            {
                char op = tab_operacij[rng.Next(0, 3)];
                switch (op)
                {
                    case '+':
                        prvo = rng.Next(0, 101);
                        drugo = rng.Next(0, 101 - prvo);
                        while (true)
                        {
                            int rezultat = PreberiInt($"{prvo} {op} {drugo} = ");
                            if(rezultat == prvo + drugo)
                            {
                                break;
                            }
                        }
                        break;

                    case '-':
                        prvo = rng.Next(0, 101);
                        drugo = rng.Next(0, prvo + 1);
                        while (true)
                        {
                            int rezultat = PreberiInt($"{prvo} {op} {drugo} = ");
                            if (rezultat == prvo - drugo)
                            {
                                break;
                            }
                        }
                        break;

                    case '*':
                        prvo = rng.Next(0, 10);
                        drugo = rng.Next(0, 10);
                        while (true)
                        {
                            int rezultat = PreberiInt($"{prvo} {op} {drugo} = ");
                            if (rezultat == prvo * drugo)
                            {
                                break;
                            }
                        }
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Racunanje(10);
        }
    }
}
