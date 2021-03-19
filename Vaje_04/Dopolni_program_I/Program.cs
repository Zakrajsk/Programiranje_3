using System;

namespace Dopolni_programI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program izpiše vrednost izraza (a+b)/c, za cela števila a,b,c");
            try
            {
                Console.Write("Vnesi a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Vnesi b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Vnesi c: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("(a+b)/c = " + ((a + b) / c));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Nisi vnesel INTEGRJA!");
                Console.WriteLine(e.ToString());
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Z 0 ni mogoce deliti");
                Console.WriteLine(e.ToString());
            }

            catch (Exception e)
            {
                Console.WriteLine("Nevem kaj je šlo narobe:");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
