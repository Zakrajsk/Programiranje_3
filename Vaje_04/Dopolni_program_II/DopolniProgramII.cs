using System;

namespace Dopolni_program_II
{
    class DopolniProgramII
    {
        /// <summary>
        /// Sprašuje uporabnika da vnese integer dokler ga ne vnese
        /// </summary>
        /// <param name="text"></param>
        /// <returns>return int</returns>
        public static int PreberiInt(string text)
        {
            Console.Write(text);
            try
            {
                int st = int.Parse(Console.ReadLine());
                return st;
            }
            catch (FormatException)
            {
                Console.WriteLine("Nisi vnesel INTEGRJA!");
                return PreberiInt(text);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program izpiše vrednost izraza (a+b)/c, za cela števila a,b,c");
            int a = PreberiInt("Vnesi a: ");
            int b = PreberiInt("Vnesi b: ");

            while (true)
            {
                int c = PreberiInt("Vnesi c: ");
                try
                {
                    Console.WriteLine("(a+b)/c = " + ((a + b) / c));
                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Z 0 ni mogoce deliti");
                }

                catch (Exception e)
                {
                    Console.WriteLine("Nevem kaj je šlo narobe:");
                    Console.WriteLine(e.ToString());
                    break;
                }
            }

        }
    }
}
